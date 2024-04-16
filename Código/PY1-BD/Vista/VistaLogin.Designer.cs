namespace PY1_BD {
	partial class VistaLogin {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaLogin));
			this.lbLogin = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.lbPassword = new System.Windows.Forms.Label();
			this.lbCedula = new System.Windows.Forms.Label();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.btIngresar = new System.Windows.Forms.Button();
			this.btSalir = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbLogin
			// 
			this.lbLogin.AutoSize = true;
			this.lbLogin.BackColor = System.Drawing.Color.Transparent;
			this.lbLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLogin.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbLogin.Location = new System.Drawing.Point(99, 112);
			this.lbLogin.Margin = new System.Windows.Forms.Padding(0);
			this.lbLogin.Name = "lbLogin";
			this.lbLogin.Size = new System.Drawing.Size(227, 39);
			this.lbLogin.TabIndex = 5;
			this.lbLogin.Text = "Iniciar Sesión";
			this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1139, 629);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 2;
			this.button2.Text = "Salir";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// lbPassword
			// 
			this.lbPassword.AutoSize = true;
			this.lbPassword.BackColor = System.Drawing.Color.Transparent;
			this.lbPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPassword.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbPassword.Location = new System.Drawing.Point(109, 280);
			this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(114, 21);
			this.lbPassword.TabIndex = 4;
			this.lbPassword.Text = "Contraseña:";
			this.lbPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbCedula
			// 
			this.lbCedula.AutoSize = true;
			this.lbCedula.BackColor = System.Drawing.Color.Transparent;
			this.lbCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCedula.ForeColor = System.Drawing.Color.LemonChiffon;
			this.lbCedula.Location = new System.Drawing.Point(109, 184);
			this.lbCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbCedula.Name = "lbCedula";
			this.lbCedula.Size = new System.Drawing.Size(77, 21);
			this.lbCedula.TabIndex = 5;
			this.lbCedula.Text = "Cédula:";
			this.lbCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtCedula
			// 
			this.txtCedula.BackColor = System.Drawing.Color.White;
			this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCedula.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.txtCedula.Location = new System.Drawing.Point(106, 209);
			this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
			this.txtCedula.MaxLength = 9;
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(220, 28);
			this.txtCedula.TabIndex = 6;
			// 
			// txtContrasena
			// 
			this.txtContrasena.BackColor = System.Drawing.Color.White;
			this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasena.Location = new System.Drawing.Point(106, 305);
			this.txtContrasena.Margin = new System.Windows.Forms.Padding(4);
			this.txtContrasena.MaxLength = 50;
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.Size = new System.Drawing.Size(220, 26);
			this.txtContrasena.TabIndex = 7;
			// 
			// btIngresar
			// 
			this.btIngresar.BackColor = System.Drawing.Color.Transparent;
			this.btIngresar.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.btIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btIngresar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btIngresar.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btIngresar.Location = new System.Drawing.Point(106, 390);
			this.btIngresar.Margin = new System.Windows.Forms.Padding(4);
			this.btIngresar.Name = "btIngresar";
			this.btIngresar.Size = new System.Drawing.Size(220, 46);
			this.btIngresar.TabIndex = 8;
			this.btIngresar.Text = "Ingresar";
			this.btIngresar.UseVisualStyleBackColor = false;
			// 
			// btSalir
			// 
			this.btSalir.BackColor = System.Drawing.Color.Transparent;
			this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btSalir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btSalir.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btSalir.Location = new System.Drawing.Point(580, 481);
			this.btSalir.Margin = new System.Windows.Forms.Padding(4);
			this.btSalir.Name = "btSalir";
			this.btSalir.Size = new System.Drawing.Size(101, 31);
			this.btSalir.TabIndex = 11;
			this.btSalir.Text = "Salir";
			this.btSalir.UseVisualStyleBackColor = false;
			this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox1.Image = global::PY1_BD.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(392, -7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(306, 532);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// VistaLogin
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(697, 525);
			this.Controls.Add(this.btSalir);
			this.Controls.Add(this.btIngresar);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.lbCedula);
			this.Controls.Add(this.lbPassword);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lbLogin);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "VistaLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hotel Karpas";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.Label lbCedula;
		public System.Windows.Forms.TextBox txtCedula;
		public System.Windows.Forms.TextBox txtContrasena;
		public System.Windows.Forms.Button btIngresar;
		public System.Windows.Forms.Button btSalir;
		private System.Windows.Forms.Label lbLogin;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

