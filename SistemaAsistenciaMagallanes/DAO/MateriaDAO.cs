using SistemaAsistenciaMagallanes.Conexion_BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAsistenciaMagallanes.Models;

namespace SistemaAsistenciaMagallanes.DAO
{
	public class MateriaDAO
	{

		private ConexionBD conexion = new ConexionBD();

		public DataTable ObtenerMaterias(string buscar)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"SELECT 
                            IdMateria,
                            NombreMateria AS Materia
                            FROM Materias
                            WHERE NombreMateria LIKE @buscar";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable tabla = new DataTable();

			adapter.Fill(tabla);

			return tabla;
		}

		public void InsertarMateria(string nombre)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = "INSERT INTO Materias (NombreMateria) VALUES (@nombre)";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@nombre", nombre);

			cmd.ExecuteNonQuery();
			conexion.Close();
		}

		public void ActualizarMateria(int idMateria, string nombre)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = @"UPDATE Materias 
                            SET NombreMateria = @nombre
                            WHERE IdMateria = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@id", idMateria);

			cmd.ExecuteNonQuery();
			conexion.Close();
		}

		public void EliminarMateria(int idMateria)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = "DELETE FROM Materias WHERE IdMateria = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@id", idMateria);

			cmd.ExecuteNonQuery();
			conexion.Close();
		}

	}
}
