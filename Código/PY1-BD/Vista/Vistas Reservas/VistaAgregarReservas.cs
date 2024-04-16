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
    public partial class VistaAgregarReservas : Form
    {
		public VistaOpciones vista;

		public VistaAgregarReservas(VistaOpciones pVista) {
			InitializeComponent();
			this.vista = pVista;
			this.vista.Hide();

		}

		private void botonVer_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDescuntos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VistaAgregarReservas_Load(object sender, EventArgs e)
        {

        }

        private void labelPrecioTotal_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

		private void botonRegresar_Click(object sender, EventArgs e) {
            this.Dispose();
            this.vista.Show();
		}
	}
}
