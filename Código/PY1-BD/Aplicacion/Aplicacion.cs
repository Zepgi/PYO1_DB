using PY1_BD.Control;
using PY1_BD.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY1_BD.Aplicacion {
	internal static class Aplicacion {
		
		
		static void Main() {
			VistaLogin vistaHotel = new VistaLogin();
			Controlador controlador = new Controlador(vistaHotel);
			controlador.vistaLogin.Show();
			Application.Run(vistaHotel);
		}
		
	}
}
