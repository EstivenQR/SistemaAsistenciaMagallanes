using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAsistenciaMagallanes.Conexion_BD;

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
