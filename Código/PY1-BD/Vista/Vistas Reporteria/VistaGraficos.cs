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
    public partial class VistaGraficos : Form
    {
        public VistaOpciones vistaOpciones;
        public VistaGraficos(VistaOpciones pVistaOpciones) {
            this.vistaOpciones = pVistaOpciones;
            InitializeComponent();
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            vistaOpciones.Show();
        }

	}
}
