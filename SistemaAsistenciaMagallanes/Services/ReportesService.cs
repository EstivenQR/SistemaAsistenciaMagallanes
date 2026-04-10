using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAsistenciaMagallanes.Services
{
	public class ReportesService
	{

		ReportesDAO dao = new ReportesDAO();
		public DataTable ObtenerReporte(int? idEstudiante, int? idSeccion, int? idMateria, DateTime? desde, DateTime? hasta)
		{
			return dao.ObtenerReporte(idEstudiante, idSeccion, idMateria, desde, hasta);
		}
		public DataTable ObtenerSecciones(int idUsuario)
		{
			return dao.ObtenerSecciones(idUsuario);
		}

		public DataTable ObtenerMaterias(int idUsuario, int idSeccion)
		{
			return dao.ObtenerMaterias(idUsuario, idSeccion);
		}

		public DataTable ObtenerEstudiantes(int idSeccion)
		{
			return dao.ObtenerEstudiantes(idSeccion);
		}

		public DataTable FiltrarReportes(int? idSeccion, int? idMateria, int? idEstudiante)
		{
			return dao.FiltrarReportes(idSeccion, idMateria, idEstudiante);
		}

		public DataTable ObtenerReporteTareas(int? idSeccion, int? idMateria, DateTime? desde, DateTime? hasta, int idDocente)
		{
			return dao.ObtenerReporteTareas(idSeccion, idMateria, desde, hasta, idDocente);
		}

		public DataTable ObtenerReporteTareas(int? idSeccion, int? idMateria, int? idEstudiante)
		{
			return dao.ObtenerReporteTareasPDF(idSeccion, idMateria, idEstudiante);
		}
	}
}
