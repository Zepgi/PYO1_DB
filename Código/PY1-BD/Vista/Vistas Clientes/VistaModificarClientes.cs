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
	public partial class VistaModificarClientes : Form {

		bool esAdmin;
		VistaOpciones vista;
		public VistaModificarClientes(VistaOpciones pVista, bool pEsAdmin) {
			this.vista = pVista;
			this.esAdmin = pEsAdmin;
			this.vista.Hide();
			this.Show();
			InitializeComponent();
		}

		private void btRegresar_Click(object sender, EventArgs e) {
			this.Hide();
			this.vista.Show();
		}

		private void txtCedula_Click(object sender, EventArgs e) {
			if(this.txtCedula.Text == "Ej: 123456789" && !this.txtCedula.ReadOnly ) {
				this.txtCedula.Text = "";
				this.txtCedula.ForeColor = Color.Black;
			}
		}

		private void txtCedula_Leave(object sender, EventArgs e) {
			if(this.txtCedula.Text == "" && !this.txtCedula.ReadOnly) {
				this.txtCedula.Text = "Ej: 123456789";
				this.txtCedula.ForeColor = Color.Silver;
			}
		}

		private void txtNombre_Click(object sender, EventArgs e) {
			if (this.txtNombre.Text == "Ej: Eyden Su Díaz" && !this.txtNombre.ReadOnly) {
				this.txtNombre.Text = "";
				this.txtNombre.ForeColor = Color.Black;
			}
		}

		private void txtNombre_Leave(object sender, EventArgs e) {
			if (this.txtNombre.Text == "" && !this.txtNombre.ReadOnly) {
				this.txtNombre.Text = "Ej: Eyden Su Díaz";
				this.txtNombre.ForeColor = Color.Silver;
			}
		}

		private void txtPais_Click(object sender, EventArgs e) {
			if (this.txtPais.Text == "Ej: Costa Rica" && !this.txtPais.ReadOnly) {
				this.txtPais.Text = "";
				this.txtPais.ForeColor = Color.Black;
			}
		}

		private void txtPais_Leave(object sender, EventArgs e) {
			if (this.txtPais.Text == "" && !this.txtPais.ReadOnly) {
				this.txtPais.Text = "Ej: Costa Rica";
				this.txtPais.ForeColor = Color.Silver;
			}
		}

		private void txtTelefono_Click(object sender, EventArgs e) {
			if (txtTelefono.Text == "Ej: 88888888" && !this.txtTelefono.ReadOnly) {
				txtTelefono.Text = "";
				txtTelefono.ForeColor = Color.Black;
			}
		}

		private void txtTelefono_Leave(object sender, EventArgs e) {
			if (this.txtTelefono.Text == "" && !this.txtTelefono.ReadOnly) {
				this.txtTelefono.Text = "Ej: 88888888";
				this.txtTelefono.ForeColor = Color.Silver;
			}
		}

		private void txtEmail_Click(object sender, EventArgs e) {
			if (this.txtEmail.Text == "Ej: ejemplo@gmail.com" && !this.txtEmail.ReadOnly) {
				this.txtEmail.Text = "";
				this.txtEmail.ForeColor = Color.Black;
			}
		}

		private void txtEmail_Leave(object sender, EventArgs e) {
			if (this.txtEmail.Text == "" && !this.txtEmail.ReadOnly) {
				this.txtEmail.Text = "Ej: ejemplo@gmail.com";
				this.txtEmail.ForeColor = Color.Silver;
			}
		}

		private void txtBuscar_Click(object sender, EventArgs e) {
			if (this.txtBuscar.Text == "Ej: 123456789") {
				this.txtBuscar.Text = "";
				this.txtBuscar.ForeColor = Color.Black;
			}
		}

		private void txtBuscar_Leave(object sender, EventArgs e) {
			if (this.txtBuscar.Text == "") {
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
