namespace PY1_BD.Vista {
	partial class VistaAgregarClientes {
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
			this.txtPais = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btRegresar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.logoImg = new System.Windows.Forms.PictureBox();
			this.btAgregar = new System.Windows.Forms.Button();
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
			this.lbTitle.Location = new System.Drawing.Point(398, 32);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(276, 27);
			this.lbTitle.TabIndex = 5;
			this.lbTitle.Text = "Información del Cliente";
			// 
			// txtCedula
			// 
			this.txtCedula.BackColor = System.Drawing.Color.White;
			this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.ForeColor = System.Drawing.Color.Silver;
			this.txtCedula.Location = new System.Drawing.Point(414, 122);
			this.txtCedula.MaxLength = 9;
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(312, 28);
			this.txtCedula.TabIndex = 2;
			this.txtCedula.Text = "Ej: 123456789";
			this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Click);
			this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.ForeColor = System.Drawing.Color.Silver;
			this.txtNombre.Location = new System.Drawing.Point(414, 177);
			this.txtNombre.MaxLength = 100;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(312, 28);
			this.txtNombre.TabIndex = 3;
			this.txtNombre.Text = "Ej: Eyden Su Díaz";
			this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Click);
			this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
			// 
			// txtPais
			// 
			this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPais.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPais.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPais.ForeColor = System.Drawing.Color.Silver;
			this.txtPais.Location = new System.Drawing.Point(414, 232);
			this.txtPais.MaxLength = 60;
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(312, 28);
			this.txtPais.TabIndex = 4;
			this.txtPais.Text = "Ej: Costa Rica";
			this.txtPais.Enter += new System.EventHandler(this.txtPais_Click);
			this.txtPais.Leave += new System.EventHandler(this.txtPais_Leave);
			// 
			// txtTelefono
			// 
			this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.ForeColor = System.Drawing.Color.Silver;
			this.txtTelefono.Location = new System.Drawing.Point(414, 287);
			this.txtTelefono.MaxLength = 20;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(312, 28);
			this.txtTelefono.TabIndex = 5;
			this.txtTelefono.Text = "Ej: 88888888";
			this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Click);
			this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
			// 
			// txtEmail
			// 
			this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.Silver;
			this.txtEmail.Location = new System.Drawing.Point(414, 342);
			this.txtEmail.MaxLength = 200;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(312, 28);
			this.txtEmail.TabIndex = 6;
			this.txtEmail.Text = "Ej: ejemplo@gmail.com";
			this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Click);
			this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label1.Location = new System.Drawing.Point(324, 125);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 20);
			this.label1.TabIndex = 16;
			this.label1.Text = "Cédula:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label2.Location = new System.Drawing.Point(324, 180);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Nombre:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label3.Location = new System.Drawing.Point(324, 235);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "País Natal:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label4.Location = new System.Drawing.Point(324, 290);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 20);
			this.label4.TabIndex = 19;
			this.label4.Text = "Teléfono:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.LemonChiffon;
			this.label5.Location = new System.Drawing.Point(324, 345);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 20);
			this.label5.TabIndex = 20;
			this.label5.Text = "Email:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// btAgregar
			// 
			this.btAgregar.BackColor = System.Drawing.Color.Transparent;
			this.btAgregar.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAgregar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAgregar.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btAgregar.Location = new System.Drawing.Point(443, 447);
			this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btAgregar.Name = "btAgregar";
			this.btAgregar.Size = new System.Drawing.Size(185, 46);
			this.btAgregar.TabIndex = 9;
			this.btAgregar.Text = "Agregar";
			this.btAgregar.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox1.Location = new System.Drawing.Point(0, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 548);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// VistaAgregarClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(800, 537);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.logoImg);
			this.Controls.Add(this.btRegresar);
			this.Controls.Add(this.btAgregar);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtPais);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.pictureBox1);
			this.Name = "VistaAgregarClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Clientes";
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbTitle;
		public System.Windows.Forms.Button btAgregar;
		public System.Windows.Forms.Button btRegresar;
		private System.Windows.Forms.PictureBox logoImg;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtCedula;
		public System.Windows.Forms.TextBox txtNombre;
		public System.Windows.Forms.TextBox txtPais;
		public System.Windows.Forms.TextBox txtTelefono;
		public System.Windows.Forms.TextBox txtEmail;
	}
}