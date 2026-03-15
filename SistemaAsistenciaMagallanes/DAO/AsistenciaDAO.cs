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
	public class AsistenciaDAO
	{

		ConexionBD conexionBD = new ConexionBD();

		public DataTable ObtenerEstudiantesPorSeccion(int idSeccion)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"SELECT IdEstudiante, Nombre + ' ' + Apellido AS Estudiante
							FROM Estudiantes
							WHERE IdSeccion = @IdSeccion
                            AND Estado = 1";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable tabla = new DataTable();

			adapter.Fill(tabla);

			return tabla;
		}

		public void GuardarAsistencia(int idEstudiante, int idSeccion, int idMateria, DateTime fecha, string estado, int idDocente)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"INSERT INTO Asistencia
                            (IdEstudiante, IdSeccion, IdMateria, Fecha, Estado, IdDocente)
                            VALUES
                            (@IdEstudiante, @IdSeccion, @IdMateria, @Fecha, @Estado, @IdDocente)";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
			cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);
			cmd.Parameters.AddWithValue("@IdMateria", idMateria);
			cmd.Parameters.AddWithValue("@Fecha", fecha);
			cmd.Parameters.AddWithValue("@Estado", estado);
			cmd.Parameters.AddWithValue("@IdDocente", idDocente);

			conexion.Open();
			cmd.ExecuteNonQuery();
			conexion.Close();
		}

		public DataTable ObtenerSeccionesDocente(int idUsuario)
		{
			DataTable tabla = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				string query = @"SELECT DISTINCT s.IdSeccion, s.NombreSeccion
                             FROM DocenteSeccionMateria dsm
                             INNER JOIN Secciones s ON s.IdSeccion = dsm.IdSeccion
                             WHERE dsm.IdUsuario = @IdUsuario";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}

			return tabla;
		}

		public DataTable ObtenerMateriasDocente(int idUsuario, int idSeccion)
		{
			DataTable tabla = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				string query = @"SELECT m.IdMateria, m.NombreMateria
								FROM DocenteSeccionMateria dsm
								INNER JOIN Materias m ON m.IdMateria = dsm.IdMateria
								WHERE dsm.IdUsuario = @IdUsuario
								AND dsm.IdSeccion = @IdSeccion";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(tabla);
			}

			return tabla;
		}

	}
}
