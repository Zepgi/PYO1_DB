using PY1_BD.Vista;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY1_BD.Control
{
	public class Controlador {

        public VistaLogin vista;
		private static readonly SqlConnection bdHotel = new SqlConnection("Data Source=EYDEN;Initial Catalog=HOTELKARPAS;Integrated Security=True");
		public Controlador(VistaLogin pVista) {

            this.vista = pVista;

			this.vista.btIngresar.Click += iniciarSesion;
		}

		private void iniciarSesion(object sender, EventArgs e) {
			if (vista.txtCedula.Text == "" || vista.txtContrasena.Text == "") {
				MessageBox.Show("Credenciales Incompletas. Por favor, Llene todos los espacios");
				return;
			}
			bdHotel.Open();
			SqlCommand login = new SqlCommand("SELECT idCuenta FROM Cuenta WHERE (idUsuario = @idUsuario AND pasword = @password)", bdHotel);
			login.Parameters.AddWithValue("@idUsuario", vista.txtCedula.Text);
			login.Parameters.AddWithValue("@password", vista.txtContrasena.Text);

			try {
				var result = login.ExecuteScalar();
				if (result != null && result != DBNull.Value) {

					vista.Hide();

					SqlCommand rol = new SqlCommand("SELECT idRol FROM Usuario WHERE idUsuario = @idUsuario", bdHotel);
					rol.Parameters.AddWithValue("@idUsuario", vista.txtCedula.Text);
					int numRol = Convert.ToInt32(rol.ExecuteScalar());
					
					if (numRol == 1) {
						VistaAministrador vistaAdmin = new VistaAministrador();
						vistaAdmin.Show();

					} else {
						VistaRecepcionista vistaRecep = new VistaRecepcionista();
						vistaRecep.Show();
					}

				} else {
					MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.");
				}
			} catch (Exception ex) {
				Console.WriteLine("Error: " + ex.Message);
			}
			bdHotel.Close();
		}
	}
}
