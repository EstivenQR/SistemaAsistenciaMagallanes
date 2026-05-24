using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json.Linq;
using System.IO;



namespace SistemaAsistenciaMagallanes.Conexion_BD
{
	public class ConexionBD
	{
		private string cadenaConexion;

		public ConexionBD()
		{
			string ruta = Path.Combine(
				AppDomain.CurrentDomain.BaseDirectory,
				"config.json"
			);

			string json = File.ReadAllText(ruta);

			JObject config = JObject.Parse(json);

			string servidor = config["Servidor"].ToString();
			string instancia = config["Instancia"].ToString();
			string baseDatos = config["BaseDatos"].ToString();
			bool integratedSecurity = (bool)config["IntegratedSecurity"];

			if (string.IsNullOrWhiteSpace(instancia))
			{
				cadenaConexion =
					$"Data Source={servidor};" +
					$"Initial Catalog={baseDatos};" +
					$"Integrated Security={integratedSecurity}";
			}
			else
			{
				cadenaConexion =
					$"Data Source={servidor}\\{instancia};" +
					$"Initial Catalog={baseDatos};" +
					$"Integrated Security={integratedSecurity}";
			}
		}

		public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(cadenaConexion);
		}
	}
}
