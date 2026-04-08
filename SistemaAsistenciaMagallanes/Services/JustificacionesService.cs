using SistemaAsistenciaMagallanes.Conexion_BD;
using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Services
{
	public class JustificacionesService
	{
		private JustificacionesDAO dao = new JustificacionesDAO();
		private AsistenciaDAO asistenciaDAO = new AsistenciaDAO();

		public DataTable GetTodas()
		{
			return dao.ObtenerTodos();
		}
		public void CrearJustificacion(int idEstudiante, DateTime fecha, string motivo, int idUsuario)
		{
			dao.InsertarJustificacion(idEstudiante, fecha, motivo, idUsuario);
		}
		public void MarcarAsistenciaComoJustificada(int idEstudiante, DateTime fecha)
		{
			dao.MarcarComoJustificado(idEstudiante, fecha);
		}
		public void AprobarJustificacion(int id)
		{
			dao.CambiarEstado(id, "Aprobado", Sesion.IdUsuario);
		}

		public void RechazarJustificacion(int id)
		{
			dao.CambiarEstado(id, "Rechazado", Sesion.IdUsuario);
		}
	}
}
