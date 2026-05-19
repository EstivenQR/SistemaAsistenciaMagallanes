using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;



namespace SistemaAsistenciaMagallanes.Conexion_BD
{
	internal class ConexionBD
	{
		private string CadenaConexion =
			ConfigurationManager
			.ConnectionStrings["conexion"]
			.ConnectionString;

		public SqlConnection ObtenerConexion()
		{
			return new SqlConnection(CadenaConexion);
		}
	}
}
