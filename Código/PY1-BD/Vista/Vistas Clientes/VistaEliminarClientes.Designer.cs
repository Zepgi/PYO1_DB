namespace PY1_BD.Vista {
	partial class VistaEliminarClientes {
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
			this.bgImg = new System.Windows.Forms.PictureBox();
			this.lbTitle = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btEliminarCliente = new System.Windows.Forms.Button();
			this.btRegresar = new System.Windows.Forms.Button();
			this.logoImg = new System.Windows.Forms.PictureBox();
			this.lbCedula = new System.Windows.Forms.Label();
			this.lbNombre = new System.Windows.Forms.Label();
			this.lbPais = new System.Windows.Forms.Label();
			this.lbTelefono = new System.Windows.Forms.Label();
			this.lbEmail = new System.Windows.Forms.Label();
			this.cbListaClientes = new System.Windows.Forms.ComboBox();
			this.lbList = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btBuscarCliente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bgImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
			this.SuspendLayout();
			// 
			// bgImg
			// 
			this.bgImg.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.bgImg.Location = new System.Drawing.Point(0, -5);
			this.bgImg.Name = "bgImg";
			this.bgImg.Size = new System.Drawing.Size(255, 548);
			this.bgImg.TabIndex = 0;
			this.bgImg.TabStop = false;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbTitle.Location = new System.Drawing.Point(398, 32);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(276, 27);
			this.lbTitle.TabIndex = 5;
			this.lbTitle.Text = "Información del Cliente";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCedula
			// 
			this.txtCedula.BackColor = System.Drawing.Color.White;
			this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.ForeColor = System.Drawing.Color.Black;
			this.txtCedula.Location = new System.Drawing.Point(414, 122);
			this.txtCedula.MaxLength = 9;
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(312, 28);
			this.txtCedula.TabIndex = 2;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.Black;
			this.txtNombre.Location = new System.Drawing.Point(414, 177);
			this.txtNombre.MaxLength = 100;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(312, 28);
			this.txtNombre.TabIndex = 3;
			// 
			// txtPais
			// 
			this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPais.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPais.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPais.ForeColor = System.Drawing.Color.Black;
			this.txtPais.Location = new System.Drawing.Point(414, 232);
			this.txtPais.MaxLength = 60;
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(312, 28);
			this.txtPais.TabIndex = 4;
			// 
			// txtTelefono
			// 
			this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.ForeColor = System.Drawing.Color.Black;
			this.txtTelefono.Location = new System.Drawing.Point(414, 287);
			this.txtTelefono.MaxLength = 20;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(312, 28);
			this.txtTelefono.TabIndex = 5;
			// 
			// txtEmail
			// 
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.Black;
			this.txtEmail.Location = new System.Drawing.Point(414, 342);
			this.txtEmail.MaxLength = 200;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(312, 28);
			this.txtEmail.TabIndex = 6;
			// 
			// btEliminarCliente
			// 
			this.btEliminarCliente.BackColor = System.Drawing.Color.Transparent;
			this.btEliminarCliente.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.btEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btEliminarCliente.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btEliminarCliente.Location = new System.Drawing.Point(443, 447);
			this.btEliminarCliente.Margin = new System.Windows.Forms.Padding(4);
			this.btEliminarCliente.Name = "btEliminarCliente";
			this.btEliminarCliente.Size = new System.Drawing.Size(185, 46);
			this.btEliminarCliente.TabIndex = 9;
			this.btEliminarCliente.Text = "Eliminar";
			this.btEliminarCliente.UseVisualStyleBackColor = false;
			// 
			// btRegresar
			// 
			this.btRegresar.BackColor = System.Drawing.Color.Transparent;
			this.btRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btRegresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRegresar.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btRegresar.Location = new System.Drawing.Point(13, 493);
			this.btRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.btRegresar.Name = "btRegresar";
			this.btRegresar.Size = new System.Drawing.Size(101, 31);
			this.btRegresar.TabIndex = 12;
			this.btRegresar.Text = "Regresar";
			this.btRegresar.UseVisualStyleBackColor = false;
			this.btRegresar.Click += new System.EventHandler(this.btRegresar_Click);
			// 
			// logoImg
			// 
			this.logoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.logoImg.BackColor = System.Drawing.Color.Transparent;
			this.logoImg.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.logoImg.Image = global::PY1_BD.Properties.Resources.Logo;
			this.logoImg.Location = new System.Drawing.Point(1, 1);
			this.logoImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.logoImg.Name = "logoImg";
			this.logoImg.Size = new System.Drawing.Size(133, 118);
			this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoImg.TabIndex = 15;
			this.logoImg.TabStop = false;
			// 
			// lbCedula
			// 
			this.lbCedula.AutoSize = true;
			this.lbCedula.BackColor = System.Drawing.Color.Transparent;
			this.lbCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCedula.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbCedula.Location = new System.Drawing.Point(324, 125);
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
			this.lbNombre.Location = new System.Drawing.Point(324, 180);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(72, 20);
			this.lbNombre.TabIndex = 17;
			this.lbNombre.Text = "Nombre:";
			this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbPais
			// 
			this.lbPais.AutoSize = true;
			this.lbPais.BackColor = System.Drawing.Color.Transparent;
			this.lbPais.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPais.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbPais.Location = new System.Drawing.Point(324, 235);
			this.lbPais.Name = "lbPais";
			this.lbPais.Size = new System.Drawing.Size(84, 20);
			this.lbPais.TabIndex = 18;
			this.lbPais.Text = "País Natal:";
			this.lbPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbTelefono
			// 
			this.lbTelefono.AutoSize = true;
			this.lbTelefono.BackColor = System.Drawing.Color.Transparent;
			this.lbTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTelefono.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbTelefono.Location = new System.Drawing.Point(324, 290);
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
			this.lbEmail.Location = new System.Drawing.Point(324, 345);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(50, 20);
			this.lbEmail.TabIndex = 20;
			this.lbEmail.Text = "Email:";
			this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbListaClientes
			// 
			this.cbListaClientes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbListaClientes.FormattingEnabled = true;
			this.cbListaClientes.Location = new System.Drawing.Point(15, 187);
			this.cbListaClientes.Name = "cbListaClientes";
			this.cbListaClientes.Size = new System.Drawing.Size(224, 25);
			this.cbListaClientes.TabIndex = 21;
			// 
			// lbList
			// 
			this.lbList.AutoSize = true;
			this.lbList.BackColor = System.Drawing.Color.Transparent;
			this.lbList.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
			this.lbList.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbList.Image = global::PY1_BD.Properties.Resources.Color;
			this.lbList.Location = new System.Drawing.Point(50, 157);
			this.lbList.Name = "lbList";
			this.lbList.Size = new System.Drawing.Size(149, 22);
			this.lbList.TabIndex = 22;
			this.lbList.Text = "Lista de clientes";
			this.lbList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label1.Image = global::PY1_BD.Properties.Resources.Color;
			this.label1.Location = new System.Drawing.Point(37, 270);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 22);
			this.label1.TabIndex = 23;
			this.label1.Text = "Buscar por Cédula";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.White;
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.ForeColor = System.Drawing.Color.Silver;
			this.txtBuscar.Location = new System.Drawing.Point(49, 301);
			this.txtBuscar.MaxLength = 9;
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(152, 32);
			this.txtBuscar.TabIndex = 24;
			this.txtBuscar.Text = "Ej: 123456789";
			this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Click);
			this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
			// 
			// btBuscarCliente
			// 
			this.btBuscarCliente.BackColor = System.Drawing.Color.Transparent;
			this.btBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btBuscarCliente.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btBuscarCliente.Location = new System.Drawing.Point(74, 345);
			this.btBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
			this.btBuscarCliente.Name = "btBuscarCliente";
			this.btBuscarCliente.Size = new System.Drawing.Size(101, 31);
			this.btBuscarCliente.TabIndex = 25;
			this.btBuscarCliente.Text = "Buscar";
			this.btBuscarCliente.UseVisualStyleBackColor = false;
			// 
			// VistaEliminarClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(800, 537);
			this.Controls.Add(this.btBuscarCliente);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbList);
			this.Controls.Add(this.cbListaClientes);
			this.Controls.Add(this.lbEmail);
			this.Controls.Add(this.lbTelefono);
			this.Controls.Add(this.lbPais);
			this.Controls.Add(this.lbNombre);
			this.Controls.Add(this.lbCedula);
			this.Controls.Add(this.logoImg);
			this.Controls.Add(this.btRegresar);
			this.Controls.Add(this.btEliminarCliente);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtPais);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.bgImg);
			this.Name = "VistaEliminarClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Eliminar Clientes";
			((System.ComponentModel.ISupportInitialize)(this.bgImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox bgImg;
		private System.Windows.Forms.Label lbTitle;
		public System.Windows.Forms.Button btEliminarCliente;
		public System.Windows.Forms.Button btRegresar;
		private System.Windows.Forms.PictureBox logoImg;
		private System.Windows.Forms.Label lbCedula;
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.Label lbPais;
		private System.Windows.Forms.Label lbTelefono;
		private System.Windows.Forms.Label lbEmail;
		public System.Windows.Forms.TextBox txtCedula;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtPais;
		public System.Windows.Forms.TextBox txtTelefono;
		public System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lbList;
		public System.Windows.Forms.ComboBox cbListaClientes;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txtBuscar;
		public System.Windows.Forms.Button btBuscarCliente;
	}
}