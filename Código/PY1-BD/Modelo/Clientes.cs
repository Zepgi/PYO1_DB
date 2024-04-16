// CÓDIGO EYDEN SU

using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PY1_BD.Modelo {
    public class Clientes {
        private SqlConnection bdHotel;
        public Clientes(SqlConnection pBdHotel) {
            this.bdHotel = pBdHotel;
        }
        
        public void agregarCliente(int pIdCliente, string pNombre, string pPais, int pTel, string pEmail) {
            int idCliente = pIdCliente;
            string nombre = pNombre;
            string pais = pPais;
            int tel = pTel;
            string email = pEmail;

			bdHotel.Open();
			SqlCommand addCl = new SqlCommand("INSERT INTO Cliente VALUES (@idCliente, @paisProcedencia, @telefono, @correoElectronico, @nombre)", bdHotel);
			
            addCl.Parameters.AddWithValue("@idCliente", idCliente);
			addCl.Parameters.AddWithValue("@paisProcedencia", pais);
			addCl.Parameters.AddWithValue("@telefono", tel);
			addCl.Parameters.AddWithValue("@correoElectronico", email);
			addCl.Parameters.AddWithValue("@nombre", nombre);
			addCl.ExecuteNonQuery();

            bdHotel.Close();
            return;
        }

        public void modificarCliente(int pIdCliente, string pNombre, string pPais, int pTel, string pEmail) {
			int idCliente = pIdCliente;
			string nombre = pNombre;
			string pais = pPais;
			int tel = pTel;
			string email = pEmail;

            bdHotel.Open();

			if (nombre != null && nombre != "") {
				SqlCommand modCl = new SqlCommand("UPDATE Cliente SET nombre=@nombre WHERE idCliente = @idCliente", bdHotel);
				modCl.Parameters.AddWithValue("@nombre", nombre);
				modCl.Parameters.AddWithValue("@idCliente", idCliente);
				modCl.ExecuteNonQuery();
			}
			if (pais != null && pais != "") {
				SqlCommand modCl = new SqlCommand("UPDATE Cliente SET paisProcedencia=@pais WHERE idCliente = @idCliente", bdHotel);
                modCl.Parameters.AddWithValue("@pais", pais );
                modCl.Parameters.AddWithValue("@idCliente", idCliente);
                modCl.ExecuteNonQuery();
			}
			if (tel != -1) {
				SqlCommand modCl = new SqlCommand("UPDATE Cliente SET telefono=@tel WHERE idCliente = @idCliente", bdHotel);
				modCl.Parameters.AddWithValue("@tel", tel);
				modCl.Parameters.AddWithValue("@idCliente", idCliente);
				modCl.ExecuteNonQuery();
			}
            if (email != null && email != "")  {
				SqlCommand modCl = new SqlCommand("UPDATE Cliente SET correoElectronico=@email WHERE idCliente = @idCliente", bdHotel);
				modCl.Parameters.AddWithValue("@email", email);
				modCl.Parameters.AddWithValue("@idCliente", idCliente);
				modCl.ExecuteNonQuery();
			}

			bdHotel.Close();
			return;

		}
        public void eliminarCliente(int pIdCliente) {
			int idCliente = pIdCliente;

			bdHotel.Open();

			SqlCommand delCl = new SqlCommand("DELETE FROM Cliente WHERE idCliente=@idCliente", bdHotel);
			delCl.Parameters.AddWithValue("@idCliente", idCliente);
			delCl.ExecuteNonQuery();

			bdHotel.Close();

			return;
        }

		public DataTable mostrarClientes() {
			bdHotel.Open();

			SqlCommand selCl = new SqlCommand("SELECT idCliente AS 'Cédula', nombre AS 'Nombre Completo', paisProcedencia AS 'País de Origen', telefono AS 'Contacto', correoElectronico AS 'Email' FROM Cliente");
			SqlDataAdapter selClDA = new SqlDataAdapter(selCl);
			DataTable clientTable = new DataTable();
			selClDA.Fill(clientTable);

			bdHotel.Close();
			return clientTable;
		}

		public string[] buscarCliente(string pIdCliente) {
			List<string> cliente = new List<string>();
			bdHotel.Open();
			SqlCommand selCl = new SqlCommand("SELECT idCliente, nombre, paisProcedencia, telefono, correoElectronico FROM Cliente WHERE idCliente = @idCliente", bdHotel);
			selCl.Parameters.AddWithValue("@idCliente", pIdCliente);
			SqlDataReader reader = selCl.ExecuteReader();

			if (reader.Read()) {
				cliente.Add(reader["idCliente"].ToString());
				cliente.Add(reader["nombre"].ToString());
				cliente.Add(reader["paisProcedencia"].ToString());
				cliente.Add(reader["telefono"].ToString());
				cliente.Add(reader["correoElectronico"].ToString());
			} else {
				bdHotel.Close();
				return null;
			}
			bdHotel.Close();

			return cliente.ToArray();
		}

		public List<string> getClientes() {
			List<string> clientes = new List<string>();
			bdHotel.Open();
			SqlCommand selCl = new SqlCommand("SELECT idCliente, nombre FROM Cliente", bdHotel);
			SqlDataReader clientReader = selCl.ExecuteReader();

			while (clientReader.Read()) {
				clientes.Add(clientReader["idCliente"].ToString() + " | " + clientReader["nombre"].ToString());
			}
			bdHotel.Close();
			if (clientes.Count == 0) {
				return null;
			}
			return clientes;
		}
    }
}
