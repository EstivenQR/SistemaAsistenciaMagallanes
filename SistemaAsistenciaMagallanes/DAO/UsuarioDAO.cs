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
	internal class UsuarioDAO
	{

		public SqlDataReader Login(string usuario, string password)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"SELECT IdUsuario, Nombre, IdRol
                        FROM Usuarios
                        WHERE Usuario = @usuario
                        AND Password = @password
                        AND Estado = 1";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@usuario", usuario);
			cmd.Parameters.AddWithValue("@password", password);

			conexion.Open();

			return cmd.ExecuteReader();
		}


		public void InsertarUsuario(string nombre, string usuario, string password, int rol, int estado)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = "INSERT INTO Usuarios (Nombre,Usuario,Password,IdRol,Estado) VALUES (@nombre,@usuario,@pass,@rol,@estado)";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@usuario", usuario);
			cmd.Parameters.AddWithValue("@pass", password);
			cmd.Parameters.AddWithValue("@rol", rol);
			cmd.Parameters.AddWithValue("@estado", estado);

			cmd.ExecuteNonQuery();

			conexion.Close();
		}
		public void ActualizarUsuario(int idUsuario, string nombre, string usuario, int rol, int estado)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			conexion.Open();

			string consulta = @"UPDATE Usuarios 
                        SET Nombre = @nombre,
                            Usuario = @usuario,
                            IdRol = @rol,
                            Estado = @estado
                        WHERE IdUsuario = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);

			cmd.Parameters.AddWithValue("@id", idUsuario);
			cmd.Parameters.AddWithValue("@nombre", nombre);
			cmd.Parameters.AddWithValue("@usuario", usuario);
			cmd.Parameters.AddWithValue("@rol", rol);
			cmd.Parameters.AddWithValue("@estado", estado);

			cmd.ExecuteNonQuery();

			conexion.Close();
		}

		public DataTable ObtenerUsuarios(string buscar, bool mostrarInactivos)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = @"SELECT 
        u.IdUsuario,
        u.Nombre,
        u.Usuario,
        r.NombreRol AS Rol,
        CASE 
            WHEN u.Estado = 1 THEN 'Activo'
            ELSE 'Inactivo'
        END AS Estado
        FROM Usuarios u
        INNER JOIN Roles r ON u.IdRol = r.IdRol
        WHERE (u.Nombre LIKE @buscar 
        OR u.Usuario LIKE @buscar)
        AND (@mostrarInactivos = 1 OR u.Estado = 1)";

			if (!mostrarInactivos)
			{
				consulta += " AND u.Estado = 1";
			}

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
			cmd.Parameters.AddWithValue("@mostrarInactivos", mostrarInactivos);

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable tabla = new DataTable();

			adapter.Fill(tabla);

			return tabla;
		}

		public DataRow ObtenerUsuarioPorId(int id)
		{
			ConexionBD conexionBD = new ConexionBD();
			SqlConnection conexion = conexionBD.ObtenerConexion();

			string consulta = "SELECT * FROM Usuarios WHERE IdUsuario = @id";

			SqlCommand cmd = new SqlCommand(consulta, conexion);
			cmd.Parameters.AddWithValue("@id", id);

			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable tabla = new DataTable();

			adapter.Fill(tabla);

			return tabla.Rows[0];
		}

	}


}
