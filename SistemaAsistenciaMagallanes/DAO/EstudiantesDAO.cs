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
	public class EstudiantesDAO
	{

		public void InsertarEstudiante(string cedula, string nombre, string apellido,
										DateTime fechaNacimiento, string numeroEncargado, int idSeccion)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"INSERT INTO Estudiantes
                        (Cedula,Nombre,Apellido,FechaNacimiento,NumeroEncargado,IdSeccion,Estado)
                        VALUES
                        (@cedula,@nombre,@apellido,@fecha,@encargado,@seccion,1)";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@cedula", cedula);
			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@apellido", apellido);
			cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
			cmd.Parameters.AddWithValue("@encargado", numeroEncargado);
			cmd.Parameters.AddWithValue("@seccion", idSeccion);

			conexion.Open();
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		public DataTable ObtenerEstudiantes(string buscar, bool? estado)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"SELECT 
							e.IdEstudiante,
							e.Cedula,
							e.Nombre,
							e.Apellido,
							e.FechaNacimiento,
							e.NumeroEncargado,
							e.IdSeccion,
							s.NombreSeccion AS Seccion,
							CASE 
								WHEN e.Estado = 1 THEN 'Activo'
								ELSE 'Inactivo'
							END AS Estado
							FROM Estudiantes e
							INNER JOIN Secciones s
							ON e.IdSeccion = s.IdSeccion
							WHERE 
							(e.Nombre LIKE @buscar OR e.Apellido LIKE @buscar OR e.Cedula LIKE @buscar)
							AND (@estado IS NULL OR e.Estado = @estado)"
;

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");

			if (estado == null)
				cmd.Parameters.AddWithValue("@estado", DBNull.Value);
			else
				cmd.Parameters.AddWithValue("@estado", estado);




			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable tabla = new DataTable();

			adapter.Fill(tabla);

			return tabla;
		}

		public void EditarEstudiante(int id, string cedula, string nombre, string apellido,
									DateTime fechaNacimiento, string numeroEncargado, int idSeccion, bool estado)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"UPDATE Estudiantes
                        SET Cedula = @cedula,
                            Nombre = @nombre,
                            Apellido = @apellido,
                            FechaNacimiento = @fecha,
                            NumeroEncargado = @encargado,
                            IdSeccion = @seccion,
                            Estado = @estado
                        WHERE IdEstudiante = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@cedula", cedula);
			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@apellido", apellido);
			cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
			cmd.Parameters.AddWithValue("@encargado", numeroEncargado);
			cmd.Parameters.AddWithValue("@seccion", idSeccion);
			cmd.Parameters.AddWithValue("@estado", estado);

			conexion.Open();
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
	}
}
