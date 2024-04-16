using PY1_BD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY1_BD.Vista {

    public partial class VistaReporteria : Form {
        public VistaOpciones vistaOpciones;
        
       
        public VistaReporteria( VistaOpciones pVistaOpciones) {
            this.vistaOpciones = pVistaOpciones;
            InitializeComponent();
        }

        private void VistaReporteria_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            vistaOpciones.Show();
        }
    }

      
    
}
