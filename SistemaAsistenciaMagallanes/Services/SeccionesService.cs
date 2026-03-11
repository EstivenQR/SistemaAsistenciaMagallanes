using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Services
{
	public class SeccionesService
	{
		SeccionesDAO dao = new SeccionesDAO();

		public DataTable ListarSecciones(string buscar)
		{
			return dao.ObtenerSecciones(buscar);
		}

		public void CrearSeccion(string nombre, int anio)
		{
			dao.InsertarSeccion(nombre, anio);
		}

		public void EliminarSeccion( int id)
		{
			dao.EliminarSeccion(id);
		}
	}
}
