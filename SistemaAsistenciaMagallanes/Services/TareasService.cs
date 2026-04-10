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
	public class TareasService
	{
		private TareasDAO dao = new TareasDAO();

		public DataTable ObtenerSecciones(int IdUsuario)
		{
			return dao.ObtenerSeccionesDocente(IdUsuario);
		}

		public DataTable ObtenerMaterias(int IdUsuario, int idSeccion)
		{
			return dao.ObtenerMateriasDocente(IdUsuario, idSeccion);
		}

		public DataTable ObtenerTareas(int idDocente, int idSeccion, int idMateria)
		{
			return dao.ObtenerTareas(idDocente, idSeccion, idMateria);
		}

		public DataTable ObtenerEstudiantes(int idSeccion)
		{
			return dao.ObtenerEstudiantesPorSeccion(idSeccion);
		}

		public void CrearTarea(int idDocente, int idSeccion, int idMateria, string titulo, string descripcion, DateTime fechaEntrega)
		{
			if (idSeccion == 0 || idMateria == 0)
				throw new Exception("Sección o materia inválida");

			if (string.IsNullOrWhiteSpace(titulo))
				throw new Exception("El título es obligatorio");

			dao.CrearTarea(idDocente, idSeccion, idMateria, titulo, descripcion, fechaEntrega);
		}

		public void EliminarTarea(int idTarea)
		{
			TareasDAO dao = new TareasDAO();
			dao.EliminarTarea(idTarea);
		}

		public void ActualizarTarea(int idTarea, int idSeccion, int idMateria, string titulo, string descripcion, DateTime fechaEntrega)
		{
			TareasDAO dao = new TareasDAO();
			dao.ActualizarTarea(idTarea, idSeccion, idMateria, titulo, descripcion, fechaEntrega);
		}

		public DataRow ObtenerTareaPorId(int idTarea)
		{
			TareasDAO dao = new TareasDAO();
			return dao.ObtenerTareaPorId(idTarea);
		}

		public void GuardarEntrega(int idTarea, int idEstudiante, bool entregado, decimal porcentaje, int idDocente)
		{
			TareasDAO dao = new TareasDAO();
			dao.GuardarEntrega(idTarea, idEstudiante, entregado, porcentaje, idDocente);
		}

		public DataTable ObtenerTareasHoy(int idDocente)
		{
			TareasDAO dao = new TareasDAO();
			return dao.ObtenerTareasHoy(idDocente);
		}
		public void FinalizarTarea(int idTarea)
		{
			dao.FinalizarTarea(idTarea);
		}

	}
}
