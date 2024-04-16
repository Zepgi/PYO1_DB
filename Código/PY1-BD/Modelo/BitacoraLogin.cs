//CÓDIGO EYDEN SU

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY1_BD.Modelo {
	internal class BitacoraLogin {

		SqlConnection bdHotel;


		public BitacoraLogin(SqlConnection pBdHotel) { 
			this.bdHotel = pBdHotel;
		}

		public void addLogin(string pIdCuenta, DateTime pFecha) {
			bdHotel.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO BitacoraLogin VALUES (@fechaLogin, @idCuenta)", bdHotel);
			cmd.Parameters.AddWithValue("@idCuenta", pIdCuenta);
			cmd.Parameters.AddWithValue("@fechaLogin", pFecha);
			cmd.ExecuteNonQuery();
			bdHotel.Close();
		}

		public void deleteLogins(string pIdCuenta) {
			bdHotel.Open();
			SqlCommand cmd = new SqlCommand("DELETE FROM BitacoraLogin WHERE @idCuenta = idCuenta", bdHotel);
			cmd.Parameters.AddWithValue("@idCuenta", pIdCuenta);
			cmd.ExecuteNonQuery();
			bdHotel.Close();
		}
	}
}
