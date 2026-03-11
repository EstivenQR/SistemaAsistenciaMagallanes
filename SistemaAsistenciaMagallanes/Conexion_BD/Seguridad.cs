using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Conexion_BD
{
	internal class Seguridad
	{
		public static string Encriptar(string texto)
		{
			SHA256 sha256 = SHA256.Create();
			byte[] bytes = Encoding.UTF8.GetBytes(texto);
			byte[] hash = sha256.ComputeHash(bytes);

			StringBuilder resultado = new StringBuilder();

			foreach (byte b in hash)
			{
				resultado.Append(b.ToString("x2"));
			}

			return resultado.ToString();
		}
	}
}
