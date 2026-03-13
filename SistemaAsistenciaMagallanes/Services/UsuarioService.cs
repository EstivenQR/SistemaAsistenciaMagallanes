using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAsistenciaMagallanes.Conexion_BD;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaAsistenciaMagallanes.Services
{
	internal class UsuarioService
	{
		public void CrearUsuario(string nombre, string usuario, string password, int rol, int estado)
		{
			UsuarioDAO dao = new UsuarioDAO();
			string passwordEncriptado = Seguridad.Encriptar(password);
			dao.InsertarUsuario(nombre, usuario, passwordEncriptado, rol, estado);
		}


		public DataTable ListarUsuarios(string buscar, bool mostrarInactivos)
		{
			UsuarioDAO dao = new UsuarioDAO();
			return dao.ObtenerUsuarios(buscar, mostrarInactivos);
		}

		public bool Login(string usuario, string password)
		{
			UsuarioDAO dao = new UsuarioDAO();

			string hash = Seguridad.Encriptar(password);

			SqlDataReader reader = dao.Login(usuario, hash);

			if (reader.Read())
			{
				Sesion.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
				Sesion.Nombre = reader["Nombre"].ToString();
				Sesion.IdRol = Convert.ToInt32(reader["IdRol"]);

				return true;
			}

			return false;
		}

		public DataRow ObtenerUsuarioPorId(int id)
		{
			UsuarioDAO dao = new UsuarioDAO();
			return dao.ObtenerUsuarioPorId(id);
		}

		public void ActualizarUsuario(int idUsuario, string nombre, string usuario, int rol, int estado)
		{
			UsuarioDAO dao = new UsuarioDAO();
			dao.ActualizarUsuario(idUsuario, nombre, usuario, rol, estado);
		}
	}
}
