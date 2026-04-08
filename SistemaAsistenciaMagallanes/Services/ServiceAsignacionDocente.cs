using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Services
{
	public class ServiceAsignacionDocente
	{
		AsignacionDocenteDAO dao = new AsignacionDocenteDAO();

		public void CrearAsignacion(int usuario, int seccion, int materia)
		{
			if (dao.ExisteAsignacion(seccion, materia))
			{
				throw new Exception("Esta materia ya tiene un docente asignado");
			}

			dao.InsertarAsignacion(usuario, seccion, materia);
		}

		public DataTable ListarSeccionesPorAnios(List<int> anios)
		{
			return dao.ListarSeccionesPorAnios(anios);
		}



		public DataTable ListarAsignaciones(string buscar)
		{
			AsignacionDocenteDAO dao = new AsignacionDocenteDAO();
			return dao.ObtenerAsignaciones(buscar);
		}

		public void EliminarAsignacion(int idAsignacion)
		{
			AsignacionDocenteDAO dao = new AsignacionDocenteDAO();
			dao.EliminarAsignacion(idAsignacion);
		}

	}
}
