using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistenciaMagallanes.Conexion_BD
{
	public class Configuracion
	{
		public string Servidor { get; set; }
		public string Instancia { get; set; }
		public string BaseDatos { get; set; }
		public bool IntegratedSecurity { get; set; }
	}
}
