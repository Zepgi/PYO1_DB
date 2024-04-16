// CÓDIGO EYDEN SU

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PY1_BD.Modelo {
	internal class Roles {
		private SqlConnection bdHotel;
		public Roles(SqlConnection pBdHotel) {
			this.bdHotel = pBdHotel;
		}

		public List<string> getRoles() {
			List<string> roles = new List<string>();
			bdHotel.Open();
			SqlCommand selCl = new SqlCommand("SELECT idRol, nombreRol FROM Rol", bdHotel);
			SqlDataReader rolesReader = selCl.ExecuteReader();

			while (rolesReader.Read()) {
				roles.Add(rolesReader["nombreRol"].ToString());
			}
			bdHotel.Close();
			if (roles.Count == 0) {
				return null;
			}
			return roles;
		}

		public int buscarIdRol(string pNombre) {
			int idRol = -1;
			bdHotel.Open();
			SqlCommand selRol = new SqlCommand("SELECT idRol FROM Rol WHERE nombreRol = @nombreRol", bdHotel);
			selRol.Parameters.AddWithValue("@nombreRol", pNombre);
			object result = selRol.ExecuteScalar();

			if (result != null && result != DBNull.Value) {
				idRol = Convert.ToInt32(result);
			}
			bdHotel.Close();

			return idRol;
		}

		public string buscarNombreRol(int idRol) {
			string nombreRol = "";
			bdHotel.Open();
			SqlCommand selRol = new SqlCommand("SELECT nombreRol FROM Rol WHERE idRol = @idRol", bdHotel);
			selRol.Parameters.AddWithValue("@idRol", idRol);
			object result = selRol.ExecuteScalar();

			if (result != null && result != DBNull.Value) {
				nombreRol = result.ToString();
			}
			bdHotel.Close();

			return nombreRol;
		}

		public bool esAdmin(string pIdUsuario) {
			bool isAdmin = false;
			bdHotel.Open();
			SqlCommand cmd = new SqlCommand("SELECT idRol FROM Usuario WHERE idUsuario = @idUsuario", bdHotel);
			cmd.Parameters.AddWithValue("@idUsuario", pIdUsuario);
			object result = cmd.ExecuteScalar();
			bdHotel.Close();

			if (result != null && result != DBNull.Value) {
				int idRol = Convert.ToInt32(result);
				if (idRol == 1) {
					isAdmin = true;
				}
			}

			return isAdmin;
		}
	}
}
