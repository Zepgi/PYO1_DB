using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY1_BD.Vista
{
    public partial class VistaBorrarReservas : Form
    {
		VistaOpciones vista;

        public VistaBorrarReservas(VistaOpciones pVista)
        {
            this.vista = pVista;
            this.vista.Hide();
            InitializeComponent();
        }

        private void VistaAjustesReserva_Load(object sender, EventArgs e)
        {

        }

		private void botonRegresar_Click(object sender, EventArgs e) {
			this.Dispose();
			this.vista.Show();
		}
	}
}
