using SistemaAsistenciaMagallanes.Conexion_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DocumentFormat.OpenXml.Spreadsheet;

namespace SistemaAsistenciaMagallanes.DAO
{
	public class BoletasDAO
	{
		 ConexionBD conexionBD = new ConexionBD();



		public void InsertarBoleta(int idEstudiante, DateTime fecha, string motivo, int porcentaje, int idUsuario)
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"INSERT INTO Boletas 
                            (IdEstudiante, Fecha, Motivo, Porcentaje, IdUsuario)
                            VALUES (@IdEstudiante, @Fecha, @Motivo, @Porcentaje, @IdUsuario)";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				cmd.Parameters.AddWithValue("@Fecha", fecha);
				cmd.Parameters.AddWithValue("@Motivo", motivo);
				cmd.Parameters.AddWithValue("@Porcentaje", porcentaje);
				cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

				cmd.ExecuteNonQuery();
			}
		}

		public DataTable ObtenerBoletas(int idUsuario, int idRol)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query;

				if (idRol == 2 || idRol == 4 || idRol == 1) // ADMIN
				{
					query = @"
            SELECT b.IdBoleta,
                   b.IdEstudiante,
                   e.IdSeccion,
                   e.Nombre + ' ' + e.Apellido AS Estudiante,
                   s.NombreSeccion AS Seccion,
                   b.Fecha,
                   b.Motivo,
                   b.Porcentaje AS Puntos
            FROM Boletas b
            INNER JOIN Estudiantes e ON b.IdEstudiante = e.IdEstudiante
            INNER JOIN Secciones s ON e.IdSeccion = s.IdSeccion
            ORDER BY b.Fecha DESC";
				}
				else if (idRol == 3) // DOCENTE
				{
					query = @"
            SELECT b.IdBoleta,
                   b.IdEstudiante,
                   e.IdSeccion,
                   e.Nombre + ' ' + e.Apellido AS Estudiante,
                   s.NombreSeccion AS Seccion,
                   b.Fecha,
                   b.Motivo,
                   b.Porcentaje AS Puntos
            FROM Boletas b
            INNER JOIN Estudiantes e ON b.IdEstudiante = e.IdEstudiante
            INNER JOIN Secciones s ON e.IdSeccion = s.IdSeccion
            INNER JOIN DocenteSeccionMateria dsm 
                ON e.IdSeccion = dsm.IdSeccion
            WHERE dsm.IdUsuario = @IdUsuario
            ORDER BY b.Fecha DESC";
				}
				else
				{
					throw new Exception("Rol no válido");
				}

				SqlCommand cmd = new SqlCommand(query, conn);

				if (idRol == 3)
				{
					cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
				}

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

		public DataTable ObtenerSeccionesPorRol(int idUsuario, int idRol)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query;

				if ( idRol == 1 || idRol == 2 || idRol == 4) //ADMIN
				{
					query = "SELECT IdSeccion,  (NombreSeccion + ' ' + CAST(Anio AS VARCHAR)) AS NombreSeccion FROM Secciones";
				}
				else if (idRol == 3) //DOCENTE
				{
					query = @"
                SELECT DISTINCT s.IdSeccion, (s.NombreSeccion + ' ' + CAST(s.Anio AS VARCHAR)) AS NombreSeccion
                FROM DocenteSeccionMateria dsm
                INNER JOIN Secciones s ON dsm.IdSeccion = s.IdSeccion
                WHERE dsm.IdUsuario = @IdUsuario";
				}
				else
				{
					throw new Exception("Rol no válido: " + idRol);
				}

				SqlCommand cmd = new SqlCommand(query, conn);

				//SOLO agrega parámetro si es docente
				if (idRol == 3)
				{
					cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
				}

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}


		public DataTable ObtenerEstudiantesPorRol(int idUsuario, int rol)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = "";

				if (rol == 1 || rol == 2 || rol == 4) // ADMIN
				{
					query = @"SELECT IdEstudiante,
                             Nombre + ' ' + Apellido AS NombreCompleto
                      FROM Estudiantes";
				}
				else if (rol == 3)// DOCENTE
				{
					query = @"
                SELECT DISTINCT e.IdEstudiante,
                       e.Nombre + ' ' + e.Apellido AS NombreCompleto
                FROM DocenteSeccionMateria dsm
                INNER JOIN Estudiantes e ON dsm.IdSeccion = e.IdSeccion
                WHERE dsm.IdUsuario = @IdUsuario";
				}

				SqlCommand cmd = new SqlCommand(query, conn);

				if (rol != 2 )
					cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}


		public DataTable ObtenerEstudiantesPorSeccion(int idSeccion)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"
            SELECT IdEstudiante,
                   Nombre + ' ' + Apellido AS NombreCompleto
            FROM Estudiantes
            WHERE IdSeccion = @IdSeccion";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}


		public void EliminarBoleta(int idBoleta)
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = "DELETE FROM Boletas WHERE IdBoleta = @IdBoleta";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdBoleta", idBoleta);

				cmd.ExecuteNonQuery();
			}
		}


		public void ActualizarBoleta(int idBoleta, int idEstudiante, DateTime fecha, string motivo, int porcentaje)
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"UPDATE Boletas 
                         SET IdEstudiante = @IdEstudiante,
                             Fecha = @Fecha,
                             Motivo = @Motivo,
                             Porcentaje = @Porcentaje
                         WHERE IdBoleta = @IdBoleta";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdBoleta", idBoleta);
				cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				cmd.Parameters.AddWithValue("@Fecha", fecha);
				cmd.Parameters.AddWithValue("@Motivo", motivo);
				cmd.Parameters.AddWithValue("@Porcentaje", porcentaje);

				cmd.ExecuteNonQuery();
			}
		}

		public DataRow ObtenerBoletaPorId(int idBoleta)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"
            SELECT b.IdBoleta,
				   b.IdEstudiante,
                   e.Nombre + ' ' + e.Apellido AS Estudiante,e.IdSeccion,
                   s.NombreSeccion AS Seccion,
                   b.Fecha,
                   b.Motivo,
                   b.Porcentaje AS Puntos
            FROM Boletas b
            INNER JOIN Estudiantes e ON b.IdEstudiante = e.IdEstudiante
            INNER JOIN Secciones s ON e.IdSeccion = s.IdSeccion
            WHERE b.IdBoleta = @IdBoleta";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdBoleta", idBoleta);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt.Rows.Count > 0 ? dt.Rows[0] : null;
		}

		public DataTable ObtenerBoletasReporte(int? idSeccion, int? idEstudiante, DateTime? fechaInicio, DateTime? fechaFin)
		{
			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"
        SELECT 
            b.IdBoleta,
			b.IdEstudiante,
            e.Nombre + ' ' + e.Apellido AS Estudiante,e.IdSeccion,
            s.NombreSeccion AS Seccion,
            b.Fecha,
            b.Motivo,
            b.Porcentaje AS Puntos
        FROM Boletas b
        INNER JOIN Estudiantes e ON b.IdEstudiante = e.IdEstudiante
        INNER JOIN Secciones s ON e.IdSeccion = s.IdSeccion
        WHERE 1=1 ";

				SqlCommand cmd = new SqlCommand();

				// 🔥 FILTRO SECCIÓN
				if (idSeccion.HasValue && idSeccion != 0)
				{
					query += " AND s.IdSeccion = @IdSeccion";
					cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);
				}

				// 🔥 FILTRO ESTUDIANTE
				if (idEstudiante.HasValue && idEstudiante != 0)
				{
					query += " AND e.IdEstudiante = @IdEstudiante";
					cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				}

				// 🔥 FILTRO FECHA INICIO
				if (fechaInicio.HasValue)
				{
					query += " AND b.Fecha >= @FechaInicio";
					cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Value.Date);
				}

				// 🔥 FILTRO FECHA FIN
				if (fechaFin.HasValue)
				{
					query += " AND b.Fecha <= @FechaFin";
					cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Value.Date);
				}

				query += " ORDER BY b.Fecha DESC";

				cmd.CommandText = query;
				cmd.Connection = conn;

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
			}

			return dt;
		}

	}
}
