using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Services
{
	public class BoletasService
	{
		BoletasDAO dao = new BoletasDAO();

		public void GuardarBoleta(int idEstudiante, DateTime fecha, string motivo, int porcentaje, int idUsuario)
		{
			dao.InsertarBoleta(idEstudiante, fecha, motivo, porcentaje, idUsuario);
		}

		public DataTable ListarBoletas(int idUsuario, int idRol)
		{
			return dao.ObtenerBoletas(idUsuario, idRol);
		}

		public DataTable ObtenerEstudiantes(int idUsuario, int rol)
		{
			return dao.ObtenerEstudiantesPorRol(idUsuario, rol);
		}
		public DataTable ObtenerSecciones(int idUsuario, int idRol)
		{
			return dao.ObtenerSeccionesPorRol(idUsuario, idRol);
		}

		public DataTable ObtenerEstudiantesPorSeccion(int idSeccion)
		{
			return dao.ObtenerEstudiantesPorSeccion(idSeccion);
		}

		public void EliminarBoleta(int idBoleta)
		{
			dao.EliminarBoleta(idBoleta);
		}

		public void ActualizarBoleta(int idBoleta, int idEstudiante, DateTime fecha, string motivo, int porcentaje)
		{
			dao.ActualizarBoleta(idBoleta, idEstudiante, fecha, motivo, porcentaje);
		}

		public DataRow ObtenerBoletaPorId(int idBoleta)
		{
			return dao.ObtenerBoletaPorId(idBoleta);
		}

		public DataTable ObtenerBoletasReporte(int? idSeccion, int? idEstudiante, DateTime? inicio, DateTime? fin)
		{
			return dao.ObtenerBoletasReporte(idSeccion, idEstudiante, inicio, fin);
		}

	}
}
