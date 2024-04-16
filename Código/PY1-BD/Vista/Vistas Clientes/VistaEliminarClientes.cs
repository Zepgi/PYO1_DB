//CÓDIGO EYDEN SU


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY1_BD.Vista {
	public partial class VistaEliminarClientes : Form {

		VistaOpciones vista;
		public VistaEliminarClientes(VistaOpciones pVista) {
			this.vista = pVista;
			this.vista.Hide();
			this.Show();
			InitializeComponent();
		}

		private void btRegresar_Click(object sender, EventArgs e) {
			this.Hide();
			this.vista.Show();
		}

		private void txtBuscar_Click(object sender, EventArgs e) {
			if(this.txtBuscar.Text == "Ej: 123456789") {
				this.txtBuscar.Text = "";
				this.txtBuscar.ForeColor = Color.Black;
			}
		}

		private void txtBuscar_Leave(object sender, EventArgs e) {
			if(this.txtBuscar.Text == "") {
				this.txtBuscar.Text = "Ej: 123456789";
				this.txtBuscar.ForeColor = Color.Silver;
			}
		}

		public void readOnly() {
			this.txtCedula.ReadOnly = true;
			this.txtNombre.ReadOnly = true;
			this.txtPais.ReadOnly = true;
			this.txtTelefono.ReadOnly = true;
			this.txtEmail.ReadOnly = true;
		}

		public void enWrite() {
			this.txtCedula.ReadOnly = false;
			this.txtNombre.ReadOnly = false;
			this.txtPais.ReadOnly = false;
			this.txtTelefono.ReadOnly = false;
			this.txtEmail.ReadOnly = false;
		}
		public void clearText() {
			this.txtCedula.Text = "";
			this.txtNombre.Text = "";
			this.txtPais.Text = "";
			this.txtTelefono.Text = "";
			this.txtEmail.Text = "";
		}

		public void defaultText() {
			this.txtCedula.Text = "Ej: 123456789";
			this.txtCedula.ForeColor = Color.Silver;
			this.txtNombre.Text = "Ej: Eyden Su Díaz";
			this.txtNombre.ForeColor = Color.Silver;
			this.txtPais.Text = "Ej: Costa Rica";
			this.txtPais.ForeColor = Color.Silver;
			this.txtTelefono.Text = "Ej: 88888888";
			this.txtTelefono.ForeColor = Color.Silver;
			this.txtEmail.Text = "Ej: ejemplo@gmail.com";
			this.txtEmail.ForeColor = Color.Silver;
		}
		public void setText(string[] pText) {
			this.txtCedula.Text = pText[0];
			this.txtNombre.Text = pText[1];
			this.txtPais.Text = pText[2];
			this.txtTelefono.Text = pText[3];
			this.txtEmail.Text = pText[4];
		}
	}
}
