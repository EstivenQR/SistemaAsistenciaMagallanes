using SistemaAsistenciaMagallanes.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Services
{
	public class EstudiantesService
	{
		public DataTable ListarEstudiantes(string buscar, bool? estado)
		{
			EstudiantesDAO dao = new EstudiantesDAO();

			return dao.ObtenerEstudiantes(buscar, estado);
		}
		public void InsertarEstudiante(string cedula, string nombre, string apellido,
										DateTime fechaNacimiento, string numeroEncargado, int idSeccion, int RecibeReligion)
		{
			EstudiantesDAO dao = new EstudiantesDAO();
			
			if (cedula == "")
			{
				throw new Exception("La cédula es obligatoria");
			}

			dao.InsertarEstudiante(cedula, nombre, apellido, fechaNacimiento, numeroEncargado, idSeccion, RecibeReligion);
		}
		public void EditarEstudiante(int id, string cedula, string nombre, string apellido,
									DateTime fechaNacimiento, string numeroEncargado, int idSeccion, bool estado, int RecibeReligion)
		{
			EstudiantesDAO dao = new EstudiantesDAO();

			dao.EditarEstudiante(id, cedula, nombre, apellido, fechaNacimiento, numeroEncargado, idSeccion, estado, RecibeReligion);
		}


	}
}
