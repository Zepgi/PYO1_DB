using PY1_BD.Vista;
using PY1_BD.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Drawing.Text;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace PY1_BD.Control {

	/* Clase Controlador:

		Atributos:
			- SqlConnection bdHotel: Conexión a la base de datos HOTELKARPAS.
			- DateTime fechaCheckOut: Fecha de salida de una reserva.
			- DateTime fechaCheckIn: Fecha de entrada de una reserva.
			- DateTime fechaCheckInEstadoReserva: Fecha de entrada de la reserva en el estado actual.

		Vistas:
			- VistaLogin vistaLogin: Vista para iniciar sesión.
			- VistaOpciones vistaOpciones: Vista de opciones después de iniciar sesión.
			- VistaAgregarClientes vwAddClient: Vista para agregar clientes.
			- VistaModificarClientes vwModClient: Vista para modificar clientes.
			- VistaEliminarClientes vwDelClient: Vista para eliminar clientes.
			- VistaAgregarPersonal vwAddWorker: Vista para agregar personal.
			- VistaModificarPersonal vwModWorker: Vista para modificar personal.
			- VistaEliminarPersonal vwDelWorker: Vista para eliminar personal.
			- VistaAgregarReservas reservas: Vista para agregar reservas.
			- VistaBorrarReservas ajustes: Vista para ajustes de reservas.
			- VistaEstadoReserva estadoReserva: Vista para el estado de una reserva.
			- VistaReporteria reporteria: Vista para generar reportes. */
	public class Controlador {

		private static readonly SqlConnection bdHotel = new SqlConnection("Data Source=EYDEN;Initial Catalog=HOTELKARPAS;Integrated Security=True");

		public DateTime fechaCheckOut;
		public DateTime fechaCheckIn;
		public DateTime fechaCheckInEstadoReserva;

		/////// VISTAS ////////

		public VistaLogin             vistaLogin;
		public VistaOpciones          vistaOpciones;

		public VistaAgregarClientes   vwAddClient;
		public VistaModificarClientes vwModClient;
		public VistaEliminarClientes  vwDelClient;

		public VistaAgregarPersonal   vwAddWorker;
		public VistaModificarPersonal vwModWorker;
		public VistaEliminarPersonal  vwDelWorker;

		public VistaAgregarReservas reservas;
		public VistaBorrarReservas ajustes;
		public VistaEstadoReserva estadoReserva;

		public VistaReporteria reporteria;
		public VistaGraficos graficos;



		//************************************************************************//
		////////////////////////////////////////////////////////////////////////////
		////////                      CÓDIGO EYDEN SU                       ////////

		/*
		 * Método Controlador:
		 *
		 *	Descripción:
		 *	Constructor de la clase Controlador que inicializa una instancia 
		 *	de Controlador con la vista de inicio de sesión especificada.
		 *
		 *	Entradas:
		 *	- VistaLogin pVista: La vista de inicio de sesión que se utilizará.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- pVista: Instancia de la clase VistaLogin que se utilizará como 
		 *			  vista de inicio de sesión.
		 *
		 */
		public Controlador(VistaLogin pVista) {
			this.vistaLogin = pVista;
			this.vistaOpciones = null;
			this.vwModClient = null;
			this.vwDelClient = null;
			this.vwAddClient = null;
			this.vistaLogin.btIngresar.Click += iniciarSesion;
			this.vistaLogin.txtContrasena.KeyPress += txtContrasena_Listener;
		}

		/*
		 * Método iniciarSesion:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de inicio de 
		 *	sesión en la vista. Verifica las credenciales ingresadas y muestra 
		 *	la vista de opciones si las credenciales son válidas.
		 *
		 *	Entradas:
		 *	- object sender: El objeto que activó el evento.
		 *	- EventArgs e: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	Ninguno.
		 */
		private void iniciarSesion(object sender, EventArgs e) {
			if (this.vistaLogin.txtCedula.Text == "" || this.vistaLogin.txtContrasena.Text == "") {
				MessageBox.Show("Credenciales Incompletas. Por favor, Llene todos los espacios");
				return;
			}

			string idUsuario   = this.vistaLogin.txtCedula.Text;
			string contrasena  = this.vistaLogin.txtContrasena.Text;

			Cuentas accountManager = new Cuentas(bdHotel);

			if (accountManager.validarLogin(idUsuario, contrasena)) {
				this.vistaLogin.Hide();
				BitacoraLogin loginManager = new BitacoraLogin(bdHotel);
				Roles rolesManager = new Roles(bdHotel);

				if (rolesManager.esAdmin(idUsuario)) {
					loginManager.addLogin(this.vistaLogin.txtCedula.Text, DateTime.Now);
					this.vistaOpciones = new VistaOpciones(true, Convert.ToInt32(this.vistaLogin.txtCedula.Text));
					this.vistaOpciones.Show();

				} else {
					this.vistaOpciones = new VistaOpciones(false, Convert.ToInt32(this.vistaLogin.txtCedula.Text));
					this.vistaOpciones.btPersonal.Enabled = false;
					this.vistaOpciones.Show();
				}

				menuOpciones(this.vistaLogin.txtCedula.Text);

			} else {
				MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.");
				this.vistaLogin.txtCedula.Text = "";
				this.vistaLogin.txtContrasena.Text = "";
			}
		}

		/*
		 * Método cerrarVentana:
		 *
		 *	Descripción:
		 *	Método para cerrar la ventana de inicio de sesión.
		 *
		 *	Entradas:
		 *	- object sender: El objeto que activó el evento.
		 *	- EventArgs e: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	Ninguno.
		 */
		private void cerrarVentana(object sender, EventArgs e) {
			this.vistaLogin.Close();
		}

		/*
		 * Método cerrarSesion:
		 *
		 *	Descripción:
		 *	Método para cerrar la sesión actual y mostrar la ventana de inicio de 
		 *	sesión.
		 *
		 *	Entradas:
		 *	- object sender: El objeto que activó el evento.
		 *	- EventArgs e: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	Ninguno.
		 */
		public void cerrarSesion(object sender, EventArgs e) {
			this.vistaLogin.Show();
			this.vistaLogin.txtCedula.Text = "";
			this.vistaLogin.txtContrasena.Text = "";
			this.vistaOpciones.Dispose();
		}

		/*
		 * Método menuOpciones:
		 *
		 *	Descripción:
		 *	Método para configurar las opciones de menú después de iniciar sesión.
		 *
		 *	Entradas:
		 *	- string pIdUsuario: El identificador del usuario que ha iniciado sesión.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- pIdUsuario: Identificador del usuario que ha iniciado sesión.
		 */
		public void menuOpciones(string pIdUsuario) {
			string idUsuario = pIdUsuario;

			this.vistaOpciones.FormClosed += cerrarVentana;

			bdHotel.Open();
			SqlCommand findUser = new SqlCommand("SELECT nombreCompleto FROM Usuario WHERE idUsuario = @idUsuario", bdHotel);
			findUser.Parameters.AddWithValue("@idUsuario", idUsuario);
			var name = findUser.ExecuteScalar();
			bdHotel.Close();

			this.vistaOpciones.lbWelcome.Text = "Bienvenido, " + name + ".";
			this.vistaOpciones.btClientes.Click += btClientes_Click;
			this.vistaOpciones.btReservas.Click += btReservas_Click;
			this.vistaOpciones.btReportes.Click += btReportes_Click;
			this.vistaOpciones.btPersonal.Click += btPersonal_Click;
			this.vistaOpciones.btLogout.Click += cerrarSesion;

			this.vistaOpciones.btAdd.Click += btAddSolveCall;
			this.vistaOpciones.btMod.Click += btModSolveCall;
			this.vistaOpciones.btDel.Click += btDelsolveCall;
		}

		//#################################################################################//
		//################################################################################//

		/*
		 * Método btClientes_Click:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de Clientes en la vista de opciones.
		 *	Configura la vista de opciones para mostrar las opciones relacionadas con clientes.
		 *
		 *	Entradas:
		 *	- object sender: El objeto que activó el evento.
		 *	- EventArgs e: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	Ninguno.
		 */
		private void btClientes_Click(object sender, EventArgs e) {
			this.vistaOpciones.setActive("Clientes");
			this.vistaOpciones.btAdd.Visible = true;
			this.vistaOpciones.btAdd.Text = "Añadir Clientes";
			this.vistaOpciones.btMod.Visible = true;
			this.vistaOpciones.btMod.Text = "Modificar Clientes";
			this.vistaOpciones.btDel.Visible = true;
			this.vistaOpciones.btDel.Text = "Eliminar Clientes";
			if (!this.vistaOpciones.esAdmin) {
				this.vistaOpciones.btDel.Enabled = false;
			}
		}

		/*
		 * Método btReservas_Click:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de Reservas en la vista de opciones.
		 *	Configura la vista de opciones para mostrar las opciones relacionadas con reservas.
		 *
		 *	Entradas:
		 *	- object pSender: El objeto que activó el evento.
		 *	- EventArgs pE: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- pSender: Objeto que activó el evento.
		 *	- pE: Argumentos del evento.
		 */
		private void btReservas_Click(object pSender, EventArgs pE) {
			this.vistaOpciones.setActive("Reservas");
			this.vistaOpciones.btAdd.Visible = true;
			this.vistaOpciones.btAdd.Text = "Añadir Reserva";
			this.vistaOpciones.btMod.Visible = true;
			this.vistaOpciones.btMod.Text = "Modificar Reserva";
			this.vistaOpciones.btDel.Visible = true;
			this.vistaOpciones.btDel.Text = "Eliminar Reserva";
			if (!this.vistaOpciones.esAdmin) {
				this.vistaOpciones.btDel.Enabled = false;
			}

		}

		/*
		 * Método btReportes_Click:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de Reportes en la vista de opciones.
		 *	Configura la vista de opciones para mostrar las opciones relacionadas con reportes.
		 *
		 *	Entradas:
		 *	- object pSender: El objeto que activó el evento.
		 *	- EventArgs pE: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- pSender: Objeto que activó el evento.
		 *	- pE: Argumentos del evento.
		 */
		private void btReportes_Click(object pSender, EventArgs pE) {
			this.vistaOpciones.setActive("Reportes");
			this.vistaOpciones.btAdd.Visible = true;
			this.vistaOpciones.btAdd.Text = "Tablas";
			this.vistaOpciones.btMod.Visible = true;
			this.vistaOpciones.btMod.Text = "Gráficas";
			this.vistaOpciones.btDel.Visible = false;
		}

		/*
		 * Método btPersonal_Click:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de Personal en la vista de opciones.
		 *	Configura la vista de opciones para mostrar las opciones relacionadas con el personal.
		 *
		 *	Entradas:
		 *	- object sender: El objeto que activó el evento.
		 *	- EventArgs e: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- sender: Objeto que activó el evento.
		 *	- e: Argumentos del evento.
		 */
		private void btPersonal_Click(object sender, EventArgs e) {
			this.vistaOpciones.setActive("Personal");
			this.vistaOpciones.btAdd.Visible = true;
			this.vistaOpciones.btAdd.Text = "Añadir Personal";
			this.vistaOpciones.btMod.Visible = true;
			this.vistaOpciones.btMod.Text = "Modificar Personal";
			this.vistaOpciones.btDel.Visible = true;
			this.vistaOpciones.btDel.Text = "Eliminar Personal";
		}


		//#################################################################################//
		//################################################################################//


		/*
		 * Método btAddSolveCall:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de añadir en la vista de opciones.
		 *	Realiza acciones específicas dependiendo de la opción activa en la vista de opciones.
		 *
		 *	Entradas:
		 *	- object pSender: El objeto que activó el evento.
		 *	- EventArgs pE: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- pSender: Objeto que activó el evento.
		 *	- pE: Argumentos del evento.
		 */
		private void btAddSolveCall(object pSender, EventArgs pE) {

			if (this.vistaOpciones.getActive() == "Clientes") {
				this.vwAddClient = new VistaAgregarClientes(this.vistaOpciones);

				this.vwAddClient.btAgregar.Click += btAgregarCliente_Click;
				this.vwAddClient.FormClosed += cerrarVentana;
				this.vwAddClient.Show();

			} else if (this.vistaOpciones.getActive() == "Reservas") {
				agregarReserva(new VistaAgregarReservas(this.vistaOpciones));

			} else if (this.vistaOpciones.getActive() == "Reportes") {
				reporteriaResultado();

			} else if (this.vistaOpciones.getActive() == "Personal") {
				this.vwAddWorker = new VistaAgregarPersonal(this.vistaOpciones);

				Roles rolesManager = new Roles(bdHotel);
				List<string> roleList = rolesManager.getRoles();
				if (roleList == null || roleList.Count == 0) {
					MessageBox.Show("No hay roles para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.vwAddWorker.cbRol.Items.AddRange(roleList.ToArray());

				this.vwAddWorker.btAgregarPersonal.Click += btAgregarPersonal_Click;
				this.vwAddWorker.FormClosed += cerrarVentana;
				this.vwAddWorker.Show();
			}

			return;
		}

		/*
		 * Método btModSolveCall:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de modificar en la vista de opciones.
		 *	Realiza acciones específicas dependiendo de la opción activa en la vista de opciones.
		 *
		 *	Entradas:
		 *	- object pSender: El objeto que activó el evento.
		 *	- EventArgs pE: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- pSender: Objeto que activó el evento.
		 *	- pE: Argumentos del evento.
		 */
		private void btModSolveCall(object pSender, EventArgs pE) {

			if (this.vistaOpciones.getActive() == "Clientes") {
				this.vwModClient = new VistaModificarClientes(this.vistaOpciones, this.vistaOpciones.esAdmin);

				Clientes clientManager = new Clientes(bdHotel);
				List<string> clientList = clientManager.getClientes();
				if (clientList == null || clientList.Count == 0) {
					MessageBox.Show("No hay clientes para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.vwModClient.cbListaClientes.Items.AddRange(clientList.ToArray());

				this.vwModClient.cbListaClientes.SelectedIndexChanged += cbListaClientes_Mod_Listener;
				this.vwModClient.btModificarCliente.Click += btModificarCliente_Click;
				this.vwModClient.btBuscarCliente.Click += btBuscarCliente_Mod_Click;
				this.vwModClient.txtBuscar.KeyPress += txtBuscar_Listener;
				this.vwModClient.FormClosed += cerrarVentana;

				this.vwModClient.readOnly();
				this.vwModClient.Show();

			} else if (this.vistaOpciones.getActive() == "Reservas") {
				ajusteReserva(new VistaEstadoReserva(this.vistaOpciones));

			} else if (this.vistaOpciones.getActive() == "Reportes") {
				mostrarVistaGraficos();

			} else if (this.vistaOpciones.getActive() == "Personal") {
				this.vwModWorker = new VistaModificarPersonal(this.vistaOpciones);

				Usuarios workerManager = new Usuarios(bdHotel);
				List<string> workerList = workerManager.getUsuarios();
				if (workerList == null || workerList.Count == 0) {
					MessageBox.Show("No hay personal para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.vwModWorker.cbListaPersonal.Items.AddRange(workerList.ToArray());

				Roles rolesManager = new Roles(bdHotel);
				List<string> roleList = rolesManager.getRoles();
				if (roleList == null || roleList.Count == 0) {
					MessageBox.Show("No hay roles para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.vwModWorker.cbRol.Items.AddRange(roleList.ToArray());

				this.vwModWorker.cbListaPersonal.SelectedIndexChanged += cbListaPersonal_Mod_Listener;
				this.vwModWorker.btModificarPersonal.Click += btModificarPersonal_Click;
				this.vwModWorker.btBuscarPersonal.Click += btBuscarPersonal_Mod_Click;
				this.vwModWorker.txtBuscar.KeyPress += txtBuscar_Listener;
				this.vwModWorker.FormClosed += cerrarVentana;

				this.vwModWorker.readOnly();
				this.vwModWorker.Show();
			}

			return;
		}

		/*
		 * Método btDelsolveCall:
		 *
		 *	Descripción:
		 *	Método que se activa cuando se hace clic en el botón de eliminar en la vista de opciones.
		 *	Realiza acciones específicas dependiendo de la opción activa en la vista de opciones.
		 *
		 *	Entradas:
		 *	- object pSender: El objeto que activó el evento.
		 *	- EventArgs pE: Argumentos del evento.
		 *
		 *	Salidas:
		 *	Ninguna.
		 *
		 *	Parámetros:
		 *	- pSender: Objeto que activó el evento.
		 *	- pE: Argumentos del evento.
		 */
		private void btDelsolveCall(object pSender, EventArgs pE) {
			if (this.vistaOpciones.getActive() == "Clientes") {
				this.vwDelClient = new VistaEliminarClientes(this.vistaOpciones);

				Clientes clientManager = new Clientes(bdHotel);
				List<string> clientList = clientManager.getClientes();
				if (clientList == null || clientList.Count == 0) {
					MessageBox.Show("No hay clientes para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.vwDelClient.cbListaClientes.Items.AddRange(clientList.ToArray());

				this.vwDelClient.cbListaClientes.SelectedIndexChanged += cbListaClientes_Del_Listener;
				this.vwDelClient.btEliminarCliente.Click += btEliminarCliente_Click;
				this.vwDelClient.btBuscarCliente.Click += btBuscarCliente_Del_Click;
				this.vwDelClient.txtBuscar.KeyPress += txtBuscar_Listener;
				this.vwDelClient.FormClosed += cerrarVentana;

				this.vwDelClient.readOnly();
				this.vwDelClient.Show();

			} else if (this.vistaOpciones.getActive() == "Reservas") {
				borrarReservas(new VistaBorrarReservas(this.vistaOpciones));

			} else if (this.vistaOpciones.getActive() == "Personal") {
				this.vwDelWorker = new VistaEliminarPersonal(this.vistaOpciones);

				Usuarios workerManager = new Usuarios(bdHotel);
				List<string> workerList = workerManager.getUsuarios();
				if (workerList == null || workerList.Count == 0) {
					MessageBox.Show("No hay personal para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				this.vwDelWorker.cbListaPersonal.Items.AddRange(workerList.ToArray());

				this.vwDelWorker.cbListaPersonal.SelectedIndexChanged += cbListaPersonal_Del_Listener;
				this.vwDelWorker.btEliminarPersonal.Click += btEliminarPersonal_Click;
				this.vwDelWorker.btBuscarPersonal.Click += btBuscarPersonal_Del_Click;
				this.vwDelWorker.FormClosed += cerrarVentana;

				this.vwDelWorker.readOnly();
				this.vwDelWorker.Show();
			}

			return;
		}



		//####################################################################################//
		//###################################################################################//
		//                      L I S T E N E R S   Y     C L I C K S                       //
		//#################################################################################//
		//################################################################################//

		/*
		* Método btAgregarCliente_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de agregar cliente en la vista de agregar clientes.
		*	Realiza la validación de los datos ingresados y agrega un nuevo cliente si los datos son válidos.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btAgregarCliente_Click(object sender, EventArgs e) {
			Clientes clientManager = new Clientes(bdHotel);

			if (this.vwAddClient.txtCedula.Text == "Ej: 123456789" ||
				this.vwAddClient.txtNombre.Text == "Ej: Eyden Su Díaz" ||
				this.vwAddClient.txtPais.Text == "Ej: Costa Rica" ||
				this.vwAddClient.txtTelefono.Text == "Ej: 88888888" ||
				this.vwAddClient.txtEmail.Text == "Ej: ejemplo@gmail.com") {
				MessageBox.Show("Error: No deje espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			if (clientManager.buscarCliente(this.vwAddClient.txtCedula.Text) != null) {
				MessageBox.Show("Cliente: Cédula ya registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			if (!verifyFormat(this.vwAddClient.txtCedula.Text, "space") ||
				!verifyFormat(this.vwAddClient.txtCedula.Text, "") ||
				this.vwAddClient.txtCedula.Text.Length < 9) {
				MessageBox.Show("Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			if (!verifyFormat(this.vwAddClient.txtNombre.Text, "space") ||
				!verifyFormat(this.vwAddClient.txtNombre.Text, "text")) {
				MessageBox.Show("Nombre: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			if (!verifyFormat(this.vwAddClient.txtPais.Text, "space") ||
				!verifyFormat(this.vwAddClient.txtPais.Text, "text")) {
				MessageBox.Show("Pais Natal: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			if (!verifyFormat(this.vwAddClient.txtTelefono.Text, "space") ||
				!verifyFormat(this.vwAddClient.txtTelefono.Text, "") ||
				this.vwAddClient.txtTelefono.Text.Length < 8) {
				MessageBox.Show("Télefono: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			if (!verifyFormat(this.vwAddClient.txtEmail.Text, "space")) {
				MessageBox.Show("Correo Electrónico: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			int    idCliente = Convert.ToInt32(this.vwAddClient.txtCedula.Text);
			string nombre    = this.vwAddClient.txtNombre.Text;
			string pais      = this.vwAddClient.txtPais.Text;
			int    telefono  = Convert.ToInt32(this.vwAddClient.txtTelefono.Text);
			string email     = this.vwAddClient.txtEmail.Text;

			clientManager.agregarCliente(idCliente, nombre, pais, telefono, email);

			MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.vwAddClient.defaultText();
		}

		/*
		* Método btModificarCliente_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de modificar cliente en la vista de modificar clientes.
		*	Realiza la validación de los datos modificados y actualiza la información del cliente si los datos son válidos.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btModificarCliente_Click(object sender, EventArgs e) {
			if ((this.vwModClient.cbListaClientes.SelectedItem == null && this.vwModClient.Text == "Ej: 123456789") ||
				this.vwModClient.txtCedula.Text == null ||
				this.vwModClient.txtCedula.Text == "") {
				MessageBox.Show("Seleccione un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (!verifyFormat(this.vwModClient.txtCedula.Text, "space") ||
				!verifyFormat(this.vwModClient.txtCedula.Text, "") ||
				this.vwModClient.txtCedula.Text.Length < 9) {
				MessageBox.Show("Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModClient.txtNombre.Text, "space") ||
				!verifyFormat(this.vwModClient.txtNombre.Text, "text")) {
				MessageBox.Show("Nombre: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModClient.txtPais.Text, "space") ||
				!verifyFormat(this.vwModClient.txtPais.Text, "text")) {
				MessageBox.Show("Pais Natal: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModClient.txtTelefono.Text, "space") ||
				!verifyFormat(this.vwModClient.txtTelefono.Text, "") ||
				this.vwModClient.txtTelefono.Text.Length < 8) {
				MessageBox.Show("Télefono: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModClient.txtEmail.Text, "space")) {
				MessageBox.Show("Correo Electrónico: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (this.vwModClient.txtNombre.Text == "Ej: Eyden Su Díaz" &&
				this.vwModClient.txtPais.Text == "Ej: Costa Rica" &&
				this.vwModClient.txtTelefono.Text == "Ej: 88888888" &&
				this.vwModClient.txtEmail.Text == "Ej: ejemplo@gmail.com") {
				MessageBox.Show("Error: Modifique al menos 1 espacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Clientes clientManager = new Clientes(bdHotel);
			int    idCliente = Convert.ToInt32(this.vwModClient.txtCedula.Text);
			string nombre    = this.vwModClient.txtNombre.Text;
			string pais      = this.vwModClient.txtPais.Text;
			string telefono  = this.vwModClient.txtTelefono.Text;
			string email     = this.vwModClient.txtEmail.Text;

			if (nombre != "Ej: Eyden Su Díaz") {
				clientManager.modificarCliente(idCliente, nombre, "", -1, "");
			}
			if (pais != "Ej: Costa Rica") {
				clientManager.modificarCliente(idCliente, "", pais, -1, "");
			}
			if (telefono != "Ej: 88888888") {
				clientManager.modificarCliente(idCliente, "", "", Convert.ToInt32(telefono), "");
			}
			if (email != "Ej: ejemplo@gmail.com") {
				clientManager.modificarCliente(idCliente, "", "", -1, email);
			}
			MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.vwModClient.clearText();
			this.vwModClient.readOnly();
			this.vwModClient.cbListaClientes.SelectedIndex = -1;
		}

		/*
		* Método btEliminarCliente_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de eliminar cliente en la vista de eliminar clientes.
		*	Elimina el cliente seleccionado si se confirma la eliminación y no tiene reservaciones asociadas.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btEliminarCliente_Click(object sender, EventArgs e) {
			if (this.vwDelClient.txtCedula.Text == "" || this.vwDelClient.txtCedula.Text == null) {
				MessageBox.Show("Seleccione un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (tieneReservasRealizadas(this.vwDelClient.txtCedula.Text)) {
				MessageBox.Show("No puede eliminar este cliente: \nPosee reservaciones realizadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			string idCliente = this.vwDelClient.txtCedula.Text;
			string nombre    = this.vwDelClient.txtNombre.Text;
			DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar al Cliente "+ nombre + " ?", "Confirmar", MessageBoxButtons.YesNo);
			if (resultado == DialogResult.No) {
				return;
			}

			Clientes clientManager = new Clientes(bdHotel);
			clientManager.eliminarCliente(Convert.ToInt32(idCliente));
			MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.vwDelClient.clearText();
			this.vwDelClient.txtBuscar.Text = "";
			this.vwDelClient.cbListaClientes.SelectedIndex = -1;

			List<string> clientList = clientManager.getClientes();
			if (clientList == null || clientList.Count == 0) {
				MessageBox.Show("No hay clientes para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.vwDelClient.Close();
				return;
			}
			this.vwDelClient.cbListaClientes.Items.Clear();
			this.vwDelClient.cbListaClientes.Items.AddRange(clientList.ToArray());
		}

		/*
		* Método btAgregarPersonal_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de agregar personal en la vista de agregar personal.
		*	Realiza la validación de los datos ingresados y agrega un nuevo usuario del personal si los datos son válidos.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btAgregarPersonal_Click(object sender, EventArgs e) {
			Usuarios workerManager  = new Usuarios(bdHotel);
			Roles    rolesManager   = new Roles(bdHotel);
			Cuentas  accountManager = new Cuentas(bdHotel);

			if (this.vwAddWorker.txtCedula.Text == "Ej: 123456789" ||
				this.vwAddWorker.txtNombre.Text == "Ej: Eyden Su Díaz" ||
				this.vwAddWorker.txtAddress.Text == "Ej: Colina" ||
			!this.vwAddWorker.esGeneroSeleccionado() ||
				this.vwAddWorker.txtTelefono.Text == "Ej: 88888888" ||
				this.vwAddWorker.txtEmail.Text == "Ej: ejemplo@gmail.com" ||
				this.vwAddWorker.cbRol.Text == "Seleccione un rol" ||
				this.vwAddWorker.txtPassword.Text == "Ingrese una contraseña") {
				MessageBox.Show("Error: No deje espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (workerManager.buscarUsuario(this.vwAddWorker.txtCedula.Text) != null) {
				MessageBox.Show("Usuario: Cédula ya registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwAddWorker.txtCedula.Text, "space") ||
				!verifyFormat(this.vwAddWorker.txtCedula.Text, "") ||
				this.vwAddWorker.txtCedula.Text.Length < 9) {
				MessageBox.Show("Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwAddWorker.txtNombre.Text, "space") ||
				!verifyFormat(this.vwAddWorker.txtNombre.Text, "text")) {
				MessageBox.Show("Nombre: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyBornDate(this.vwAddWorker.dtpBornDate.Value)) {
				MessageBox.Show("Fecha de Nacimiento: fecha no permitida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwAddWorker.txtAddress.Text, "space") ||
				!verifyFormat(this.vwAddWorker.txtAddress.Text, "text")) {
				MessageBox.Show("Dirección: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwAddWorker.txtTelefono.Text, "space") ||
				!verifyFormat(this.vwAddWorker.txtTelefono.Text, "") ||
				this.vwAddWorker.txtTelefono.Text.Length < 8) {
				MessageBox.Show("Télefono: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwAddWorker.txtEmail.Text, "space")) {
				MessageBox.Show("Correo Electrónico: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (this.vwAddWorker.cbRol.SelectedIndex == -1) {
				MessageBox.Show("Rol: Seleccione un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwAddWorker.txtPassword.Text, "space")) {
				MessageBox.Show("Contraseña: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int    idUsuario       = Convert.ToInt32(this.vwAddWorker.txtCedula.Text);
			string nombre          = this.vwAddWorker.txtNombre.Text;
			string fechaNacimiento = this.vwAddWorker.dtpBornDate.Value.ToString("yyyy-MM-dd");
			string direccion       = this.vwAddWorker.txtAddress.Text;
			string genero          = (this.vwAddWorker.rbMas.Checked ? "M" : "F");
			int    telefono        = (int) Convert.ToInt64(this.vwAddWorker.txtTelefono.Text);
			string email           = this.vwAddWorker.txtEmail.Text;
			int    idRol           = rolesManager.buscarIdRol(this.vwAddWorker.cbRol.Text);
			string password        = this.vwAddWorker.txtPassword.Text;

			workerManager.agregarUsuario(idUsuario, nombre, fechaNacimiento, direccion, email, telefono, genero, idRol);
			accountManager.agregarCuenta(idUsuario, password);
			MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.vwAddWorker.defaultValues();
		}

		/*
		* Método btModificarPersonal_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de modificar personal en la vista de modificar personal.
		*	Realiza la validación de los datos ingresados y modifica un usuario del personal si los datos son válidos.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btModificarPersonal_Click(object sender, EventArgs e) {
			if (this.vwModWorker.txtCedula.Text == "" || this.vwModWorker.txtCedula.Text == null) {
				MessageBox.Show("Seleccione un trabajador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Usuarios workerManager  = new Usuarios(bdHotel);
			Roles    rolesManager   = new Roles(bdHotel);
			Cuentas  accountManager = new Cuentas(bdHotel);

			if (this.vwModWorker.txtCedula.Text == "Ej: 123456789" ||
				this.vwModWorker.txtNombre.Text == "Ej: Eyden Su Díaz" ||
				this.vwModWorker.txtAddress.Text == "Ej: Colina" ||
				!this.vwModWorker.esGeneroSeleccionado() ||
				this.vwModWorker.txtTelefono.Text == "Ej: 88888888" ||
				this.vwModWorker.txtEmail.Text == "Ej: ejemplo@gmail.com" ||
				this.vwModWorker.cbRol.Text == "Seleccione un rol" ||
				this.vwModWorker.txtPassword.Text == "Ingrese una contraseña") {
				MessageBox.Show("Error: No deje espacios en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModWorker.txtCedula.Text, "space") ||
				!verifyFormat(this.vwModWorker.txtCedula.Text, "") ||
				this.vwModWorker.txtCedula.Text.Length < 9) {
				MessageBox.Show("Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModWorker.txtNombre.Text, "space") ||
				!verifyFormat(this.vwModWorker.txtNombre.Text, "text")) {
				MessageBox.Show("Nombre: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyBornDate(this.vwModWorker.dtpBornDate.Value)) {
				MessageBox.Show("Fecha de Nacimiento: fecha no permitida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModWorker.txtAddress.Text, "space") ||
				!verifyFormat(this.vwModWorker.txtAddress.Text, "text")) {
				MessageBox.Show("Dirección: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModWorker.txtTelefono.Text, "space") ||
				!verifyFormat(this.vwModWorker.txtTelefono.Text, "") ||
				this.vwModWorker.txtTelefono.Text.Length < 8) {
				MessageBox.Show("Télefono: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModWorker.txtEmail.Text, "space")) {
				MessageBox.Show("Correo Electrónico: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (this.vwModWorker.cbRol.SelectedIndex == -1) {
				MessageBox.Show("Rol: Seleccione un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModWorker.txtPassword.Text, "space")) {
				MessageBox.Show("Contraseña: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int    idUsuario       = Convert.ToInt32(this.vwModWorker.txtCedula.Text);
			string nombre          = this.vwModWorker.txtNombre.Text;
			string fechaNacimiento = this.vwModWorker.dtpBornDate.Value.ToString("yyyy-MM-dd");
			string direccion       = this.vwModWorker.txtAddress.Text;
			string genero          = (this.vwModWorker.rbMas.Checked ? "M" : "F");
			int    telefono        = (int) Convert.ToInt64(this.vwModWorker.txtTelefono.Text);
			string email           = this.vwModWorker.txtEmail.Text;
			int    idRol           = rolesManager.buscarIdRol(this.vwModWorker.cbRol.Text);
			string password        = this.vwModWorker.txtPassword.Text;

			workerManager.modificarUsuario(idUsuario, nombre, fechaNacimiento, direccion, email, telefono, genero, idRol);
			accountManager.modificarCuenta(idUsuario, password);
			MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.vwModWorker.clearText();
			this.vwModWorker.readOnly();
		}

		/*
		* Método btEliminarPersonal_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de eliminar personal en la vista de eliminar personal.
		*	Realiza la validación de los datos ingresados y elimina un usuario del personal si los datos son válidos.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btEliminarPersonal_Click(object sender, EventArgs e) {
			if (this.vwDelWorker.txtCedula.Text == "" || this.vwDelWorker.txtCedula.Text == null) {
				MessageBox.Show("Seleccione un trabajador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (Convert.ToInt64(this.vwDelWorker.txtCedula.Text) == this.vistaOpciones.idUsuario) {
				MessageBox.Show("No puede eliminar su usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			if (tieneReservasRealizadas(this.vwDelWorker.txtCedula.Text)) {
				MessageBox.Show("No puede eliminar este usuario: \nPosee reservas realizadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			string idUsuario = this.vwDelWorker.txtCedula.Text;
			string nombre = this.vwDelWorker.txtNombre.Text;
			DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar al empleado "+ nombre + " ?", "Confirmar", MessageBoxButtons.YesNo);
			if (resultado == DialogResult.No) {
				return;
			}
			BitacoraLogin loginManager = new BitacoraLogin(bdHotel);
			Usuarios workerManager = new Usuarios(bdHotel);
			Cuentas accountManager = new Cuentas(bdHotel);
			try {
				loginManager.deleteLogins(idUsuario);
			} catch {

			}
			accountManager.eliminarCuenta(idUsuario);
			workerManager.eliminarUsuario(Convert.ToInt32(idUsuario));

			MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.vwDelWorker.clearText();
			this.vwDelWorker.txtBuscar.Text = "";
			this.vwDelWorker.cbListaPersonal.SelectedIndex = -1;

			List<string> workerList = workerManager.getUsuarios();
			if (workerList == null || workerList.Count == 0) {
				MessageBox.Show("No hay personal para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			this.vwDelWorker.cbListaPersonal.Items.Clear();
			this.vwDelWorker.cbListaPersonal.Items.AddRange(workerList.ToArray());
		}

		/*
		* Método btBuscarCliente_Mod_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de buscar cliente en la vista de modificar cliente.
		*	Realiza la búsqueda de un cliente por su cédula y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		public void btBuscarCliente_Mod_Click(object sender, EventArgs e) {
			if (this.vwModClient.txtBuscar.Text == null || this.vwModClient.txtBuscar.Text == "") {
				MessageBox.Show("Buscar Cédula: Debe ingresar una cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModClient.txtBuscar.Text, "space") ||
				!verifyFormat(this.vwModClient.txtBuscar.Text, "") ||
				this.vwModClient.txtBuscar.Text.Length < 9) {
				MessageBox.Show("Buscar Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Clientes clientManager = new Clientes(bdHotel);
			string   idCliente = this.vwModClient.txtBuscar.Text;
			string[] cliente   = clientManager.buscarCliente(idCliente);

			if (cliente == null) {
				MessageBox.Show("Buscar Cédula: Cédula no registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.vwModClient.setText(cliente);
			this.vwModClient.enWrite();
		}

		/*
		* Método btBuscarCliente_Del_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de buscar cliente en la vista de eliminar cliente.
		*	Realiza la búsqueda de un cliente por su cédula y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		public void btBuscarCliente_Del_Click(object sender, EventArgs e) {
			if (this.vwDelClient.txtBuscar.Text == null || this.vwDelClient.txtBuscar.Text == "") {
				MessageBox.Show("Buscar Cédula: Debe ingresar una cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwDelClient.txtBuscar.Text, "space") ||
				!verifyFormat(this.vwDelClient.txtBuscar.Text, "") ||
				this.vwDelClient.txtBuscar.Text.Length < 9) {
				MessageBox.Show("Buscar Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Clientes clientManager = new Clientes(bdHotel);
			string   idCliente = this.vwDelClient.txtBuscar.Text;
			string[] cliente   = clientManager.buscarCliente(idCliente);

			if (cliente == null) {
				MessageBox.Show("Buscar Cédula: Cédula no registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.vwDelClient.setText(cliente);
		}

		/*
		* Método btBuscarPersonal_Mod_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de buscar personal en la vista de modificar personal.
		*	Realiza la búsqueda de un usuario del personal por su cédula y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btBuscarPersonal_Mod_Click(object sender, EventArgs e) {
			if (this.vwModWorker.txtBuscar.Text == null || this.vwModWorker.txtBuscar.Text == "") {
				MessageBox.Show("Buscar Cédula: Debe ingresar una cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwModWorker.txtBuscar.Text, "space") ||
				!verifyFormat(this.vwModWorker.txtBuscar.Text, "") ||
				this.vwModWorker.txtBuscar.Text.Length < 9) {
				MessageBox.Show("Buscar Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Cuentas  accountManager = new Cuentas(bdHotel);
			Usuarios workerManager  = new Usuarios(bdHotel);
			Roles    rolesManager   = new Roles(bdHotel);
			string   idUsuario      = this.vwModWorker.txtBuscar.Text;

			string[] cuentaUsuario  = accountManager.buscarCuenta(idUsuario);
			string[] usuario        = workerManager.buscarUsuario(idUsuario);
			string   nombreRol      = rolesManager.buscarNombreRol(Convert.ToInt32(usuario[7]));

			if (usuario == null) {
				MessageBox.Show("Buscar Cédula: Cédula no registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.vwModWorker.setText(usuario, nombreRol, cuentaUsuario[2]);
			this.vwModWorker.enWrite();
		}

		/*
		* Método btBuscarPersonal_Del_Click:
		*
		*	Descripción:
		*	Método que se activa cuando se hace clic en el botón de buscar personal en la vista de eliminar personal.
		*	Realiza la búsqueda de un usuario del personal por su cédula y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void btBuscarPersonal_Del_Click(object sender, EventArgs e) {
			if (this.vwDelWorker.txtBuscar.Text == null || this.vwDelWorker.txtBuscar.Text == "") {
				MessageBox.Show("Buscar Cédula: Debe ingresar una cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!verifyFormat(this.vwDelWorker.txtBuscar.Text, "space") ||
				!verifyFormat(this.vwDelWorker.txtBuscar.Text, "") ||
				this.vwDelWorker.txtBuscar.Text.Length < 9) {
				MessageBox.Show("Buscar Cédula: Formato incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Usuarios workerManager = new Usuarios(bdHotel);
			Roles    rolesManager  = new Roles(bdHotel);
			string   idUsuario     = this.vwDelWorker.txtBuscar.Text;

			string[] usuario       = workerManager.buscarUsuario(idUsuario);
			string   nombreRol     = rolesManager.buscarNombreRol(Convert.ToInt32(usuario[7]));

			if (usuario == null) {
				MessageBox.Show("Buscar Cédula: Cédula no registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.vwDelWorker.setText(usuario, nombreRol);
		}

		/*
		* Método cbListaClientes_Mod_Listener:
		*
		*	Descripción:
		*	Método que se activa cuando se selecciona un cliente de la lista en la vista de modificar cliente.
		*	Realiza la búsqueda del cliente seleccionado y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		public void cbListaClientes_Mod_Listener(object sender, EventArgs e) {
			if (this.vwModClient.cbListaClientes.SelectedItem == null) {
				return;
			}
			Clientes clientManager = new Clientes(bdHotel);
			string   idCliente = (this.vwModClient.cbListaClientes.Text).Substring(0,9);
			string[] cliente   = clientManager.buscarCliente(idCliente);

			this.vwModClient.setText(cliente);

			List<string> clientList = clientManager.getClientes();
			if (clientList == null || clientList.Count == 0) {
				MessageBox.Show("No hay clientes para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			this.vwModClient.cbListaClientes.Items.AddRange(clientList.ToArray());
			this.vwModClient.enWrite();
		}


		/*
		* Método cbListaClientes_Del_Listener:
		*
		*	Descripción:
		*	Método que se activa cuando se selecciona un cliente de la lista en la vista de eliminar cliente.
		*	Realiza la búsqueda del cliente seleccionado y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		public void cbListaClientes_Del_Listener(object sender, EventArgs e) {
			if (this.vwDelClient.cbListaClientes.SelectedItem == null) {
				return;
			}
			Clientes clientManager = new Clientes(bdHotel);
			string   idCliente = (this.vwDelClient.cbListaClientes.Text).Substring(0,9);
			string[] cliente   = clientManager.buscarCliente(idCliente);

			this.vwDelClient.setText(cliente);

			List<string> clientList = clientManager.getClientes();
			if (clientList == null || clientList.Count == 0) {
				MessageBox.Show("No hay clientes para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			this.vwDelClient.cbListaClientes.Items.AddRange(clientList.ToArray());
		}

		/*
		* Método cbListaPersonal_Mod_Listener:
		*
		*	Descripción:
		*	Método que se activa cuando se selecciona un usuario del personal de la lista en la vista de modificar personal.
		*	Realiza la búsqueda del usuario seleccionado y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		public void cbListaPersonal_Mod_Listener(object sender, EventArgs e) {
			if (this.vwModWorker.cbListaPersonal.SelectedItem == null) {
				return;
			}

			Cuentas  accountManager = new Cuentas(bdHotel);
			Usuarios workerManager  = new Usuarios(bdHotel);
			Roles    rolesManager   = new Roles(bdHotel);
			string   idUsuario      = (this.vwModWorker.cbListaPersonal.Text).Substring(0, 9);

			string[] usuario        = workerManager.buscarUsuario(idUsuario);
			string[] cuentaUsuario  = accountManager.buscarCuenta(idUsuario);
			string   nombreRol      = rolesManager.buscarNombreRol(Convert.ToInt32(usuario[7]));

			this.vwModWorker.setText(usuario, nombreRol, cuentaUsuario[2]);

			List<string> workerList = workerManager.getUsuarios();
			if (workerList == null || workerList.Count == 0) {
				MessageBox.Show("No hay personal para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			this.vwModWorker.cbListaPersonal.Items.AddRange(workerList.ToArray());
			if (Convert.ToInt32(usuario[0]) == this.vistaOpciones.idUsuario) {
				MessageBox.Show("No puede modificar su rol.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				vwModWorker.esPropioUsuario();
			}
			this.vwModWorker.enWrite();
		}

		/*
		* Método cbListaPersonal_Del_Listener:
		*
		*	Descripción:
		*	Método que se activa cuando se selecciona un usuario del personal de la lista en la vista de eliminar personal.
		*	Realiza la búsqueda del usuario seleccionado y muestra los datos si existe.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- EventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		public void cbListaPersonal_Del_Listener(object sender, EventArgs e) {
			if (this.vwDelWorker.cbListaPersonal.SelectedItem == null) {
				return;
			}
			Usuarios workerManager = new Usuarios(bdHotel);
			Roles    rolesManager  = new Roles(bdHotel);
			string   idUsuario     = (this.vwDelWorker.cbListaPersonal.Text).Substring(0, 9);

			string[] usuario       = workerManager.buscarUsuario(idUsuario);
			string   nombreRol     = rolesManager.buscarNombreRol(Convert.ToInt32(usuario[7]));

			this.vwDelWorker.setText(usuario, nombreRol);

			if (Convert.ToInt64(this.vwDelWorker.txtCedula.Text) == this.vistaOpciones.idUsuario) {
				MessageBox.Show("No puede eliminar su usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			List<string> workerList = workerManager.getUsuarios();
			if (workerList == null || workerList.Count == 0) {
				MessageBox.Show("No hay personal para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			this.vwDelWorker.cbListaPersonal.Items.AddRange(workerList.ToArray());
		}

		/*
		* Método txtBuscar_Listener:
		*
		*	Descripción:
		*	Método que se activa cuando se presiona Enter en el campo de búsqueda de la vista activa.
		*	Realiza la búsqueda correspondiente según la vista en la que se encuentre el usuario.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- KeyPressEventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void txtBuscar_Listener(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char) Keys.Enter) {
				if (this.vwModClient != null && this.vwModClient.Visible) {
					btBuscarCliente_Mod_Click(sender, EventArgs.Empty);
				} else if (this.vwDelClient != null && this.vwDelClient.Visible) {
					btBuscarCliente_Del_Click(sender, EventArgs.Empty);
				} else if (this.vwModWorker != null && this.vwModWorker.Visible) {
					btBuscarPersonal_Mod_Click(sender, EventArgs.Empty);
				} else {
					btBuscarPersonal_Del_Click(sender, EventArgs.Empty);
				}

				e.Handled = true;
			}
		}

		/*
		* Método txtContrasena_Listener:
		*
		*	Descripción:
		*	Método que se activa cuando se presiona Enter en el campo de contraseña.
		*	Inicia sesión si se presiona Enter en el campo de contraseña.
		*
		*	Entradas:
		*	- object sender: El objeto que activó el evento.
		*	- KeyPressEventArgs e: Argumentos del evento.
		*
		*	Salidas:
		*	Ninguna.
		*
		*	Parámetros:
		*	- sender: Objeto que activó el evento.
		*	- e: Argumentos del evento.
		*/
		private void txtContrasena_Listener(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char) Keys.Enter) {
				iniciarSesion(sender, EventArgs.Empty);

				e.Handled = true;
			}
		}
		//####################################################################################//
		//###################################################################################//
		//                        A   U   X   I   L   I   A   R   E   S                     //
		//#################################################################################//
		//################################################################################//

		/*
		 * Método verifyFormat:
		 *
		 *	Descripción:
		 *	Método que verifica el formato de un texto según el tipo de verificación especificado.
		 *
		 *	Entradas:
		 *	- string pText: El texto a verificar.
		 *	- string verify: El tipo de verificación a realizar ("space" para espacios, "text" para texto, otro para números).
		 *
		 *	Salidas:
		 *	- bool: Devuelve true si el formato es válido, false si no lo es.
		 *
		 *	Parámetros:
		 *	- pText: El texto a verificar.
		 *	- verify: El tipo de verificación a realizar.
		 */
		private bool verifyFormat(string pText, string verify) {
			bool flag = false;
			if (pText == null || pText.Length == 0) {
				return false;
			}
			if (verify == "space") {
				for (int i = 0; i < pText.Length; i++) {
					if (flag && pText[i] == ' ') {
						return false;
					} else if (pText[i] == ' ') {
						flag = true;
					} else {
						flag = false;
					}
				}
			} else if (verify == "text") {
				for (int i = 0; i < pText.Length; i++) {
					if (isNum(pText[i])) {
						return false;
					}
				}
			} else {
				for (int i = 0; i < pText.Length; i++) {
					if (!isNum(pText[i])) {
						return false;
					}
				}
			}
			return true;
		}

		/*
		 * Método isNum:
		 *
		 *	Descripción:
		 *	Método que verifica si un carácter es un dígito numérico.
		 *
		 *	Entradas:
		 *	- char pCharacter: El carácter a verificar.
		 *
		 *	Salidas:
		 *	- bool: Devuelve true si el carácter es un dígito numérico, false si no lo es.
		 *
		 *	Parámetros:
		 *	- pCharacter: El carácter a verificar.
		 */
		private bool isNum(char pCharacter) {
			return char.IsDigit(pCharacter);
		}

		/*
		 * Método verifyBornDate:
		 *
		 *	Descripción:
		 *	Método que verifica si una fecha de nacimiento cumple con los requisitos de edad (entre 18 y 60 años).
		 *
		 *	Entradas:
		 *	- DateTime pBornDate: La fecha de nacimiento a verificar.
		 *
		 *	Salidas:
		 *	- bool: Devuelve true si la fecha de nacimiento cumple con los requisitos, false si no los cumple.
		 *
		 *	Parámetros:
		 *	- pBornDate: La fecha de nacimiento a verificar.
		 */
		private bool verifyBornDate(DateTime pBornDate) {
			DateTime actualDate = DateTime.Today;
			int edad = actualDate.Year - pBornDate.Year;

			if (edad >= 18 && edad < 60) {
				return true;
			} else {
				return false;
			}
		}

		/*
		 * Método tieneReservasRealizadas:
		 *
		 *	Descripción:
		 *	Método que verifica si una persona tiene reservas realizadas en el sistema.
		 *
		 *	Entradas:
		 *	- string idPersona: El ID de la persona a verificar.
		 *
		 *	Salidas:
		 *	- bool: Devuelve true si la persona tiene reservas realizadas, false si no las tiene.
		 *
		 *	Parámetros:
		 *	- idPersona: El ID de la persona a verificar.
		 */
		private bool tieneReservasRealizadas(string idPersona) {
			bdHotel.Open();
			bool tieneReservas = false;

			if (this.vistaOpciones.getActive() == "Personal") {
				SqlCommand cmd = new SqlCommand("SELECT idReserva FROM Reserva WHERE idUsuario = @idPersona", bdHotel);
				cmd.Parameters.AddWithValue("@idPersona", idPersona);
				object result = cmd.ExecuteScalar();
				tieneReservas = (result != null && result != DBNull.Value);

			} else if (this.vistaOpciones.getActive() == "Clientes") {
				SqlCommand cmd = new SqlCommand("SELECT idReserva FROM Reserva WHERE idCliente = @idPersona", bdHotel);
				cmd.Parameters.AddWithValue("@idPersona", idPersona);
				object result = cmd.ExecuteScalar();
				tieneReservas = (result != null && result != DBNull.Value);
			}

			bdHotel.Close();
			return tieneReservas;
		}


		//////                    ⬆⬆⬆⬆⬆ CÓDIGO EYDEN FIN ⬆⬆⬆⬆⬆                   /////////
		/////////////////////////////////////////////////////////////////////////////////
		//*****************************************************************************//









		///////////////////////////////////////////////////////////////////////////////
		///////                       CÓDIGO JOSE ANDRÉS                      ////////

		public void agregarReserva(VistaAgregarReservas pVistaAgregarReservas) {
			this.reservas = pVistaAgregarReservas;
			this.reservas.FormClosed += cerrarVentana;
			this.reservas.Show();
			reservas.botonResgitrarInformacion.Click += AgregarReserva_Aux;
			reservas.botonRegistrarCliente.Click += AgregarCliente;
			reservas.botonChechIn.Click += AgregarCheckIn;
			reservas.botonCheckOut.Click += AgregarCheckOut;
			reservas.botonVerPrecio.Click += VerPrecioTotal;



		}

		private void VerPrecioTotal(object sender, EventArgs e) {
			if (reservas.textIdentificacion.Text == "" || reservas.textCheckIn.Text == "" || reservas.textCheckOut.Text == "" || reservas.comboBoxDescuntos.SelectedItem == null) {
				MessageBox.Show("Credenciales Incompletas. Por favor, Llene todos los espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			}

			try {
				Convert.ToInt32(reservas.textIdentificacion.Text);
			} catch (Exception ex) {
				MessageBox.Show("Error al validar el idCliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;

			} finally {
				bdHotel.Close();
			}
			//////////////////Validacion idCliente existente/////////////////////////////////////////////////////////////
			bdHotel.Open();
			SqlCommand obtenerIds = new SqlCommand("SELECT idCliente FROM Cliente WHERE (idCliente = @idCliente)", bdHotel);
			obtenerIds.Parameters.AddWithValue("@idCliente", Convert.ToInt32(reservas.textIdentificacion.Text));
			DateTime fechaCheckIn_Aux = fechaCheckIn;


			var id = obtenerIds.ExecuteScalar();
			bdHotel.Close();

			if (id == DBNull.Value) {
				MessageBox.Show("Cliente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			}

			////////////////////////Validacion precioByhabitacion//////////////////////////
			SqlCommand validarPrecioHabitacion = new SqlCommand("SELECT precio FROM Habitacion WHERE(tipo = @tipo)", bdHotel);
			validarPrecioHabitacion.Parameters.AddWithValue("@tipo", reservas.comboBoxHabitacion.SelectedItem.ToString());
			double precio = 0;
			bdHotel.Open();
			double precioHabitacion = Convert.ToDouble(validarPrecioHabitacion.ExecuteScalar());
			bdHotel.Close();
			/////////////////////////////////////Validacion dias////////////////////////////////////////////////////////////////////////////
			while (fechaCheckIn_Aux != fechaCheckOut.AddDays(1)) {
				////Temporadas altas
				if (fechaCheckIn_Aux >= DateTime.Parse("01/06/2024") && fechaCheckIn_Aux <= DateTime.Parse("31/08/2024")) {
					precio += precioHabitacion;

				} else if (fechaCheckIn_Aux >= DateTime.Parse("24/03/2024") && fechaCheckIn_Aux <= DateTime.Parse("7/04/2024")) {
					precio += precioHabitacion;
				} else if (fechaCheckIn_Aux >= DateTime.Parse("20/12/2024") && fechaCheckIn_Aux <= DateTime.Parse("15/01/2025")) {
					precio += precioHabitacion;
				}
				  ////Temporadas medias
				  else if (fechaCheckIn_Aux >= DateTime.Parse("01/09/2024") && fechaCheckIn_Aux <= DateTime.Parse("20/10/2024")) {
					precio += precioHabitacion - precioHabitacion * 0.3;
				} else if (fechaCheckIn_Aux >= DateTime.Parse("16/01/2024") && fechaCheckIn_Aux <= DateTime.Parse("08/02/2024")) {
					precio += precioHabitacion - precioHabitacion * 0.3;
				} else {
					precio += precioHabitacion - precioHabitacion * 0.4;
				}
				fechaCheckIn_Aux = fechaCheckIn_Aux.AddDays(1);

			}

			/////////////////////////////////////COMBOBOX DE DESCUENTOS////////////////////////////////////////////////////////////////////////////
			bdHotel.Open();
			SqlCommand AgregarDescuentos = new SqlCommand("SELECT COUNT(idCliente) FROM Reserva WHERE descuentoAplicado != 1 and idCliente = @idCliente", bdHotel);
			AgregarDescuentos.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);
			int countadorDescuentos = Convert.ToInt32(AgregarDescuentos.ExecuteScalar());
			bdHotel.Close();

			if (reservas.comboBoxDescuntos.SelectedItem.ToString() == "5% de descuento." && countadorDescuentos >= 5) {
				precio -= (precio * 0.05);
			} else if (reservas.comboBoxDescuntos.SelectedItem.ToString() == "10% de descuento." && countadorDescuentos >= 6) {
				precio -= precio * 0.1;

			} else if (reservas.comboBoxDescuntos.SelectedItem.ToString() == "Noche gratis." && countadorDescuentos >= 10) {
				fechaCheckOut = fechaCheckOut.AddDays(1);
			} else if (reservas.comboBoxDescuntos.SelectedItem.ToString() != "No aplicar descuento.") {
				MessageBox.Show("No tienes suficientes puntos para obtener este descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			reservas.labelPrecioTotal.Text = "Precio total: " + precio.ToString();
		}
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		private void AgregarReserva_Aux(object sender, EventArgs e) {

			if (reservas.textIdentificacion.Text == "" || reservas.textCheckIn.Text == "" || reservas.textCheckOut.Text == "" || reservas.comboBoxDescuntos.SelectedItem == null) {
				MessageBox.Show("Credenciales Incompletas. Por favor, Llene todos los espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			}
			try {
				Convert.ToInt32(reservas.textIdentificacion.Text);
			} catch (Exception ex) {
				MessageBox.Show("Error al validar el idCliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			} finally {
				bdHotel.Close();
			}

			//////////////////Validacion idCliente existente/////////////////////////////////////////////////////////////
			bdHotel.Open();
			SqlCommand obtenerIds = new SqlCommand("SELECT idCliente FROM Cliente WHERE (idCliente = @idCliente)", bdHotel);
			obtenerIds.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);

			var id = obtenerIds.ExecuteScalar();
			bdHotel.Close();

			if (id == null && id == DBNull.Value) {
				MessageBox.Show("Cliente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DateTime fechaCheckIn_Aux = fechaCheckIn;

			////////////////////////Validacion precioByhabitacion//////////////////////////
			SqlCommand validarPrecioHabitacion = new SqlCommand("SELECT precio FROM Habitacion WHERE(tipo = @tipo)", bdHotel);
			validarPrecioHabitacion.Parameters.AddWithValue("@tipo", reservas.comboBoxHabitacion.SelectedItem.ToString());
			double precio = 0;
			bdHotel.Open();
			double precioHabitacion = Convert.ToDouble(validarPrecioHabitacion.ExecuteScalar());
			bdHotel.Close();

			/////////////////////////////////////Validacion dias////////////////////////////////////////////////////////////////////////////
			while (fechaCheckIn_Aux != fechaCheckOut.AddDays(1)) {
				////Temporadas altas
				if (fechaCheckIn_Aux >= DateTime.Parse("01/06/2024") && fechaCheckIn_Aux <= DateTime.Parse("31/08/2024")) {
					precio += precioHabitacion;

				} else if (fechaCheckIn_Aux >= DateTime.Parse("24/03/2024") && fechaCheckIn_Aux <= DateTime.Parse("7/04/2024")) {
					precio += precioHabitacion;
				} else if (fechaCheckIn_Aux >= DateTime.Parse("20/12/2024") && fechaCheckIn_Aux <= DateTime.Parse("15/01/2025")) {
					precio += precioHabitacion;
				}
				  ////Temporadas medias
				  else if (fechaCheckIn_Aux >= DateTime.Parse("01/09/2024") && fechaCheckIn_Aux <= DateTime.Parse("20/10/2024")) {
					precio += precioHabitacion - precioHabitacion * 0.3;
				} else if (fechaCheckIn_Aux >= DateTime.Parse("16/01/2024") && fechaCheckIn_Aux <= DateTime.Parse("08/02/2024")) {
					precio += precioHabitacion - precioHabitacion * 0.3;
				} else {
					precio += precioHabitacion - precioHabitacion * 0.4;
				}
				fechaCheckIn_Aux = fechaCheckIn_Aux.AddDays(1);

			}

			/////////////////////////////////////COMBOBOX DE DESCUENTOS////////////////////////////////////////////////////////////////////////////

			SqlCommand AgregarDescuentos = new SqlCommand("SELECT COUNT(idCliente) FROM Reserva WHERE descuentoAplicado != 1 and idCliente = @idCliente", bdHotel);
			AgregarDescuentos.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);
			bdHotel.Open();
			int countadorDescuentos = Convert.ToInt32(AgregarDescuentos.ExecuteScalar());


			if (reservas.comboBoxDescuntos.SelectedItem.ToString() == "5% de descuento." && countadorDescuentos >= 5) {
				int contador = 0;
				SqlCommand SelectsIdReservas = new SqlCommand("SELECT idReserva FROM Reserva WHERE idCliente = @idCliente", bdHotel);
				SelectsIdReservas.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);
				SqlDataReader idReservas = SelectsIdReservas.ExecuteReader();
				List<int> ids = new List<int>();
				while (idReservas.Read()) {
					ids.Add(idReservas.GetInt32(0));
				}
				bdHotel.Close();
				foreach (int idactual in ids) {
					if (contador == 5) {

						break;
					}
					bdHotel.Open();
					SqlCommand updateBit = new SqlCommand("UPDATE Reserva SET descuentoAplicado = 1 WHERE idReserva = @idReserva", bdHotel);
					updateBit.Parameters.AddWithValue("@idReserva", idactual);
					updateBit.ExecuteNonQuery();
					bdHotel.Close();
					contador++;
				}
				precio -= (precio * 0.05);
			} else if (reservas.comboBoxDescuntos.SelectedItem.ToString() == "10% de descuento." && countadorDescuentos >= 6) {

				int contador = 0;
				SqlCommand SelectsIdReservas = new SqlCommand("SELECT idReserva FROM Reserva WHERE idCliente = @idCliente", bdHotel);
				SelectsIdReservas.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);
				SqlDataReader idReservas = SelectsIdReservas.ExecuteReader();
				List<int> ids = new List<int>();
				while (idReservas.Read()) {
					ids.Add(idReservas.GetInt32(0));
				}
				bdHotel.Close();
				foreach (int idactual in ids) {
					if (contador == 6) {

						break;
					}
					bdHotel.Open();
					SqlCommand updateBit = new SqlCommand("UPDATE Reserva SET descuentoAplicado = 1 WHERE idReserva = @idReserva", bdHotel);
					updateBit.Parameters.AddWithValue("@idReserva", idactual);
					updateBit.ExecuteNonQuery();
					bdHotel.Close();
					contador++;
				}
				precio -= precio * 0.1;

			} else if (reservas.comboBoxDescuntos.SelectedItem.ToString() == "Noche gratis." && countadorDescuentos >= 10) {

				int contador = 0;
				SqlCommand SelectsIdReservas = new SqlCommand("SELECT idReserva FROM Reserva WHERE idCliente = @idCliente", bdHotel);
				SelectsIdReservas.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);
				SqlDataReader idReservas = SelectsIdReservas.ExecuteReader();
				List<int> ids = new List<int>();
				while (idReservas.Read()) {
					ids.Add(idReservas.GetInt32(0));
				}
				bdHotel.Close();
				foreach (int idactual in ids) {
					if (contador == 10) {

						break;
					}
					bdHotel.Open();
					SqlCommand updateBit = new SqlCommand("UPDATE Reserva SET descuentoAplicado = 1 WHERE idReserva = @idReserva", bdHotel);
					updateBit.Parameters.AddWithValue("@idReserva", idactual);
					updateBit.ExecuteNonQuery();
					bdHotel.Close();
					contador++;
				}
				fechaCheckOut = fechaCheckOut.AddDays(1);
			} else if (reservas.comboBoxDescuntos.SelectedItem.ToString() != "No aplicar descuento.") {
				MessageBox.Show("No tienes suficientes puntos para obtener este descuento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			bdHotel.Close();

			try {
				bdHotel.Open();
				SqlCommand encontrarIdHabitacion = new SqlCommand("SELECT idHabitacion FROM Habitacion WHERE(tipo = @tipo)", bdHotel);
				encontrarIdHabitacion.Parameters.AddWithValue("@tipo", reservas.comboBoxHabitacion.SelectedItem.ToString());
				int idHabitacion = Convert.ToInt32(encontrarIdHabitacion.ExecuteScalar());

				int idReserva = 0;

				SqlCommand encontrarMaxIdReserva = new SqlCommand("SELECT MAX(idReserva) FROM Reserva", bdHotel);
				if (encontrarMaxIdReserva.ExecuteScalar() != DBNull.Value) {
					idReserva = Convert.ToInt32(encontrarMaxIdReserva.ExecuteScalar());
				}

				SqlCommand register = new SqlCommand("INSERT INTO Reserva VALUES (@idReserva, @idCliente,'ACTIVO', @fechaEntrada, @fechaSalida, @idHabitacion, 0, @precioTotal, @idUsuario)", bdHotel);
				register.Parameters.AddWithValue("@idReserva", idReserva + 1);
				register.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);
				register.Parameters.AddWithValue("@fechaEntrada", fechaCheckIn.ToString("MM-dd-yyyy"));
				register.Parameters.AddWithValue("@fechaSalida", fechaCheckOut.ToString("MM-dd-yyyy"));
				register.Parameters.AddWithValue("@idUsuario", reservas.vista.idUsuario);

				register.Parameters.AddWithValue("@idHabitacion", idHabitacion);
				register.Parameters.AddWithValue("@precioTotal", precio);
				int rowsAffected = register.ExecuteNonQuery();
				MessageBox.Show("Reserva agregada exitosamente.");
			} catch (Exception ex) {
				MessageBox.Show("Error al agregar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				bdHotel.Close();
			}
		}

		private void AgregarCliente(object sender, EventArgs e) {
			if (reservas.textIdentificacion.Text == "") {
				MessageBox.Show("Credenciales Incompletas. Por favor, Llene todos los espacios");
				return;
			}

			bdHotel.Open();
			SqlCommand login = new SqlCommand("SELECT idCliente FROM Cliente WHERE (idCliente = @idCliente)", bdHotel);
			login.Parameters.AddWithValue("@idCliente", reservas.textIdentificacion.Text);

			/////////////////////////////////////COMBOBOX DE HABITACIONES//////////////////////////////////////////////////////////////////////////////

			try {
				SqlCommand agregarHabitacion = new SqlCommand("SELECT DISTINCT tipo FROM Habitacion", bdHotel);
				SqlDataReader reader = agregarHabitacion.ExecuteReader();
				//Limpiamos primero el comboBox
				reservas.comboBoxHabitacion.Items.Clear();

				//Agrega los elementos al comboBox
				while (reader.Read()) {
					reservas.comboBoxHabitacion.Items.Add(reader["tipo"].ToString());
				}

				//Cierra el lector y la coneccion
				reader.Close();

			} catch (Exception ex) {
				MessageBox.Show("ERROR: No se cargaron los tipos de habitaciones: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
			}

			if (reservas.comboBoxHabitacion.SelectedIndex == -1) {
				MessageBox.Show("por favor, selecciones una habitacion disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			}
			bdHotel.Close();
		}

		private void AgregarCheckIn(object sender, EventArgs e) {
			fechaCheckIn = reservas.monthCalendario.SelectionRange.Start;
			reservas.textCheckIn.Text = fechaCheckIn.ToShortDateString();

		}

		private void AgregarCheckOut(object sender, EventArgs e) {
			fechaCheckOut = reservas.monthCalendario.SelectionRange.Start;
			reservas.textCheckOut.Text = fechaCheckOut.ToShortDateString();

		}

		public void borrarReservas(VistaBorrarReservas pVistaBorrarReservas) {
			this.ajustes = pVistaBorrarReservas;
			this.ajustes.Show();
			this.ajustes.FormClosed += cerrarVentana;
			ajustes.botonVerReservas.Click += verReservas;
			//ajustes.botonRegresar.Click += regresar
			ajustes.botonBorrarReservas.Click += borrarReservas_Aux;

		}
		private void verReservas(object sender, EventArgs e) {

			try {
				bdHotel.Open();
				/////ComboBox VerReservas:
				MessageBox.Show("Ya puedes ver la informacion de reservas: ", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
				SqlCommand verReservas = new SqlCommand("SELECT DISTINCT idReserva, idCliente, estadoReserva FROM Reserva ", bdHotel);
				SqlDataReader reader = verReservas.ExecuteReader();
				//Limpiamos primero el comboBox
				ajustes.comboBoxVerReservas.Items.Clear();

				//Agrega los elementos al comboBox
				while (reader.Read()) {
					string item = reader["idReserva"].ToString() + " | " +
								  reader["idCliente"].ToString() + " | " +
								  reader["estadoReserva"].ToString();
					ajustes.comboBoxVerReservas.Items.Add(item);
				}

				//Cierra el lector y la coneccion
				reader.Close();
				bdHotel.Close();
			} catch (Exception ex) {
				MessageBox.Show("ERROR: No se cargaron los tipos de reserva: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

			} finally {
				bdHotel.Close();
			}
		}
		private void borrarReservas_Aux(object sender, EventArgs e) {
			if (ajustes.comboBoxVerReservas.Text == "") {
				MessageBox.Show("Seleccione una reserva a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (ajustes.comboBoxVerReservas.SelectedItem == null) {
				MessageBox.Show("Seleccione una reserva a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try {
				// Abre la conexión a la base de datos
				bdHotel.Open();

				// Obtiene el valor seleccionado del ComboBox
				string selectedItem = ajustes.comboBoxVerReservas.SelectedItem.ToString();

				// Divide el valor seleccionado en sus partes (idReserva, idCliente, estadoReserva)
				string[] parts = selectedItem.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
				string idReserva = parts[0].Trim();
				string idCliente = parts[1].Trim();
				string estadoReserva = parts[2].Trim();
				if (estadoReserva == "ACTIVO") {
					MessageBox.Show("Reserva no eliminada, estado a 'ACTIVO'", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Verifica si la reserva aún existe en la base de datos
				SqlCommand verificarReserva = new SqlCommand("SELECT Count(idReserva) FROM Reserva WHERE idReserva = @idReserva AND idCliente = @idCliente AND estadoReserva = @estadoReserva", bdHotel);
				verificarReserva.Parameters.AddWithValue("@idReserva", idReserva);
				verificarReserva.Parameters.AddWithValue("@idCliente", idCliente);
				verificarReserva.Parameters.AddWithValue("@estadoReserva", estadoReserva);
				int rowCount = (int)verificarReserva.ExecuteScalar();

				if (rowCount == 0) {
					MessageBox.Show("La reserva seleccionada ya ha sido eliminada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ajustes.comboBoxVerReservas.Text = "";
					ajustes.comboBoxVerReservas.Items.Clear();

					return;
				}

				// Construye la consulta SQL para eliminar la reserva
				string query = "DELETE FROM Reserva WHERE idReserva = @idReserva AND idCliente = @idCliente AND estadoReserva = @estadoReserva";

				// Crea y configura el comando SQL
				SqlCommand eliminarReserva = new SqlCommand(query, bdHotel);
				eliminarReserva.Parameters.AddWithValue("@idReserva", idReserva);
				eliminarReserva.Parameters.AddWithValue("@idCliente", idCliente);
				eliminarReserva.Parameters.AddWithValue("@estadoReserva", estadoReserva);

				// Ejecuta la consulta SQL
				int rowsAffected = eliminarReserva.ExecuteNonQuery();

				// Verifica si se eliminó correctamente la reserva
				if (rowsAffected > 0) {
					MessageBox.Show("Reserva eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ajustes.comboBoxVerReservas.Items.Clear();
					ajustes.comboBoxVerReservas.Text = "";
				} else {
					MessageBox.Show("No se pudo eliminar la reserva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					ajustes.comboBoxVerReservas.Items.Clear();
					ajustes.comboBoxVerReservas.Text = "";
				}
			} catch (Exception ex) {
				MessageBox.Show("Error al intentar eliminar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				// Cierra la conexión a la base de datos
				bdHotel.Close();
			}
		}

		public void ajusteReserva(VistaEstadoReserva pVistaEstadoReserva) {
			this.estadoReserva = pVistaEstadoReserva;
			this.estadoReserva.FormClosed += cerrarVentana;
			this.estadoReserva.Show();

			estadoReserva.botonAplicarCambioEstadoReserva.Click += ajusteReserva_Aux;
			estadoReserva.botonVerReserva.Click += verReservasEstado;
			//estadoReserva.botonRegresar.Click += regresarReservaEstado;
		}
		public void ajusteReserva_Aux(object sender, EventArgs e) {
			if (estadoReserva.textNumReserva.Text == "") {

				MessageBox.Show("Credenciales Incompletas. Por favor, Llene todos los espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			}
			if (!estadoReserva.textNumReserva.Text.All(char.IsDigit)) {
				MessageBox.Show("El número de reserva solo puede contener caracteres numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			}
			try {
				Convert.ToInt32(estadoReserva.textNumReserva.Text);
			} catch (Exception ex) {
				MessageBox.Show("Error al validar el idReserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			} finally {
				bdHotel.Close();
			}
			//////////////////Validacion idReserva existente/////////////////////////////////////////////////////////////
			bdHotel.Open();
			SqlCommand obtenerIdReserva = new SqlCommand("SELECT idReserva FROM Reserva WHERE (idReserva = @idReserva)", bdHotel);
			obtenerIdReserva.Parameters.AddWithValue("@idReserva", Convert.ToInt32(estadoReserva.textNumReserva.Text));
			///fechaCheckIn_Aux2
			DateTime fechaCheckIn_Aux2 = DateTime.Now;


			var idReserva = obtenerIdReserva.ExecuteScalar();
			bdHotel.Close();

			if (idReserva == DBNull.Value) {
				MessageBox.Show("Reserva no registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				bdHotel.Close();
				return;
			}
			bdHotel.Open();
			SqlCommand obtenerFechaCheckIn = new SqlCommand("SELECT fechaEntrada FROM Reserva WHERE (idReserva = @idReserva)", bdHotel);
			obtenerFechaCheckIn.Parameters.AddWithValue("@idReserva", Convert.ToInt32(estadoReserva.textNumReserva.Text));
			object resultado = obtenerFechaCheckIn.ExecuteScalar();

			if (resultado != null && resultado != DBNull.Value) {
				this.fechaCheckIn = Convert.ToDateTime(resultado);
			} else {
				MessageBox.Show("Error: No se encontró la reserva especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			bdHotel.Close();
			/////////////////////////////////////Validacion dias////////////////////////////////////////////////////////////////////////////
			TimeSpan diferenciaDias = fechaCheckIn - fechaCheckIn_Aux2;
			// Verificar si fechaCheckIn_Aux2 no pasa de 2 días
			if (diferenciaDias.TotalDays <= 2) {
				MessageBox.Show("Error: CANCELACION NO APLICABLE, ESTAS CANCELANDO FALTANDO 1 DIA O 2 PARA TU RESERVA.", "ERR0R", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			bdHotel.Open();
			SqlCommand cambiarEstadoReserva = new SqlCommand("UPDATE Reserva SET estadoReserva = 'Cancelado/Pendiente a borrar' WHERE idReserva = @idReserva", bdHotel);
			cambiarEstadoReserva.Parameters.AddWithValue("@idReserva", Convert.ToInt32(estadoReserva.textNumReserva.Text)); // Cambiar a idReserva
			cambiarEstadoReserva.ExecuteNonQuery(); // Ejecuta el comando para actualizar el estado


			try {
				int rowsAffected = cambiarEstadoReserva.ExecuteNonQuery(); // Ejecutar el comando para actualizar el estado
				if (rowsAffected > 0) {
					MessageBox.Show("CONFIRMACION: Se cambió el estado exitosamente.", "NOTICIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					MessageBox.Show("No se encontró ninguna reserva con el ID proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception ex) {
				MessageBox.Show("ERROR: No se cambió el estado de la reserva: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} finally {
				bdHotel.Close();
			}



		}



		private void verReservasEstado(object sender, EventArgs e) {

			try {
				bdHotel.Open();
				/////ComboBox VerReservas:
				MessageBox.Show("Ya puedes ver la informacion de reservas: ", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
				SqlCommand verReservasEstado = new SqlCommand("SELECT DISTINCT idReserva, idCliente, estadoReserva,fechaEntrada FROM Reserva ", bdHotel);
				SqlDataReader reader = verReservasEstado.ExecuteReader();
				//Limpiamos primero el comboBox
				estadoReserva.comboBoxVerReservas2.Items.Clear();

				//Agrega los elementos al comboBox
				while (reader.Read()) {
					string item = reader["idReserva"].ToString() + " | " +
								  reader["idCliente"].ToString() + " | " +
								  reader["fechaEntrada"].ToString() + " | " +
								  reader["estadoReserva"].ToString();
					estadoReserva.comboBoxVerReservas2.Items.Add(item);
				}

				//Cierra el lector y la coneccion
				reader.Close();
				bdHotel.Close();
			} catch (Exception ex) {
				MessageBox.Show("ERROR: No se cargaron los tipos de reserva: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

			} finally {
				bdHotel.Close();
			}
		}

		///////                  ⬆⬆⬆⬆⬆  CÓDIGO JOSE FIN  ⬆⬆⬆⬆⬆                 ////////
		//////////////////////////////////////////////////////////////////////////////
		//************************************************************************//


		public SqlConnection getbdHotel() {
			return bdHotel;
		}

		public void reporteriaResultado() {
			this.reporteria = new VistaReporteria(this.vistaOpciones);
			this.reporteria.Show();
			reporteria.botonReporteriaCancelar.Click += mostrarReporteriaCanceldas;
			reporteria.botonReporteriaHabitacionIngresar.Click += mostrarReporteriaHabitacion;
			reporteria.botonReporteriaReservasIngresar.Click += mostrarReporteriaIngreso;
			reporteria.botonReporteriaReservas.Click += mostrarReporteriaReservas;
			reporteria.botonReporteriaTopClient.Click += mostrarReporteriaTopClient;
			reporteria.btLogins.Click += mostrarReporteriaLogins;
		}

		private void mostrarReporteriaCanceldas(object sender, EventArgs e) {
			bdHotel.Open();
			SqlCommand ReporteriaCANCELADAS = new SqlCommand("SELECT idCliente AS 'CEDULA', idReserva AS 'CODIGO DE RESERVA', estadoReserva AS 'ESTADO', fechaEntrada AS 'CHECK-IN', fechaSalida AS 'CHECK-OUT', idHabitacion AS 'CODIGO DE HABITACION', descuentoAplicado AS 'DESCUENTO', precioTotal AS 'PRECIO TOTAL' FROM Reserva WHERE estadoReserva = 'Cancelado/Pendiente a borrar'", bdHotel);
			SqlDataAdapter actualizarcancel = new SqlDataAdapter(ReporteriaCANCELADAS);
			DataTable cancel = new DataTable();
			actualizarcancel.Fill(cancel);

			reporteria.dataTablaReporteria.DataSource = cancel;

			bdHotel.Close();
		}

		private void mostrarReporteriaLogins(object sender, EventArgs e) {
			bdHotel.Open();
			SqlCommand ReporteriaCANCELADAS = new SqlCommand("SELECT B.idCuenta AS 'Cédula', U.nombreCompleto AS Nombre, fechaLogin AS 'Día' FROM BitacoraLogin B, Usuario U WHERE B.idCuenta = U.idUsuario", bdHotel);
			SqlDataAdapter actualizarcancel = new SqlDataAdapter(ReporteriaCANCELADAS);
			DataTable cancel = new DataTable();
			actualizarcancel.Fill(cancel);

			reporteria.dataTablaReporteria.DataSource = cancel;

			bdHotel.Close();
		}

		private void mostrarReporteriaReservas(object sender, EventArgs e) {
			bdHotel.Open();
			SqlCommand ReporteriaReservas = new SqlCommand("SELECT idCliente AS 'CEDULA', idReserva AS 'CODIGO DE RESERVA', estadoReserva AS 'ESTADO', fechaEntrada AS 'CHECK-IN', fechaSalida AS 'CHECK-OUT', idHabitacion AS 'CODIGO DE HABITACION', descuentoAplicado AS 'DESCUENTO', precioTotal AS 'PRECIO TOTAL' FROM Reserva ", bdHotel);
			SqlDataAdapter actualizarcancel = new SqlDataAdapter(ReporteriaReservas);
			DataTable cancel = new DataTable();
			actualizarcancel.Fill(cancel);

			reporteria.dataTablaReporteria.DataSource = cancel;

			bdHotel.Close();
		}

		private void mostrarReporteriaTopClient(object sender, EventArgs e) {
			bdHotel.Open();
			SqlCommand ReporteriaReservas = new SqlCommand("SELECT TOP 1 idCliente AS 'CLIENTE MAS FRECUENTE', COUNT(idReserva) AS 'TOTAL DE RESERVAS REALIZADAS' FROM Reserva GROUP BY idCliente ORDER BY 'TOTAL DE RESERVAS REALIZADAS' DESC; ", bdHotel);
			SqlDataAdapter actualizarcancel = new SqlDataAdapter(ReporteriaReservas);
			DataTable cancel = new DataTable();
			actualizarcancel.Fill(cancel);

			reporteria.dataTablaReporteria.DataSource = cancel;

			bdHotel.Close();
		}

		private void mostrarReporteriaIngreso(object sender, EventArgs e) {
			if (reporteria.textReporteriaCliente.Text == "") {
				MessageBox.Show(" ERROR: Espacio vacio, por favor ingrese la informacion antes de consultar ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!verifyFormat(reporteria.textReporteriaCliente.Text, "")) {
				MessageBox.Show("ERROR: Solo se acepta numeros en este apartado. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Clientes admin = new Clientes(bdHotel);

			if (admin.buscarCliente(reporteria.textReporteriaCliente.Text) == null) {
				MessageBox.Show("ERROR: Cliente no encontrado, intenta con otra cedula. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			bdHotel.Open();
			SqlCommand textCliente = new SqlCommand("SELECT idCliente AS 'CEDULA', idReserva AS 'CODIGO DE RESERVA', estadoReserva AS 'ESTADO', fechaEntrada AS 'CHECK-IN', fechaSalida AS 'CHECK-OUT', idHabitacion AS 'CODIGO DE HABITACION', descuentoAplicado AS 'DESCUENTO', precioTotal AS 'PRECIO TOTAL' FROM Reserva WHERE idCliente = @idCliente", bdHotel);
			textCliente.Parameters.AddWithValue("@idCliente", reporteria.textReporteriaCliente.Text);
			SqlDataAdapter actualizarcancel = new SqlDataAdapter(textCliente);
			DataTable cancel = new DataTable();
			actualizarcancel.Fill(cancel);

			reporteria.dataTablaReporteria.DataSource = cancel;

			bdHotel.Close();
		}



		private void mostrarReporteriaHabitacion(object sender, EventArgs e) {
			if (reporteria.textReporteriaHabitacion.Text == "") {
				MessageBox.Show("ERROR: Espacio vacio, por favor ingrese la informacion antes de consultar ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			bdHotel.Open();
			SqlCommand idHabitacion = new SqlCommand("SELECT idHabitacion FROM Habitacion WHERE tipo = @HabitacionNombre", bdHotel);
			idHabitacion.Parameters.AddWithValue("@HabitacionNombre", reporteria.textReporteriaHabitacion.Text);

			var idHabitacionTipo = idHabitacion.ExecuteScalar();
			bdHotel.Close();
			if (idHabitacionTipo == null && idHabitacionTipo == DBNull.Value) {
				MessageBox.Show("ERROR: Habitacion no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			bdHotel.Open();
			SqlCommand textHabitacion = new SqlCommand("SELECT idCliente AS 'CEDULA', idReserva AS 'CODIGO DE RESERVA', estadoReserva AS 'ESTADO', fechaEntrada AS 'CHECK-IN', fechaSalida AS 'CHECK-OUT', idHabitacion AS 'CODIGO DE HABITACION' FROM Reserva WHERE idHabitacion = @idHabitacion", bdHotel);
			textHabitacion.Parameters.AddWithValue("@idHabitacion", Convert.ToInt32(idHabitacionTipo));
			SqlDataAdapter actualizarcancel = new SqlDataAdapter(textHabitacion);
			DataTable cancel = new DataTable();
			actualizarcancel.Fill(cancel);

			reporteria.dataTablaReporteria.DataSource = cancel;

			bdHotel.Close();
		}

		public void mostrarVistaGraficos() {
			this.graficos = new VistaGraficos(this.vistaOpciones);
			this.graficos.btClientChart.Click += (sender, e) => mostrarGraficaClientesResidencia();
			this.graficos.btRecepChart.Click += (sender, e) => mostrarGraficaReservasPorRecep();
			this.graficos.btTopChart.Click += (sender, e) => mostrarGraficaTopFechas();
			this.graficos.Show();


		}

		private void mostrarGraficaClientesResidencia() {
			try {
				DataTable dt = clientStats();

				if (dt.Rows.Count > 0) {
					this.graficos.chartGraficosGenerales.Series["sChart"].Points.Clear();

					foreach (DataRow row in dt.Rows) {
						string habitacion = row["Habitacion"].ToString();
						int clientes = Convert.ToInt32(row["Clientes"]);

						this.graficos.chartGraficosGenerales.Series["sChart"].Points.AddXY(habitacion, clientes);
					}
				} else {
					MessageBox.Show("La tabla de estadísticas de clientes está vacía.");
				}

			} catch (Exception ex) {
				Console.WriteLine("Error al mostrar la gráfica de clientes: " + ex.Message);
			}

		}

		private void mostrarGraficaTopFechas() {
			try {
				DataTable dt = topFechas();

				if (dt.Rows.Count > 0) {
					this.graficos.chartGraficosGenerales.Series["sChart"].Points.Clear();

					foreach (DataRow row in dt.Rows) {
						string dia = row["Dia"].ToString();
						int reservas = Convert.ToInt32(row["Reservas"]);


						this.graficos.chartGraficosGenerales.Series["sChart"].Points.AddXY(dia, reservas);
					}
				} else {
					MessageBox.Show("La tabla de estadísticas de reservas está vacía.");
				}

			} catch (Exception ex) {
				Console.WriteLine("Error al mostrar la gráfica: " + ex.Message);
			}

		}

		private void mostrarGraficaReservasPorRecep() {
			try {
				DataTable dt = maxReservas();

				if (dt.Rows.Count > 0) {
					this.graficos.chartGraficosGenerales.Series["sChart"].Points.Clear();

					foreach (DataRow row in dt.Rows) {
						string recepcionista = row["Recepcionista"].ToString();
						int reservas = Convert.ToInt32(row["Reservas"]);

						this.graficos.chartGraficosGenerales.Series["sChart"].Points.AddXY(recepcionista, reservas);
					}
				} else {
					MessageBox.Show("La tabla de estadísticas de reservas está vacía.");
				}

			} catch (Exception ex) {
				Console.WriteLine("Error al mostrar la gráfica: " + ex.Message);
			}

		}
		public DataTable clientStats() {
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("ClientStat", bdHotel);
			da.Fill(dt);
			return dt;
		}

		public DataTable maxReservas() {
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("maxReservas", bdHotel);
			da.Fill(dt);
			return dt;
		}

		public DataTable topFechas() {
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("TopFechas", bdHotel);
			da.Fill(dt);
			return dt;
		}
	}
}
