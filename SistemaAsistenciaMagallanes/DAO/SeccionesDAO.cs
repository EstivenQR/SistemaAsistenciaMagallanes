using SistemaAsistenciaMagallanes.Conexion_BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.DAO
{
	public class SeccionesDAO
	{
		public DataTable ObtenerSecciones(string buscar)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"SELECT 
									IdSeccion,
									(NombreSeccion + ' ' + CAST(Anio AS VARCHAR)) AS Sección
								FROM Secciones
								WHERE NombreSeccion LIKE @buscar
								AND Anio IN (YEAR(GETDATE()), YEAR(GETDATE()) + 1)
								ORDER BY  Anio, NombreSeccion ASC";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable tabla = new DataTable();

			adapter.Fill(tabla);

			return tabla;
		}

		public void InsertarSeccion(string nombre, int anio)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = "INSERT INTO Secciones (NombreSeccion,Anio) VALUES (@nombre, @anio)";
			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@anio", anio);

			cmd.ExecuteNonQuery();
			conexion.Close();
		}

		public void EliminarSeccion(int idSeccion)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = "DELETE FROM Secciones WHERE IdSeccion = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@id", idSeccion);

			cmd.ExecuteNonQuery();
			conexion.Close();
		}
	}
}
