using SistemaAsistenciaMagallanes.DAO;
using SistemaAsistenciaMagallanes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Services
{
	public class MateriaService
	{
		MateriaDAO dao = new MateriaDAO();

		public DataTable ListarMaterias(string buscar)
		{
			return dao.ObtenerMaterias(buscar);
		}

		public void CrearMateria(string nombre)
		{
			dao.InsertarMateria(nombre);
		}

		public void EditarMateria(int id, string nombre)
		{
			dao.ActualizarMateria(id, nombre);
		}

		public void EliminarMateria(int id)
		{
			dao.EliminarMateria(id);
		}
	}
}
