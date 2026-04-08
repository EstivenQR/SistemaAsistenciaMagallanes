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
	public class AsignacionDocenteDAO
	{


		public void InsertarAsignacion(int idUsuario, int idSeccion, int idMateria)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = @"INSERT INTO DocenteSeccionMateria
                        (IdUsuario, IdSeccion, IdMateria)
                        VALUES
                        (@usuario, @seccion, @materia)";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@usuario", idUsuario);
			cmd.Parameters.AddWithValue("@seccion", idSeccion);
			cmd.Parameters.AddWithValue("@materia", idMateria);

			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		public DataTable ObtenerAsignaciones(string buscar)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"SELECT 
                        d.IdAsignacion,
                        u.Nombre AS Docente,
                        s.NombreSeccion AS Seccion,
						s.Anio AS Año,
                        m.NombreMateria AS Materia
                        FROM DocenteSeccionMateria d
                        INNER JOIN Usuarios u ON d.IdUsuario = u.IdUsuario
                        INNER JOIN Secciones s ON d.IdSeccion = s.IdSeccion
                        INNER JOIN Materias m ON d.IdMateria = m.IdMateria
                        WHERE u.Nombre LIKE @buscar
                        OR s.NombreSeccion LIKE @buscar
                        OR m.NombreMateria LIKE @buscar";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable tabla = new DataTable();

			adapter.Fill(tabla);

			return tabla;
		}


		public DataTable ListarSeccionesPorAnios(List<int> anios)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			DataTable dt = new DataTable();

			using (SqlConnection conn = conexionBD.ObtenerConexion())
			{
				conn.Open();

				string listaAnios = string.Join(",", anios);

				string query = $@" SELECT IdSeccion, NombreSeccion, Anio
									FROM Secciones
									WHERE Anio IN ({listaAnios})
									ORDER BY Anio DESC, NombreSeccion DESC";

				SqlDataAdapter da = new SqlDataAdapter(query, conn);
				da.Fill(dt);
			}

			return dt;
		}

		public bool ExisteAsignacion(int idSeccion, int idMateria)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = @"SELECT COUNT(*)
                        FROM DocenteSeccionMateria
                        WHERE IdSeccion = @seccion
                        AND IdMateria = @materia";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@seccion", idSeccion);
			cmd.Parameters.AddWithValue("@materia", idMateria);

			int count = (int)cmd.ExecuteScalar();

			conexion.Close();

			return count > 0;
		}


		public void EliminarAsignacion(int idAsignacion)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = @"DELETE FROM DocenteSeccionMateria
                        WHERE IdAsignacion = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@id", idAsignacion);

			cmd.ExecuteNonQuery();

			conexion.Close();
		}

	}
}
