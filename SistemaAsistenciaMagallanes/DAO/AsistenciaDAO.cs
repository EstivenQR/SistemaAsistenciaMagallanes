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

		public DataTable ObtenerEstudiantesPorSeccion(int idSeccion, int idAsignacion)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"
							SELECT 
								e.IdEstudiante, 
								e.Apellido + ' ' + e.Nombre AS Estudiante
							FROM Estudiantes e
							INNER JOIN DocenteSeccionMateria dsm 
								ON dsm.IdAsignacion = @IdAsignacion
							INNER JOIN Materias m 
								ON dsm.IdMateria = m.IdMateria
							WHERE e.IdSeccion = @IdSeccion
							AND e.Estado = 1
							AND (
								m.NombreMateria COLLATE Latin1_General_CI_AI NOT LIKE '%religion%'
								OR (
									m.NombreMateria COLLATE Latin1_General_CI_AI LIKE '%religion%'
									AND e.RecibeReligion = 1
								)
							)
							ORDER BY e.Apellido COLLATE Latin1_General_CI_AI";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@IdSeccion", idSeccion);
			cmd.Parameters.AddWithValue("@IdAsignacion", idAsignacion);

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
				string query = @"
								SELECT 
									s.IdSeccion, 
									(s.NombreSeccion + ' ' + CAST(s.Anio AS VARCHAR)) AS NombreSeccion
								FROM DocenteSeccionMateria dsm
								INNER JOIN Secciones s ON s.IdSeccion = dsm.IdSeccion
								WHERE dsm.IdUsuario = @IdUsuario
								AND s.Anio = YEAR(GETDATE())
								GROUP BY s.IdSeccion, s.NombreSeccion, s.Anio
								ORDER BY s.NombreSeccion ASC";

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
				string query = @"SELECT 
								dsm.IdAsignacion,
								m.NombreMateria
								FROM DocenteSeccionMateria dsm
								INNER JOIN Materias m ON dsm.IdMateria = m.IdMateria
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

		public int CrearClase(int idAsignacion, DateTime fecha)
		{
			int idClase = 0;

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"
				INSERT INTO Clase (IdAsignacion, Fecha)
				OUTPUT INSERTED.IdClase
				VALUES (@IdAsignacion, @Fecha)";

				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@IdAsignacion", idAsignacion);
				cmd.Parameters.AddWithValue("@Fecha", fecha);

				idClase = (int)cmd.ExecuteScalar();
			}

			return idClase;
		}

		public void GuardarDetalleAsistencia(int idClase, int idEstudiante, string estado)
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"
				INSERT INTO DetalleAsistencia (IdClase, IdEstudiante, Estado)
				VALUES (@IdClase, @IdEstudiante, @Estado)";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdClase", idClase);
				cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				cmd.Parameters.AddWithValue("@Estado", estado);

				cmd.ExecuteNonQuery();
			}
		}

		public bool ExisteClase(int idAsignacion, DateTime fecha)
		{
			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string query = @"
            SELECT COUNT(*) 
            FROM Clase
            WHERE IdAsignacion = @IdAsignacion
            AND CAST(Fecha AS DATE) = @Fecha";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdAsignacion", idAsignacion);
				cmd.Parameters.AddWithValue("@Fecha", fecha.Date);

				int count = (int)cmd.ExecuteScalar();

				return count > 0;
			}
		}



	}
}
