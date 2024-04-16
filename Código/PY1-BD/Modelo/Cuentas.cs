// CÓDIGO EYDEN SU

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PY1_BD.Modelo {
	internal class Cuentas {
		private SqlConnection bdHotel;
		public Cuentas(SqlConnection pBdHotel) {
			this.bdHotel = pBdHotel;
		}

		public void agregarCuenta(int pIdUsuario, string pContrasena) {
			int idUsuario = pIdUsuario;
			string contrasena = pContrasena;
			int idCuenta = 0;
			bdHotel.Open();
			SqlCommand cmd = new SqlCommand("SELECT MAX(idCuenta) FROM Cuenta", bdHotel);
			if (cmd.ExecuteScalar() != DBNull.Value) {
				idCuenta = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
			}
			bdHotel.Close();

			bdHotel.Open();
			SqlCommand addCuenta = new SqlCommand("INSERT INTO Cuenta VALUES (@idUsuario, @idCuenta, @pasword)", bdHotel);
			addCuenta.Parameters.AddWithValue("@idUsuario", idUsuario);
			addCuenta.Parameters.AddWithValue("@idCuenta", idCuenta);
			addCuenta.Parameters.AddWithValue("@pasword", contrasena);
			addCuenta.ExecuteNonQuery();
			bdHotel.Close();
		}

		public void modificarCuenta(int pIdUsuario, string pContrasena) {
			int idUsuario = pIdUsuario;
			string contrasena = pContrasena;
			bdHotel.Open();

			if (contrasena != null || contrasena != "") {
				SqlCommand modUser = new SqlCommand("UPDATE Cuenta SET pasword=@password WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@password", contrasena);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			bdHotel.Close();
			return;
		}

		public void eliminarCuenta(string pIdUsuario) {
			string idUsuario = pIdUsuario;
			bdHotel.Open();
			SqlCommand delCuenta = new SqlCommand("DELETE FROM Cuenta WHERE idUsuario = @idUsuario", bdHotel);
			delCuenta.Parameters.AddWithValue("@idUsuario", idUsuario);
			delCuenta.ExecuteNonQuery();
			bdHotel.Close();
		}

		public string[] buscarCuenta(string pIdUsuario) {
			string idUsuario = pIdUsuario;
			bdHotel.Open();
			SqlCommand selCuenta = new SqlCommand("SELECT idUsuario, idCuenta, pasword FROM Cuenta WHERE idUsuario = @idUsuario", bdHotel);
			selCuenta.Parameters.AddWithValue("@idUsuario", idUsuario);
			SqlDataReader reader = selCuenta.ExecuteReader();
			string[] cuentaInfo = new string[3]; 

			if (reader.Read()) {
				cuentaInfo[0] = reader["idUsuario"].ToString();
				cuentaInfo[1] = reader["idCuenta"].ToString();
				cuentaInfo[2] = reader["pasword"].ToString();
			} else {
				cuentaInfo = null;
			}
			bdHotel.Close();

			return cuentaInfo;
		}

		public bool validarLogin(string idUsuario, string contrasena) {
			SqlCommand login = new SqlCommand("SELECT idCuenta FROM Cuenta WHERE idUsuario = @idUsuario AND pasword = @password", bdHotel);
			login.Parameters.AddWithValue("@idUsuario", idUsuario);
			login.Parameters.AddWithValue("@password", contrasena);

			try {
				bdHotel.Open();
				var result = login.ExecuteScalar();
				bdHotel.Close();

				return (result != null && result != DBNull.Value);
			} catch {
				bdHotel.Close();
				return false;
			}
		}
	}
}
