using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAsistenciaMagallanes.Conexion_BD;

namespace SistemaAsistenciaMagallanes.DAO
{
	public class ReportesDAO
	{
		ConexionBD conexionBD = new ConexionBD();
		public DataTable ObtenerReporte(int? idEstudiante, int? idSeccion, int? idMateria, DateTime? desde, DateTime? hasta)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"SELECT 
									e.IdEstudiante,
									c.Fecha,
									e.Nombre + ' ' + e.Apellido AS Estudiante,
									m.NombreMateria AS Materia,
									s.NombreSeccion AS Sección,
									da.Estado
								FROM DetalleAsistencia da
								INNER JOIN Clase c ON da.IdClase = c.IdClase
								INNER JOIN DocenteSeccionMateria dsm ON c.IdAsignacion = dsm.IdAsignacion
								INNER JOIN Estudiantes e ON da.IdEstudiante = e.IdEstudiante
								INNER JOIN Materias m ON dsm.IdMateria = m.IdMateria
								INNER JOIN Secciones s ON dsm.IdSeccion = s.IdSeccion
								WHERE 1=1
								AND (@IdEstudiante IS NULL OR e.IdEstudiante = @IdEstudiante)
								AND (@IdSeccion IS NULL OR s.IdSeccion = @IdSeccion)
								AND (@IdMateria IS NULL OR m.IdMateria = @IdMateria)
								AND (@Desde IS NULL OR c.Fecha >= @Desde)
								AND (@Hasta IS NULL OR c.Fecha <= @Hasta)
								ORDER BY c.Fecha DESC";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdEstudiante", (object)idEstudiante ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IdSeccion", (object)idSeccion ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IdMateria", (object)idMateria ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@Desde", (object)desde ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@Hasta", (object)hasta ?? DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable ObtenerSecciones(int idUsuario)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				string query = @"
								SELECT 
									s.IdSeccion, 
									(s.NombreSeccion + ' ' + CAST(s.Anio AS VARCHAR)) AS NombreSeccion
								FROM DocenteSeccionMateria dsm
								INNER JOIN Secciones s ON dsm.IdSeccion = s.IdSeccion
								WHERE dsm.IdUsuario = @IdUsuario
								GROUP BY s.IdSeccion, s.NombreSeccion, s.Anio
								ORDER BY s.Anio DESC, s.NombreSeccion ASC";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable ObtenerMaterias(int idUsuario, int idSeccion)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				string query = @"
				SELECT DISTINCT m.IdMateria, m.NombreMateria
				FROM DocenteSeccionMateria dsm
				INNER JOIN Materias m ON dsm.IdMateria = m.IdMateria
				WHERE dsm.IdUsuario = @IdUsuario
				AND dsm.IdSeccion = @IdSeccion";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		//ESTUDIANTES por sección
		public DataTable ObtenerEstudiantes(int idSeccion)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				string query = @"
                SELECT IdEstudiante,
                       (Nombre + ' ' + Apellido) AS NombreCompleto
                FROM Estudiantes
                WHERE IdSeccion = @IdSeccion";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable FiltrarReportes(int? idSeccion, int? idMateria, int? idEstudiante)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				string query = @"
                SELECT 
					e.IdEstudiante
                    e.Nombre + ' ' + e.Apellido AS Estudiante,
                    s.NombreSeccion,
                    m.NombreMateria,
                    a.Fecha,
                    a.Estado
                FROM Asistencia a
                INNER JOIN Estudiantes e ON a.IdEstudiante = e.IdEstudiante
                INNER JOIN Secciones s ON e.IdSeccion = s.IdSeccion
                INNER JOIN Materias m ON a.IdMateria = m.IdMateria
                WHERE
                    (@IdSeccion IS NULL OR s.IdSeccion = @IdSeccion)
                AND (@IdMateria IS NULL OR m.IdMateria = @IdMateria)
                AND (@IdEstudiante IS NULL OR e.IdEstudiante = @IdEstudiante)
                ORDER BY a.Fecha DESC";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdSeccion", (object)idSeccion ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IdMateria", (object)idMateria ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IdEstudiante", (object)idEstudiante ?? DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable ObtenerReporteTareas(
	int? idSeccion,
	int? idMateria,
	DateTime? desde,
	DateTime? hasta,
	int idDocente)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"
		SELECT 
			e.IdEstudiante,
			e.Nombre + ' ' + e.Apellido AS Estudiante,
			t.IdTarea,
			t.Titulo,
			t.FechaEntrega,
			ISNULL(et.Entregado, 0) AS Entregado,
			ISNULL(et.Porcentaje, 0) AS Porcentaje
		FROM Tareas t
		INNER JOIN Estudiantes e ON e.IdSeccion = t.IdSeccion
		LEFT JOIN EntregaTareas et 
			ON et.IdTarea = t.IdTarea 
			AND et.IdEstudiante = e.IdEstudiante
		WHERE t.IdDocente = @IdDocente
		AND (@IdSeccion IS NULL OR t.IdSeccion = @IdSeccion)
		AND (@IdMateria IS NULL OR t.IdMateria = @IdMateria)
		AND (@Desde IS NULL OR t.FechaEntrega >= @Desde)
		AND (@Hasta IS NULL OR t.FechaEntrega <= @Hasta)";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdDocente", idDocente);
				cmd.Parameters.AddWithValue("@IdSeccion", (object)idSeccion ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IdMateria", (object)idMateria ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@Desde", (object)desde ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@Hasta", (object)hasta ?? DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable ObtenerReporteTareasPDF(int? idSeccion, int? idMateria, int? idEstudiante)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				string query = @"
								SELECT 
							e.Nombre + ' ' + e.Apellido AS Estudiante,
							m.NombreMateria,
							s.NombreSeccion,
							t.Titulo,
							ISNULL(et.Porcentaje, 0) AS Nota
						FROM Tareas t
						INNER JOIN Materias m ON t.IdMateria = m.IdMateria
						INNER JOIN Secciones s ON t.IdSeccion = s.IdSeccion
						INNER JOIN Estudiantes e ON e.IdSeccion = s.IdSeccion
						LEFT JOIN EntregaTareas et 
							ON et.IdTarea = t.IdTarea 
							AND et.IdEstudiante = e.IdEstudiante
						WHERE e.Estado = 1
						AND (@IdSeccion IS NULL OR t.IdSeccion = @IdSeccion)
						AND (@IdMateria IS NULL OR t.IdMateria = @IdMateria)
						AND (@IdEstudiante IS NULL OR e.IdEstudiante = @IdEstudiante)";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdSeccion", (object)idSeccion ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IdMateria", (object)idMateria ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@IdEstudiante", (object)idEstudiante ?? DBNull.Value);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public int ObtenerTotalEstudiantes()
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Estudiantes", conn);
				return (int)cmd.ExecuteScalar();
			}
		}

		public int ObtenerTotalProfesores()
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE IdRol = '3'", conn);
				return (int)cmd.ExecuteScalar();
			}
		}

		public int ObtenerPresentesHoy()
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand(@"
            SELECT COUNT(*) 
            FROM DetalleAsistencia da
            INNER JOIN Clase c ON da.IdClase = c.IdClase
            WHERE c.Fecha = CAST(GETDATE() AS DATE)
            AND da.Estado = 'Presente'", conn);

				return (int)cmd.ExecuteScalar();
			}
		}

		public int ObtenerAusentesHoy()
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand(@"
            SELECT COUNT(*) 
            FROM DetalleAsistencia da
            INNER JOIN Clase c ON da.IdClase = c.IdClase
            WHERE c.Fecha = CAST(GETDATE() AS DATE)
            AND da.Estado = 'Ausente'", conn);

				return (int)cmd.ExecuteScalar();
			}
		}

	}
}
