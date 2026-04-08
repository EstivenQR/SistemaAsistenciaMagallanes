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
	public class JustificacionesDAO
	{

		ConexionBD conexionBD = new ConexionBD();


		public DataTable ObtenerTodos()
		{
			SqlConnection conexion = conexionBD.ObtenerConexion(); 

			using (conexion)
			{
				string query = @"SELECT DISTINCT
								j.IdJustificacion,
								j.IdEstudiante,
								e.Nombre + ' ' + e.Apellido AS Estudiante,
								m.NombreMateria AS Materia,
								s.NombreSeccion AS Sección,
								j.Fecha,
								j.Motivo,
								j.Estado
							FROM Justificaciones j
							INNER JOIN Estudiantes e ON j.IdEstudiante = e.IdEstudiante
							INNER JOIN DetalleAsistencia da 
								ON j.IdEstudiante = da.IdEstudiante
							INNER JOIN Clase c 
								ON da.IdClase = c.IdClase AND j.Fecha = c.Fecha
							INNER JOIN DocenteSeccionMateria dsm ON c.IdAsignacion = dsm.IdAsignacion
							INNER JOIN Materias m ON dsm.IdMateria = m.IdMateria
							INNER JOIN Secciones s ON dsm.IdSeccion = s.IdSeccion
							ORDER BY j.Fecha DESC";

				SqlDataAdapter da = new SqlDataAdapter(query, conexion);
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
		}

		public void InsertarJustificacion(int idEstudiante, DateTime fecha, string motivo, int idUsuario)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();
			{
				conexion.Open();

				string query = @"INSERT INTO Justificaciones
                        (IdEstudiante, Fecha, Motivo, Estado, IdUsuario, FechaRegistro)
                        VALUES
                        (@IdEstudiante, @Fecha, @Motivo, 'Pendiente', @IdUsuario, GETDATE())";

				SqlCommand cmd = new SqlCommand(query, conexion);
				cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				cmd.Parameters.AddWithValue("@Fecha", fecha);
				cmd.Parameters.AddWithValue("@Motivo", motivo);
				cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

				cmd.ExecuteNonQuery();
			}
		}

		public void CambiarEstado(int id, string estado, int idAprobador)
		{
			using (SqlConnection con = conexionBD.ObtenerConexion())
			{
				con.Open();

				string query = @"UPDATE Justificaciones
							SET Estado = @Estado,
								IdUsuarioAprobador = @IdAprobador,
								FechaAprobacion = GETDATE()
							WHERE IdJustificacion = @Id";

				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@Estado", estado);
				cmd.Parameters.AddWithValue("@Id", id);
				cmd.Parameters.AddWithValue("@IdAprobador", idAprobador);

				cmd.ExecuteNonQuery();
			}
		}

		public void MarcarComoJustificado(int idEstudiante, DateTime fecha)
		{
			using (SqlConnection con = conexionBD.ObtenerConexion())
			{
				con.Open();

				string query = @"
        UPDATE DetalleAsistencia
        SET Estado = 'Justificado'
        WHERE IdEstudiante = @IdEstudiante
        AND IdClase IN (
            SELECT IdClase FROM Clase WHERE Fecha = @Fecha
        )";

				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				cmd.Parameters.AddWithValue("@Fecha", fecha);

				cmd.ExecuteNonQuery();
			}
		}

	}
}
