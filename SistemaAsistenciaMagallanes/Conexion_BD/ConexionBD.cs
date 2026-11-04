using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SistemaAsistenciaMagallanes.Conexion_BD
{
	public class ConexionBD
	{
		private static string cadenaActiva;
		private static readonly object candado = new object();

		private readonly string ruta;
		private readonly JObject config;

		public ConexionBD()
		{
			ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
			config = JObject.Parse(File.ReadAllText(ruta));
		}

		public SqlConnection ObtenerConexion()
		{
			if (cadenaActiva == null)
			{
				lock (candado)
				{
					if (cadenaActiva == null)
						cadenaActiva = BuscarServidor();
				}
			}
			return new SqlConnection(cadenaActiva);
		}

		public static void Reiniciar()
		{
			lock (candado) { cadenaActiva = null; }
		}

		// ---------- Prueba la lista del config.json ----------
		private string BuscarServidor()
		{
			foreach (string servidor in ObtenerServidores())
			{
				try
				{
					using (var conn = new SqlConnection(ArmarCadena(servidor, 3)))
						conn.Open();

					return ArmarCadena(servidor, 15);
				}
				catch (SqlException) { }
			}

			throw new Exception(
				"No se pudo conectar a la base de datos.\n" +
				"Verifique la red o use el botón 'Detectar servidor'.");
		}

		private List<string> ObtenerServidores()
		{
			var lista = config["Servidores"] as JArray;
			if (lista != null && lista.Count > 0)
				return lista.Select(s => s.ToString().Trim()).Where(s => s != "").ToList();

			string servidor = config["Servidor"]?.ToString();
			string instancia = config["Instancia"]?.ToString();
			return new List<string>
			{
				string.IsNullOrWhiteSpace(instancia) ? servidor : $"{servidor}\\{instancia}"
			};
		}

		private string ArmarCadena(string dataSource, int timeoutSegundos)
		{
			string baseDatos = config["BaseDatos"].ToString();
			bool integrada = (bool)config["IntegratedSecurity"];

			string cadena =
				$"Data Source={dataSource};" +
				$"Initial Catalog={baseDatos};" +
				$"Connect Timeout={timeoutSegundos};" +
				$"TrustServerCertificate=True;";

			cadena += integrada
				? "Integrated Security=True;"
				: $"User ID={config["Usuario"]};Password={config["Password"]};";

			return cadena;
		}

		// ---------- Detección automática (botón) ----------
		public static string DetectarYGuardar()
		{
			var cfg = new ConexionBD();

			foreach (string servidor in cfg.BuscarEnRed())
			{
				try
				{
					using (var conn = new SqlConnection(cfg.ArmarCadena(servidor, 3)))
						conn.Open();   // valida usuario, contraseña y base de datos
				}
				catch (SqlException)
				{
					continue;          // otro SQL Server que no es el nuestro
				}

				// Poner la IP encontrada de primera, sin duplicados
				var lista = (cfg.config["Servidores"] as JArray ?? new JArray())
					.Select(s => s.ToString())
					.Where(s => s != servidor)
					.ToList();
				lista.Insert(0, servidor);

				cfg.config["Servidores"] = new JArray(lista);
				File.WriteAllText(cfg.ruta, cfg.config.ToString());

				// Usar la dirección encontrada desde ya, en toda la aplicación
				lock (candado) { cadenaActiva = cfg.ArmarCadena(servidor, 15); }

				return servidor;
			}

			return null;
		}

		private List<string> BuscarEnRed()
		{
			var encontrados = new ConcurrentBag<string>();

			foreach (var ni in NetworkInterface.GetAllNetworkInterfaces()
				.Where(n => n.OperationalStatus == OperationalStatus.Up &&
							n.NetworkInterfaceType != NetworkInterfaceType.Loopback))
			{
				foreach (var ua in ni.GetIPProperties().UnicastAddresses
					.Where(a => a.Address.AddressFamily == AddressFamily.InterNetwork))
				{
					byte[] b = ua.Address.GetAddressBytes();

					Parallel.For(1, 255, new ParallelOptions { MaxDegreeOfParallelism = 64 }, i =>
					{
						string ip = $"{b[0]}.{b[1]}.{b[2]}.{i}";
						try
						{
							using (var tcp = new TcpClient())
							{
								var r = tcp.BeginConnect(ip, 1433, null, null);
								if (r.AsyncWaitHandle.WaitOne(300) && tcp.Connected)
									encontrados.Add(ip + ",1433");
							}
						}
						catch { }
					});
				}
			}

			return encontrados.Distinct().ToList();
		}
	}
}