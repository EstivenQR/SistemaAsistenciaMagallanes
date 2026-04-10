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
	public class AsistenciaService
	{
		AsistenciaDAO dao = new AsistenciaDAO();

		public DataTable ObtenerEstudiantesPorSeccion(int idSeccion, int idAsignacion)
		{
			return dao.ObtenerEstudiantesPorSeccion(idSeccion, idAsignacion);
		}

		public void GuardarAsistencia(int idEstudiante, int idSeccion, int idMateria, DateTime fecha, string estado, int idDocente)
		{
			dao.GuardarAsistencia(idEstudiante, idSeccion, idMateria, fecha, estado, idDocente);
		}

		public DataTable ObtenerSeccionesDocente(int idUsuario)
		{
			return dao.ObtenerSeccionesDocente(idUsuario);
		}

		public DataTable ObtenerMateriasDocente(int idUsuario, int idSeccion)
		{
			return dao.ObtenerMateriasDocente(idUsuario, idSeccion);
		}

		public int CrearClase(int idAsignacion, DateTime fecha)
		{
			return dao.CrearClase(idAsignacion, fecha);
		}

		public void GuardarDetalleAsistencia(int idClase, int idEstudiante, string estado)
		{
			dao.GuardarDetalleAsistencia(idClase, idEstudiante, estado);
		}
	}
}
