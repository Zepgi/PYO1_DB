// CÓDIGO EYDEN SU

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PY1_BD.Modelo {
	internal class Usuarios {
		private SqlConnection bdHotel;
		public Usuarios(SqlConnection pBdHotel) {
			this.bdHotel = pBdHotel;
		}

		public void agregarUsuario(int pIdUsuario, string pNombre, string pFechaNacimiento, string pDireccion, string pEmail, int pNumTell, string pGenero, int pIdRol) {
			int idUsuario = pIdUsuario;
			string nombre = pNombre;
			string fechaNacimiento = pFechaNacimiento;
			string direccion = pDireccion;
			string email = pEmail;
			int numTell = pNumTell;
			string genero = pGenero;
			int idRol = pIdRol;

			bdHotel.Open();
			SqlCommand addCl = new SqlCommand("INSERT INTO Usuario VALUES (@idUsuario, @nombre, @fechaNacimiento, @direccion, @email, @numTell, @genero, @idRol)", bdHotel);

			addCl.Parameters.AddWithValue("@idUsuario", idUsuario);
			addCl.Parameters.AddWithValue("@nombre", nombre);
			addCl.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
			addCl.Parameters.AddWithValue("@direccion", direccion);
			addCl.Parameters.AddWithValue("@email", email);
			addCl.Parameters.AddWithValue("@numTell", numTell);
			addCl.Parameters.AddWithValue("@genero", genero);
			addCl.Parameters.AddWithValue("@idRol", idRol);

			addCl.ExecuteNonQuery();

			bdHotel.Close();
			return;
		}

		public void modificarUsuario(int pIdUsuario, string pNombre, string pFechaNacimiento, string pDireccion, string pEmail, int pNumTell, string pGenero, int pIdRol) {
			int idUsuario = pIdUsuario;
			string nombre = pNombre;
			string fechaNacimiento = pFechaNacimiento;
			string direccion = pDireccion;
			string email = pEmail;
			int numTell = pNumTell;
			string genero = pGenero;
			int idRol = pIdRol;

			bdHotel.Open();

			if (nombre != null || nombre != "") {
				SqlCommand modUser = new SqlCommand("UPDATE Usuario SET nombreCompleto=@nombre WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@nombre", nombre);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			if (fechaNacimiento != null && fechaNacimiento != "") {
				SqlCommand modUser = new SqlCommand("UPDATE Usuario SET fechaNacimiento=@fechaNacimiento WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			if (direccion != null && direccion != "") {
				SqlCommand modUser = new SqlCommand("UPDATE Usuario SET direccionVivienda=@direccion WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@direccion", direccion);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			if (email != null && email != "") {
				SqlCommand modUser = new SqlCommand("UPDATE Usuario SET email=@email WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@email", email);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			if (numTell != -1) {
				SqlCommand modUser = new SqlCommand("UPDATE Usuario SET numTell=@numTell WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@numTell", numTell);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			if (genero != null && genero != "") {
				SqlCommand modUser = new SqlCommand("UPDATE Usuario SET genero=@genero WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@genero", genero);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			if (idRol != -1) {
				SqlCommand modUser = new SqlCommand("UPDATE Usuario SET idRol=@idRol WHERE idUsuario = @idUsuario", bdHotel);
				modUser.Parameters.AddWithValue("@idRol", idRol);
				modUser.Parameters.AddWithValue("@idUsuario", idUsuario);
				modUser.ExecuteNonQuery();
			}
			bdHotel.Close();
			return;
		}
		public void eliminarUsuario(int pIdUsuario) {
			int idUsuario = pIdUsuario;

			bdHotel.Open();

			SqlCommand delCl = new SqlCommand("DELETE FROM Usuario WHERE idUsuario=@idUsuario", bdHotel);
			delCl.Parameters.AddWithValue("@idUsuario", idUsuario);
			delCl.ExecuteNonQuery();

			bdHotel.Close();

			return;
		}

		public DataTable mostrarUsuarios() {
			bdHotel.Open();

			SqlCommand selAll = new SqlCommand("SELECT idUsuario AS 'Cédula', nombreCompleto AS 'Nombre Completo', fechaNacimiento AS 'Fecha de Nacimiento', numTell AS 'Contacto', email AS 'Email', genero AS 'Género', R.nombreRol AS 'Rol' FROM Usuario AS U LEFT JOIN Rol AS R ON U.idRol = R.idRol");
			SqlDataAdapter selAll_DA = new SqlDataAdapter(selAll);
			DataTable usersTable = new DataTable();
			selAll_DA.Fill(usersTable);

			bdHotel.Close();
			return usersTable;
		}

		public string[] buscarUsuario(string pIdUsuario) {
			List<string> usuario = new List<string>();
			bdHotel.Open();
			SqlCommand selUser = new SqlCommand("SELECT idUsuario, nombreCompleto, fechaNacimiento, direccionVivienda, email, numTell, genero, idRol FROM Usuario WHERE idUsuario = @idUsuario", bdHotel);
			selUser.Parameters.AddWithValue("@idUsuario", pIdUsuario);
			SqlDataReader reader = selUser.ExecuteReader();

			if (reader.Read()) {
				usuario.Add(reader["idUsuario"].ToString());
				usuario.Add(reader["nombreCompleto"].ToString());
				usuario.Add(reader["fechaNacimiento"].ToString());
				usuario.Add(reader["direccionVivienda"].ToString());
				usuario.Add(reader["email"].ToString());
				usuario.Add(reader["numTell"].ToString());
				usuario.Add(reader["genero"].ToString());
				usuario.Add(reader["idRol"].ToString());
			} else {
				bdHotel.Close();
				return null;
			}
			bdHotel.Close();

			return usuario.ToArray();
		}

		public List<string> getUsuarios() {
			List<string> usuarios = new List<string>();
			bdHotel.Open();
			SqlCommand selUsr = new SqlCommand("SELECT idUsuario, nombreCompleto FROM Usuario", bdHotel);
			SqlDataReader userReader = selUsr.ExecuteReader();

			while (userReader.Read()) {
				usuarios.Add(userReader["idUsuario"].ToString() + " | " + userReader["nombreCompleto"].ToString());
			}
			bdHotel.Close();
			if (usuarios.Count == 0) {
				return null;
			}
			return usuarios;
		}
	}
}
