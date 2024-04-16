//CÓDIGO EYDEN SU

using PY1_BD.Modelo;
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
	public partial class VistaModificarPersonal : Form {

		VistaOpciones vista;
		bool propioUsuario;
		public VistaModificarPersonal(VistaOpciones pVista) {
			this.vista = pVista;
			this.propioUsuario = false;
			this.vista.Hide();
			this.Show();
			InitializeComponent();
		}

		private void btRegresar_Click(object sender, EventArgs e) {
			this.Hide();
			this.vista.Show();
		}

		public void esPropioUsuario() {
			this.propioUsuario = true;
		}
		private void txtCedula_Click(object sender, EventArgs e) {
			if(this.txtCedula.Text == "Ej: 123456789") {
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
			if (this.txtNombre.Text == "Ej: Eyden Su Díaz") {
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

		private void txtTelefono_Click(object sender, EventArgs e) {
			if (this.txtTelefono.Text == "Ej: 88888888") {
				this.txtTelefono.Text = "";
				this.txtTelefono.ForeColor = Color.Black;
			}
		}

		private void txtTelefono_Leave(object sender, EventArgs e) {
			if (this.txtTelefono.Text == "" && !this.txtTelefono.ReadOnly) {
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
			if (this.txtEmail.Text == "" && !this.txtEmail.ReadOnly) {
				this.txtEmail.Text = "Ej: ejemplo@gmail.com";
				this.txtEmail.ForeColor = Color.Silver;
			}
		}

		private void txtAddress_Click(object sender, EventArgs e) {
			if (this.txtAddress.Text == "Ej: Colina") {
				this.txtAddress.Text = "";
				this.txtAddress.ForeColor = Color.Black;
			}
		}

		private void txtAddress_Leave(object sender, EventArgs e) {
			if (this.txtAddress.Text == "" && !this.txtAddress.ReadOnly) {
				this.txtAddress.Text = "Ej: Colina";
				this.txtAddress.ForeColor = Color.Silver;
			}
		}

		private void txtPassword_Click(object sender, EventArgs e) {
			if (this.txtPassword.Text == "Ingrese una contraseña") {
				this.txtPassword.Text = "";
				this.txtPassword.ForeColor = Color.Black;
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e) {
			if (this.txtPassword.Text == "" && !this.txtPassword.ReadOnly) {
				this.txtPassword.Text = "Ingrese una contraseña";
				this.txtPassword.ForeColor = Color.Silver;
			}
		}

		private void cbRol_Click(object sender, EventArgs e) {
			if (this.cbRol.Text == "Seleccione un rol" && this.cbRol.Enabled) {
				this.cbRol.Text = "";
				this.cbRol.ForeColor = Color.Black;
			}
		}

		private void cbRol_Leave(object sender, EventArgs e) {
			if (this.cbRol.Text == "" && this.cbRol.Enabled) {
				this.cbRol.Text = "Seleccione un rol";
				this.cbRol.ForeColor = Color.Silver;
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
		public void clearText() {
			this.txtCedula.Text = "";
			this.txtNombre.Text = "";
			this.txtAddress.Text = "";
			this.txtTelefono.Text = "";
			this.txtEmail.Text = "";
			this.txtPassword.Text = "";
			this.cbRol.SelectedIndex = -1;
			this.dtpBornDate.Value = DateTime.Now;
		}

		public void defaultValues() {
			this.txtCedula.Text = "Ej: 123456789";
			this.txtCedula.ForeColor = Color.Silver;
			this.txtNombre.Text = "Ej: Eyden Su Díaz";
			this.txtNombre.ForeColor = Color.Silver;
			this.txtAddress.Text = "Ej: Colina";
			this.txtAddress.ForeColor = Color.Silver;
			this.txtTelefono.Text = "Ej: 88888888";
			this.txtTelefono.ForeColor = Color.Silver;
			this.txtEmail.Text = "Ej: ejemplo@gmail.com";
			this.txtEmail.ForeColor = Color.Silver;
			this.txtPassword.Text = "Ingrese una contraseña";
			this.txtPassword.ForeColor = Color.Silver;
			this.dtpBornDate.Value = DateTime.Now;
			this.cbRol.Text = "Seleccione un rol";
			this.cbRol.ForeColor = Color.Silver;
			this.rbFem.Checked = false;
			this.rbMas.Checked = false;
		}

		public bool esGeneroSeleccionado() {
			return this.rbFem.Checked || this.rbMas.Checked; 
		}

		public void readOnly() {
			this.txtCedula.ReadOnly = true;
			this.txtNombre.ReadOnly = true;
			this.dtpBornDate.Enabled = false;
			this.txtAddress.ReadOnly = true;
			this.rbFem.Enabled = false;
			this.rbMas.Enabled = false;
			this.txtTelefono.ReadOnly = true;
			this.txtEmail.ReadOnly = true;
			this.cbRol.Enabled = false;
			this.txtPassword.ReadOnly = true;
		}

		public void setText(string[] pUsuario,string nombreRol, string pContrasena) {
			this.txtCedula.Text = pUsuario[0];
			this.txtNombre.Text = pUsuario[1];
			this.dtpBornDate.Value = DateTime.ParseExact(pUsuario[2], "d/M/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture).Date;
			this.txtAddress.Text = pUsuario[3];
			this.txtEmail.Text = pUsuario[4];
			this.txtTelefono.Text = pUsuario[5];
			this.rbMas.Checked = pUsuario[6] == "M";
			this.rbFem.Checked = pUsuario[6] == "F";
			this.cbRol.Text = nombreRol;
			this.txtPassword.Text = pContrasena;
		}

		public void enWrite() {
			this.txtNombre.ReadOnly = false;
			this.dtpBornDate.Enabled = true;
			this.txtAddress.ReadOnly = false;
			this.rbFem.Enabled = true;
			this.rbMas.Enabled = true;
			this.txtTelefono.ReadOnly = false;
			this.txtEmail.ReadOnly = false;
			if (!this.propioUsuario) {
				this.cbRol.Enabled = true;
			}
			this.txtPassword.ReadOnly = false;
		}
	}
}
