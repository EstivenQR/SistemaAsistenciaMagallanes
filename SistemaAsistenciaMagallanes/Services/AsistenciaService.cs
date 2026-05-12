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
		public bool ExisteClase(int idAsignacion, DateTime fecha)
		{
			return dao.ExisteClase(idAsignacion, fecha);
		}


		//Acá empieza lo de hisotorial asistencia
		public DataTable ObtenerSeccionesHistorial(int idUsuario, int idRol)
		{
			return dao.ObtenerSeccionesHistorial(idUsuario, idRol);
		}

		public DataTable ObtenerMateriasHistorial(int idUsuario, int idRol, int idSeccion)
		{
			return dao.ObtenerMateriasHistorial(idUsuario, idRol, idSeccion);
		}

		public DataTable ObtenerListaAsistencia(int idAsignacion, DateTime fecha)
		{
			return dao.ObtenerListaAsistencia(idAsignacion, fecha);
		}

		public void ActualizarDetalleAsistencia(
			int idDetalle,
			string estado,
			string observacion,
			int idUsuario
		)
		{
			dao.ActualizarDetalleAsistencia(
				idDetalle,
				estado,
				observacion,
				idUsuario
			);
		}
	}
}
