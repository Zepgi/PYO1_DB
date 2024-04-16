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
	public partial class VistaAgregarClientes : Form {

		VistaOpciones vista;
		public VistaAgregarClientes(VistaOpciones pVista) {
			this.vista = pVista;
			this.vista.Hide();
			this.Show();
			InitializeComponent();
		}

		private void btRegresar_Click(object sender, EventArgs e) {
			this.Hide();
			this.vista.Show();
		}

		private void txtCedula_Click(object sender, EventArgs e) {
			if(this.txtCedula.Text == "Ej: 123456789") {
				this.txtCedula.Text = "";
				this.txtCedula.ForeColor = Color.Black;
			}
		}

		private void txtCedula_Leave(object sender, EventArgs e) {
			if(this.txtCedula.Text == "") {
				this.txtCedula.Text = "Ej: 123456789";
				this.txtCedula.ForeColor = Color.Silver;
			}
		}

		private void txtNombre_Click(object sender, EventArgs e) {
			if (this.txtNombre.Text == "Ej: Eyden Su Díaz") {
				this.txtNombre.Text = "";
				this.txtNombre.ForeColor = Color.Black;
			}
		}

		private void txtNombre_Leave(object sender, EventArgs e) {
			if (this.txtNombre.Text == "") {
				this.txtNombre.Text = "Ej: Eyden Su Díaz";
				this.txtNombre.ForeColor = Color.Silver;
			}
		}

		private void txtPais_Click(object sender, EventArgs e) {
			if (this.txtPais.Text == "Ej: Costa Rica") {
				this.txtPais.Text = "";
				this.txtPais.ForeColor = Color.Black;
			}
		}

		private void txtPais_Leave(object sender, EventArgs e) {
			if (this.txtPais.Text == "") {
				this.txtPais.Text = "Ej: Costa Rica";
				this.txtPais.ForeColor = Color.Silver;
			}
		}

		private void txtTelefono_Click(object sender, EventArgs e) {
			if (this.txtTelefono.Text == "Ej: 88888888") {
				this.txtTelefono.Text = "";
				this.txtTelefono.ForeColor = Color.Black;
			}
		}

		private void txtTelefono_Leave(object sender, EventArgs e) {
			if (this.txtTelefono.Text == "") {
				this.txtTelefono.Text = "Ej: 88888888";
				this.txtTelefono.ForeColor = Color.Silver;
			}
		}

		private void txtEmail_Click(object sender, EventArgs e) {
			if (this.txtEmail.Text == "Ej: ejemplo@gmail.com") {
				this.txtEmail.Text = "";
				this.txtEmail.ForeColor = Color.Black;
			}
		}

		private void txtEmail_Leave(object sender, EventArgs e) {
			if (this.txtEmail.Text == "") {
				this.txtEmail.Text = "Ej: ejemplo@gmail.com";
				this.txtEmail.ForeColor = Color.Silver;
			}
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
	}
}
