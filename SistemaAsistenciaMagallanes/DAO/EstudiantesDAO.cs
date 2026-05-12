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
										DateTime fechaNacimiento, string numeroEncargado, int idSeccion, int RecibeReligion)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"INSERT INTO Estudiantes
                        (Cedula,Nombre,Apellido,FechaNacimiento,NumeroEncargado,IdSeccion,Estado, RecibeReligion)
                        VALUES
                        (@cedula,@nombre,@apellido,@fecha,@encargado,@seccion,1,@RecibeReligion)";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@cedula", cedula);
			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@apellido", apellido);
			cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
			cmd.Parameters.AddWithValue("@encargado", numeroEncargado);
			cmd.Parameters.AddWithValue("@seccion", idSeccion);
			cmd.Parameters.AddWithValue("@RecibeReligion", RecibeReligion);

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
								WHEN e.RecibeReligion = 1 THEN 'Si'
								ELSE 'No'
							END AS RecibeReligion,
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

		public void EditarEstudiante(int id,
									string cedula,
									string nombre,
									string apellido,
									DateTime fechaNacimiento,
									string numeroEncargado,
									bool estado,
									int RecibeReligion
								)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"UPDATE Estudiantes
								SET Cedula = @cedula,
									Nombre = @nombre,
									Apellido = @apellido,
									FechaNacimiento = @fecha,
									NumeroEncargado = @encargado,
									Estado = @estado,
									RecibeReligion = @RecibeReligion
								WHERE IdEstudiante = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@id", id);
			cmd.Parameters.AddWithValue("@cedula", cedula);
			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@apellido", apellido);
			cmd.Parameters.AddWithValue("@fecha", fechaNacimiento);
			cmd.Parameters.AddWithValue("@encargado", numeroEncargado);
			cmd.Parameters.AddWithValue("@estado", estado);
			cmd.Parameters.AddWithValue("@RecibeReligion", RecibeReligion);

			conexion.Open();
			cmd.ExecuteNonQuery();
			conexion.Close();
		}
		public void ProgramarCambioSeccion(
			int idEstudiante,
			int idSeccionActual,
			int idNuevaSeccion,
			string motivo
		)
		{
			if (idSeccionActual == idNuevaSeccion)
				return;

			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"
        INSERT INTO CambioSeccionPendiente
        (
            IdEstudiante,
            IdSeccionActual,
            IdNuevaSeccion,
            FechaRegistro,
            FechaEfectiva,
            Estado,
            Motivo
        )
        VALUES
        (
            @IdEstudiante,
            @IdSeccionActual,
            @IdNuevaSeccion,
            CAST(GETDATE() AS DATE),
            DATEADD(DAY, 1, CAST(GETDATE() AS DATE)),
            'Pendiente',
            @Motivo
        )";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdEstudiante", idEstudiante);
				cmd.Parameters.AddWithValue("@IdSeccionActual", idSeccionActual);
				cmd.Parameters.AddWithValue("@IdNuevaSeccion", idNuevaSeccion);
				cmd.Parameters.AddWithValue("@Motivo", motivo);

				cmd.ExecuteNonQuery();
			}
		}

		public void AplicarCambiosPendientes(int idUsuario)
		{
			using (SqlConnection conn = new ConexionBD().ObtenerConexion())
			{
				conn.Open();

				string query = @"

        UPDATE e
        SET e.IdSeccion = c.IdNuevaSeccion
        FROM Estudiantes e
        INNER JOIN CambioSeccionPendiente c
            ON e.IdEstudiante = c.IdEstudiante
        WHERE c.Estado = 'Pendiente'
        AND c.FechaEfectiva <= CAST(GETDATE() AS DATE);

        UPDATE CambioSeccionPendiente
        SET
            Estado = 'Aplicado',
            AplicadoPor = @IdUsuario,
            FechaAplicacion = GETDATE()
        WHERE Estado = 'Pendiente'
        AND FechaEfectiva <= CAST(GETDATE() AS DATE);
        ";

				SqlCommand cmd = new SqlCommand(query, conn);

				cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

				cmd.ExecuteNonQuery();
			}
		}
	}
}
