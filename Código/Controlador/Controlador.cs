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

			bdHotel.Open();
			SqlCommand login = new SqlCommand("SELECT idCuenta FROM Cuenta WHERE (idUsuario = @idUsuario AND pasword = @password)", bdHotel);
			login.Parameters.AddWithValue("@idUsuario", vista.txtCedula.Text);
			login.Parameters.AddWithValue("@password", vista.txtContrasena.Text);

			try {
				var result = login.ExecuteScalar();
				if (result != null && result != DBNull.Value) {
					vista.Hide();
					VistaAministrador vistaAdmin = new VistaAministrador();
					vistaAdmin.Show();
					Application.Run(vistaAdmin);

				} else {
					MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.");
				}
			} catch (Exception) {
				MessageBox.Show("Llene todos los espacios");
			}
			bdHotel.Close();
		}
	}
}
