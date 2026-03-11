using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SistemaAsistenciaMagallanes.Conexion_BD
{
	internal class ConexionBD
	{
		private string CadenaConexion = "Server=localhost;Database=BD_ASISTENCIAMAGALLANES;Trusted_Connection=True";

		public SqlConnection ObtenerConexion(){
		
			SqlConnection conexion = new SqlConnection(CadenaConexion);
			return conexion;

		}
	}
}
