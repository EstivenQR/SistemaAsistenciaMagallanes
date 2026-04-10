using SistemaAsistenciaMagallanes.Conexion_BD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.DAO
{
	public class TareasDAO
	{
		public void CrearTarea(int idDocente, int idSeccion, int idMateria, string titulo, string descripcion, DateTime fechaEntrega)
		{
			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"INSERT INTO Tareas 
                            (IdDocente, IdSeccion, IdMateria, Titulo, Descripcion, FechaEntrega, Estado)
                            VALUES (@IdDocente, @IdSeccion, @IdMateria, @Titulo, @Descripcion, @FechaEntrega, 1)";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdDocente", idDocente);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);
				cmd.Parameters.AddWithValue("@IdMateria", idMateria);
				cmd.Parameters.AddWithValue("@Titulo", titulo);
				cmd.Parameters.AddWithValue("@Descripcion", descripcion);
				cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega);

				cmd.ExecuteNonQuery();
			}
		}
		public void FinalizarTarea(int idTarea)
		{
			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				string query = "UPDATE Tareas SET Estado = 0 WHERE IdTarea = @IdTarea";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdTarea", idTarea);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		public DataTable ObtenerSeccionesDocente(int IdUsuario)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"SELECT DISTINCT 
									s.IdSeccion,
									s.NombreSeccion + ' ' + CAST(s.Anio AS VARCHAR) AS NombreSeccion
								FROM Secciones s
								INNER JOIN DocenteSeccionMateria dsm 
									ON s.IdSeccion = dsm.IdSeccion
								WHERE dsm.IdUsuario = @IdUsuario
								AND s.Anio = YEAR(GETDATE())";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable ObtenerMateriasDocente(int IdUsuario, int idSeccion)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"
                SELECT DISTINCT 
					m.IdMateria,
					m.NombreMateria
				FROM Materias m
				INNER JOIN DocenteSeccionMateria dsm 
					ON m.IdMateria = dsm.IdMateria
				WHERE dsm.IdUsuario = @IdUsuario
				AND dsm.IdSeccion = @IdSeccion";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}



		public DataRow ObtenerTareaPorId(int idTarea)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"SELECT IdTarea, IdSeccion, IdMateria, Titulo, Descripcion, FechaEntrega
						 FROM Tareas
						 WHERE IdTarea = @IdTarea";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdTarea", idTarea);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			if (dt.Rows.Count > 0)
				return dt.Rows[0];

			return null;
		}

		public DataTable ObtenerTareas(int idDocente, int idSeccion, int idMateria)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"
                SELECT 
					IdTarea,
					IdSeccion,
					IdMateria,
					Titulo,
					Descripcion,
					FechaEntrega
				FROM Tareas
				WHERE IdDocente = @IdDocente
				AND IdSeccion = @IdSeccion
				AND IdMateria = @IdMateria
				AND Estado = 1";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdDocente", idDocente);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);
				cmd.Parameters.AddWithValue("@IdMateria", idMateria);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable ObtenerEstudiantesPorSeccion(int idSeccion)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"
                SELECT IdEstudiante,
                       Nombre + ' ' + Apellido AS Estudiante
                FROM Estudiantes
                WHERE IdSeccion = @IdSeccion
                AND Estado = 1";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public void GuardarEntrega(int idTarea, int idEstudiante, bool entregado, decimal porcentaje, int idDocente)
		{
			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"
		IF EXISTS (
			SELECT 1 FROM EntregaTareas 
			WHERE IdTarea = @IdTarea AND IdEstudiante = @IdEstudiante
		)
		BEGIN
			UPDATE EntregaTareas
			SET Entregado = @Entregado,
				Porcentaje = @Porcentaje,
				IdDocente = @IdDocente
			WHERE IdTarea = @IdTarea AND IdEstudiante = @IdEstudiante
		END
		ELSE
		BEGIN
			INSERT INTO EntregaTareas
			(IdTarea, IdEstudiante, Entregado, Porcentaje, IdDocente)
			VALUES (@IdTarea, @IdEstudiante, @Entregado, @Porcentaje, @IdDocente)
		END";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdTarea", idTarea);
				cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				cmd.Parameters.AddWithValue("@Entregado", entregado);
				cmd.Parameters.AddWithValue("@Porcentaje", porcentaje);
				cmd.Parameters.AddWithValue("@IdDocente", idDocente);

				cmd.ExecuteNonQuery();
			}
		}

		public void EliminarTarea(int idTarea)
		{
			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = "DELETE FROM Tareas WHERE IdTarea = @IdTarea";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdTarea", idTarea);

				cmd.ExecuteNonQuery();
			}
		}

		public void ActualizarTarea(int idTarea, int idSeccion, int idMateria, string titulo, string descripcion, DateTime fechaEntrega)
		{
			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"UPDATE Tareas 
						SET IdSeccion = @IdSeccion,
							IdMateria = @IdMateria,
							Titulo = @Titulo,
							Descripcion = @Descripcion,
							FechaEntrega = @FechaEntrega
						WHERE IdTarea = @IdTarea";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdTarea", idTarea);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);
				cmd.Parameters.AddWithValue("@IdMateria", idMateria);
				cmd.Parameters.AddWithValue("@Titulo", titulo);
				cmd.Parameters.AddWithValue("@Descripcion", descripcion);
				cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega);

				cmd.ExecuteNonQuery();
			}


		}

		public DataTable ObtenerTareasHoy(int idDocente)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"
		SELECT 
			s.NombreSeccion,
			m.NombreMateria,
			t.Titulo
		FROM Tareas t
		INNER JOIN Secciones s ON t.IdSeccion = s.IdSeccion
		INNER JOIN Materias m ON t.IdMateria = m.IdMateria
		WHERE t.IdDocente = @IdDocente
		AND CAST(t.FechaEntrega AS DATE) = CAST(GETDATE() AS DATE)
		AND t.Estado = 1";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdDocente", idDocente);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}
	}
}
