namespace PY1_BD.Vista {
	partial class VistaModificarPersonal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lbTitle = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btRegresar = new System.Windows.Forms.Button();
			this.lbCedula = new System.Windows.Forms.Label();
			this.lbNombre = new System.Windows.Forms.Label();
			this.lbBornDate = new System.Windows.Forms.Label();
			this.lbTelefono = new System.Windows.Forms.Label();
			this.lbEmail = new System.Windows.Forms.Label();
			this.lbAddress = new System.Windows.Forms.Label();
			this.lbGenero = new System.Windows.Forms.Label();
			this.lbRol = new System.Windows.Forms.Label();
			this.lbPassword = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.cbRol = new System.Windows.Forms.ComboBox();
			this.rbMas = new System.Windows.Forms.RadioButton();
			this.rbFem = new System.Windows.Forms.RadioButton();
			this.dtpBornDate = new System.Windows.Forms.DateTimePicker();
			this.btBuscarPersonal = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.cbListaPersonal = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbList = new System.Windows.Forms.Label();
			this.logoImg = new System.Windows.Forms.PictureBox();
			this.btModificarPersonal = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbTitle.Location = new System.Drawing.Point(397, 34);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(310, 27);
			this.lbTitle.TabIndex = 5;
			this.lbTitle.Text = "Información del Empleado";
			// 
			// txtCedula
			// 
			this.txtCedula.BackColor = System.Drawing.Color.White;
			this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.ForeColor = System.Drawing.Color.Black;
			this.txtCedula.Location = new System.Drawing.Point(443, 90);
			this.txtCedula.MaxLength = 9;
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(293, 28);
			this.txtCedula.TabIndex = 2;
			this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Click);
			this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.Black;
			this.txtNombre.Location = new System.Drawing.Point(443, 145);
			this.txtNombre.MaxLength = 100;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(293, 28);
			this.txtNombre.TabIndex = 3;
			this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Click);
			this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
			// 
			// txtTelefono
			// 
			this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.ForeColor = System.Drawing.Color.Black;
			this.txtTelefono.Location = new System.Drawing.Point(443, 372);
			this.txtTelefono.MaxLength = 20;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(293, 28);
			this.txtTelefono.TabIndex = 5;
			this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Click);
			this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
			// 
			// txtEmail
			// 
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.Black;
			this.txtEmail.Location = new System.Drawing.Point(443, 427);
			this.txtEmail.MaxLength = 200;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(293, 28);
			this.txtEmail.TabIndex = 6;
			this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Click);
			this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
			// 
			// btRegresar
			// 
			this.btRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btRegresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRegresar.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btRegresar.Location = new System.Drawing.Point(13, 614);
			this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btRegresar.Name = "btRegresar";
			this.btRegresar.Size = new System.Drawing.Size(101, 31);
			this.btRegresar.TabIndex = 12;
			this.btRegresar.Text = "Regresar";
			this.btRegresar.UseVisualStyleBackColor = false;
			this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
			// 
			// lbCedula
			// 
			this.lbCedula.AutoSize = true;
			this.lbCedula.BackColor = System.Drawing.Color.Transparent;
			this.lbCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCedula.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbCedula.Location = new System.Drawing.Point(360, 93);
			this.lbCedula.Name = "lbCedula";
			this.lbCedula.Size = new System.Drawing.Size(67, 20);
			this.lbCedula.TabIndex = 16;
			this.lbCedula.Text = "Cédula:";
			this.lbCedula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbNombre
			// 
			this.lbNombre.AutoSize = true;
			this.lbNombre.BackColor = System.Drawing.Color.Transparent;
			this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNombre.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbNombre.Location = new System.Drawing.Point(355, 148);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(72, 20);
			this.lbNombre.TabIndex = 17;
			this.lbNombre.Text = "Nombre:";
			this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbBornDate
			// 
			this.lbBornDate.AutoSize = true;
			this.lbBornDate.BackColor = System.Drawing.Color.Transparent;
			this.lbBornDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBornDate.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbBornDate.Location = new System.Drawing.Point(258, 203);
			this.lbBornDate.Name = "lbBornDate";
			this.lbBornDate.Size = new System.Drawing.Size(169, 20);
			this.lbBornDate.TabIndex = 18;
			this.lbBornDate.Text = "Fecha de nacimiento:";
			this.lbBornDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTelefono
			// 
			this.lbTelefono.AutoSize = true;
			this.lbTelefono.BackColor = System.Drawing.Color.Transparent;
			this.lbTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTelefono.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbTelefono.Location = new System.Drawing.Point(352, 375);
			this.lbTelefono.Name = "lbTelefono";
			this.lbTelefono.Size = new System.Drawing.Size(75, 20);
			this.lbTelefono.TabIndex = 19;
			this.lbTelefono.Text = "Teléfono:";
			this.lbTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.BackColor = System.Drawing.Color.Transparent;
			this.lbEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmail.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbEmail.Location = new System.Drawing.Point(377, 430);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(50, 20);
			this.lbEmail.TabIndex = 20;
			this.lbEmail.Text = "Email:";
			this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbAddress
			// 
			this.lbAddress.AutoSize = true;
			this.lbAddress.BackColor = System.Drawing.Color.Transparent;
			this.lbAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddress.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbAddress.Location = new System.Drawing.Point(343, 255);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(84, 20);
			this.lbAddress.TabIndex = 21;
			this.lbAddress.Text = "Dirección:";
			this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbGenero
			// 
			this.lbGenero.AutoSize = true;
			this.lbGenero.BackColor = System.Drawing.Color.Transparent;
			this.lbGenero.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbGenero.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbGenero.Location = new System.Drawing.Point(357, 329);
			this.lbGenero.Name = "lbGenero";
			this.lbGenero.Size = new System.Drawing.Size(70, 20);
			this.lbGenero.TabIndex = 22;
			this.lbGenero.Text = "Género:";
			this.lbGenero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbRol
			// 
			this.lbRol.AutoSize = true;
			this.lbRol.BackColor = System.Drawing.Color.Transparent;
			this.lbRol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRol.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbRol.Location = new System.Drawing.Point(392, 485);
			this.lbRol.Name = "lbRol";
			this.lbRol.Size = new System.Drawing.Size(35, 20);
			this.lbRol.TabIndex = 23;
			this.lbRol.Text = "Rol:";
			this.lbRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPassword.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbPassword.Location = new System.Drawing.Point(328, 540);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(99, 20);
			this.lbPassword.TabIndex = 24;
			this.lbPassword.Text = "Contraseña:";
			this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.ForeColor = System.Drawing.Color.Black;
			this.txtAddress.Location = new System.Drawing.Point(443, 255);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(293, 56);
			this.txtAddress.TabIndex = 25;
			this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Click);
			this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
			// 
			// txtPassword
			// 
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.Color.Black;
			this.txtPassword.Location = new System.Drawing.Point(443, 537);
			this.txtPassword.MaxLength = 200;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(293, 28);
			this.txtPassword.TabIndex = 29;
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Click);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// cbRol
			// 
			this.cbRol.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRol.FormattingEnabled = true;
			this.cbRol.Location = new System.Drawing.Point(443, 481);
			this.cbRol.Name = "cbRol";
			this.cbRol.Size = new System.Drawing.Size(293, 29);
			this.cbRol.TabIndex = 30;
			this.cbRol.Enter += new System.EventHandler(this.cbRol_Click);
			this.cbRol.Leave += new System.EventHandler(this.cbRol_Leave);
			// 
			// rbMas
			// 
			this.rbMas.AutoSize = true;
			this.rbMas.ForeColor = System.Drawing.Color.LemonChiffon;
			this.rbMas.Location = new System.Drawing.Point(443, 330);
			this.rbMas.Name = "rbMas";
			this.rbMas.Size = new System.Drawing.Size(89, 20);
			this.rbMas.TabIndex = 26;
			this.rbMas.TabStop = true;
			this.rbMas.Text = "Masculino";
			this.rbMas.UseVisualStyleBackColor = true;
			// 
			// rbFem
			// 
			this.rbFem.AutoSize = true;
			this.rbFem.ForeColor = System.Drawing.Color.LemonChiffon;
			this.rbFem.Location = new System.Drawing.Point(555, 330);
			this.rbFem.Name = "rbFem";
			this.rbFem.Size = new System.Drawing.Size(88, 20);
			this.rbFem.TabIndex = 27;
			this.rbFem.TabStop = true;
			this.rbFem.Text = "Femenino";
			this.rbFem.UseVisualStyleBackColor = true;
			// 
			// dtpBornDate
			// 
			this.dtpBornDate.CalendarFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpBornDate.CustomFormat = "yyyy-MM-dd";
			this.dtpBornDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpBornDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpBornDate.Location = new System.Drawing.Point(443, 200);
			this.dtpBornDate.MaxDate = new System.DateTime(2029, 1, 1, 0, 0, 0, 0);
			this.dtpBornDate.MinDate = new System.DateTime(1919, 1, 1, 0, 0, 0, 0);
			this.dtpBornDate.Name = "dtpBornDate";
			this.dtpBornDate.Size = new System.Drawing.Size(138, 28);
			this.dtpBornDate.TabIndex = 31;
			this.dtpBornDate.Value = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
			// 
			// btBuscarPersonal
			// 
			this.btBuscarPersonal.BackColor = System.Drawing.Color.Transparent;
			this.btBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btBuscarPersonal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBuscarPersonal.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btBuscarPersonal.Location = new System.Drawing.Point(75, 428);
			this.btBuscarPersonal.Margin = new System.Windows.Forms.Padding(4);
			this.btBuscarPersonal.Name = "btBuscarPersonal";
			this.btBuscarPersonal.Size = new System.Drawing.Size(101, 31);
			this.btBuscarPersonal.TabIndex = 41;
			this.btBuscarPersonal.Text = "Buscar";
			this.btBuscarPersonal.UseVisualStyleBackColor = false;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.White;
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.ForeColor = System.Drawing.Color.Silver;
			this.txtBuscar.Location = new System.Drawing.Point(50, 384);
			this.txtBuscar.MaxLength = 9;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(152, 32);
			this.txtBuscar.TabIndex = 40;
			this.txtBuscar.Text = "Ej: 123456789";
			this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Click);
			this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
			// 
			// cbListaPersonal
			// 
			this.cbListaPersonal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbListaPersonal.FormattingEnabled = true;
			this.cbListaPersonal.Location = new System.Drawing.Point(16, 270);
			this.cbListaPersonal.Name = "cbListaPersonal";
			this.cbListaPersonal.Size = new System.Drawing.Size(224, 25);
			this.cbListaPersonal.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label1.Image = global::PY1_BD.Properties.Resources.Color;
			this.label1.Location = new System.Drawing.Point(38, 353);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 22);
			this.label1.TabIndex = 39;
			this.label1.Text = "Buscar por Cédula";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbList
			// 
			this.lbList.AutoSize = true;
			this.lbList.BackColor = System.Drawing.Color.Transparent;
			this.lbList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
			this.lbList.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbList.Image = global::PY1_BD.Properties.Resources.Color;
			this.lbList.Location = new System.Drawing.Point(51, 240);
			this.lbList.Name = "lbList";
			this.lbList.Size = new System.Drawing.Size(158, 22);
			this.lbList.TabIndex = 38;
			this.lbList.Text = "Lista de personal";
			this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// logoImg
			// 
			this.logoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.logoImg.BackColor = System.Drawing.Color.Transparent;
			this.logoImg.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.logoImg.Image = global::PY1_BD.Properties.Resources.Logo;
			this.logoImg.Location = new System.Drawing.Point(0, 0);
			this.logoImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logoImg.Name = "logoImg";
			this.logoImg.Size = new System.Drawing.Size(133, 118);
			this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoImg.TabIndex = 15;
			this.logoImg.TabStop = false;
			// 
			// btModificarPersonal
			// 
			this.btModificarPersonal.BackColor = System.Drawing.Color.Transparent;
			this.btModificarPersonal.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.btModificarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btModificarPersonal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btModificarPersonal.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btModificarPersonal.Location = new System.Drawing.Point(460, 605);
			this.btModificarPersonal.Margin = new System.Windows.Forms.Padding(4);
			this.btModificarPersonal.Name = "btModificarPersonal";
			this.btModificarPersonal.Size = new System.Drawing.Size(185, 46);
			this.btModificarPersonal.TabIndex = 9;
			this.btModificarPersonal.Text = "Modificar";
			this.btModificarPersonal.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox1.Location = new System.Drawing.Point(0, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 671);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// VistaModificarPersonal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(832, 664);
			this.Controls.Add(this.btBuscarPersonal);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbList);
			this.Controls.Add(this.cbListaPersonal);
			this.Controls.Add(this.dtpBornDate);
			this.Controls.Add(this.cbRol);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.rbFem);
			this.Controls.Add(this.rbMas);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.lbRol);
			this.Controls.Add(this.lbGenero);
			this.Controls.Add(this.lbAddress);
			this.Controls.Add(this.lbEmail);
			this.Controls.Add(this.lbTelefono);
			this.Controls.Add(this.lbBornDate);
			this.Controls.Add(this.lbNombre);
			this.Controls.Add(this.lbCedula);
			this.Controls.Add(this.logoImg);
			this.Controls.Add(this.btRegresar);
			this.Controls.Add(this.btModificarPersonal);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pictureBox1);
			this.Name = "VistaModificarPersonal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Modificar Personal";
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbTitle;
		public System.Windows.Forms.Button btModificarPersonal;
		public System.Windows.Forms.Button btRegresar;
		private System.Windows.Forms.PictureBox logoImg;
		private System.Windows.Forms.Label lbCedula;
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.Label lbBornDate;
		private System.Windows.Forms.Label lbTelefono;
		private System.Windows.Forms.Label lbEmail;
		public System.Windows.Forms.TextBox txtCedula;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtTelefono;
		public System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.Label lbGenero;
		private System.Windows.Forms.Label lbRol;
		private System.Windows.Forms.Label lbPassword;
		public System.Windows.Forms.TextBox txtPassword;
		public System.Windows.Forms.DateTimePicker dtpBornDate;
		public System.Windows.Forms.TextBox txtAddress;
		public System.Windows.Forms.ComboBox cbRol;
		public System.Windows.Forms.RadioButton rbMas;
		public System.Windows.Forms.RadioButton rbFem;
		public System.Windows.Forms.Button btBuscarPersonal;
		public System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbList;
		public System.Windows.Forms.ComboBox cbListaPersonal;
	}
}