namespace PY1_BD.Vista
{
    partial class VistaAgregarReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.comboBoxHabitacion = new System.Windows.Forms.ComboBox();
            this.comboBoxDescuntos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.botonRegresar = new System.Windows.Forms.Button();
            this.monthCalendario = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.botonRegistrarCliente = new System.Windows.Forms.Button();
            this.botonChechIn = new System.Windows.Forms.Button();
            this.textCheckIn = new System.Windows.Forms.TextBox();
            this.textCheckOut = new System.Windows.Forms.TextBox();
            this.botonCheckOut = new System.Windows.Forms.Button();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            this.botonVerPrecio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.botonResgitrarInformacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(568, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar reservas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(603, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(59, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccionar check-in y Check-out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(586, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ver descuentos disponibles:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(645, 136);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(140, 20);
            this.textIdentificacion.TabIndex = 10;
            this.textIdentificacion.Tag = "";
            this.textIdentificacion.TextChanged += new System.EventHandler(this.textIdentificacion_TextChanged);
            // 
            // comboBoxHabitacion
            // 
            this.comboBoxHabitacion.FormattingEnabled = true;
            this.comboBoxHabitacion.Location = new System.Drawing.Point(620, 416);
            this.comboBoxHabitacion.Name = "comboBoxHabitacion";
            this.comboBoxHabitacion.Size = new System.Drawing.Size(193, 21);
            this.comboBoxHabitacion.TabIndex = 12;
            // 
            // comboBoxDescuntos
            // 
            this.comboBoxDescuntos.FormattingEnabled = true;
            this.comboBoxDescuntos.Items.AddRange(new object[] {
            "5% de descuento.",
            "10% de descuento.",
            "Noche gratis.",
            "No aplicar descuento."});
            this.comboBoxDescuntos.Location = new System.Drawing.Point(644, 296);
            this.comboBoxDescuntos.Name = "comboBoxDescuntos";
            this.comboBoxDescuntos.Size = new System.Drawing.Size(141, 21);
            this.comboBoxDescuntos.TabIndex = 13;
            this.comboBoxDescuntos.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescuntos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label7.Location = new System.Drawing.Point(616, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Registrar informacion";
            // 
            // botonRegresar
            // 
            this.botonRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegresar.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botonRegresar.Location = new System.Drawing.Point(12, 708);
            this.botonRegresar.Name = "botonRegresar";
            this.botonRegresar.Size = new System.Drawing.Size(107, 41);
            this.botonRegresar.TabIndex = 24;
            this.botonRegresar.Text = "Regresar";
            this.botonRegresar.UseVisualStyleBackColor = false;
            this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
            // 
            // monthCalendario
            // 
            this.monthCalendario.Location = new System.Drawing.Point(120, 285);
            this.monthCalendario.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.monthCalendario.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.monthCalendario.Name = "monthCalendario";
            this.monthCalendario.TabIndex = 25;
            this.monthCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendario_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label5.Location = new System.Drawing.Point(618, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Seleccione habitacion:";
            // 
            // botonRegistrarCliente
            // 
            this.botonRegistrarCliente.BackColor = System.Drawing.Color.Black;
            this.botonRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarCliente.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botonRegistrarCliente.Location = new System.Drawing.Point(665, 177);
            this.botonRegistrarCliente.Name = "botonRegistrarCliente";
            this.botonRegistrarCliente.Size = new System.Drawing.Size(107, 37);
            this.botonRegistrarCliente.TabIndex = 26;
            this.botonRegistrarCliente.Text = "Seleccionar";
            this.botonRegistrarCliente.UseVisualStyleBackColor = false;
            // 
            // botonChechIn
            // 
            this.botonChechIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonChechIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonChechIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonChechIn.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botonChechIn.Location = new System.Drawing.Point(313, 477);
            this.botonChechIn.Name = "botonChechIn";
            this.botonChechIn.Size = new System.Drawing.Size(107, 25);
            this.botonChechIn.TabIndex = 32;
            this.botonChechIn.Text = "Check-In\r\n";
            this.botonChechIn.UseVisualStyleBackColor = false;
            // 
            // textCheckIn
            // 
            this.textCheckIn.Location = new System.Drawing.Point(120, 477);
            this.textCheckIn.Name = "textCheckIn";
            this.textCheckIn.Size = new System.Drawing.Size(162, 20);
            this.textCheckIn.TabIndex = 33;
            this.textCheckIn.Tag = "";
            // 
            // textCheckOut
            // 
            this.textCheckOut.Location = new System.Drawing.Point(120, 574);
            this.textCheckOut.Name = "textCheckOut";
            this.textCheckOut.Size = new System.Drawing.Size(162, 20);
            this.textCheckOut.TabIndex = 34;
            this.textCheckOut.Tag = "";
            // 
            // botonCheckOut
            // 
            this.botonCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCheckOut.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botonCheckOut.Location = new System.Drawing.Point(313, 574);
            this.botonCheckOut.Name = "botonCheckOut";
            this.botonCheckOut.Size = new System.Drawing.Size(107, 25);
            this.botonCheckOut.TabIndex = 35;
            this.botonCheckOut.Text = "Check-Out\r\n";
            this.botonCheckOut.UseVisualStyleBackColor = false;
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.AutoSize = true;
            this.labelPrecioTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioTotal.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelPrecioTotal.Location = new System.Drawing.Point(652, 475);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(120, 23);
            this.labelPrecioTotal.TabIndex = 36;
            this.labelPrecioTotal.Text = "Precio total:\r\n";
            this.labelPrecioTotal.Click += new System.EventHandler(this.labelPrecioTotal_Click);
            // 
            // botonVerPrecio
            // 
            this.botonVerPrecio.BackColor = System.Drawing.Color.Black;
            this.botonVerPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerPrecio.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botonVerPrecio.Location = new System.Drawing.Point(639, 517);
            this.botonVerPrecio.Name = "botonVerPrecio";
            this.botonVerPrecio.Size = new System.Drawing.Size(146, 27);
            this.botonVerPrecio.TabIndex = 37;
            this.botonVerPrecio.Text = "Ver precio";
            this.botonVerPrecio.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 784);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // logoImg
            // 
            this.logoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoImg.BackColor = System.Drawing.Color.Transparent;
            this.logoImg.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
            this.logoImg.Image = global::PY1_BD.Properties.Resources.Logo;
            this.logoImg.Location = new System.Drawing.Point(-5, -42);
            this.logoImg.Margin = new System.Windows.Forms.Padding(2);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(501, 279);
            this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImg.TabIndex = 39;
            this.logoImg.TabStop = false;
            // 
            // botonResgitrarInformacion
            // 
            this.botonResgitrarInformacion.BackColor = System.Drawing.Color.Black;
            this.botonResgitrarInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonResgitrarInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.botonResgitrarInformacion.ForeColor = System.Drawing.Color.LemonChiffon;
            this.botonResgitrarInformacion.Location = new System.Drawing.Point(665, 643);
            this.botonResgitrarInformacion.Name = "botonResgitrarInformacion";
            this.botonResgitrarInformacion.Size = new System.Drawing.Size(86, 33);
            this.botonResgitrarInformacion.TabIndex = 40;
            this.botonResgitrarInformacion.Text = "Registrar";
            this.botonResgitrarInformacion.UseVisualStyleBackColor = false;
            // 
            // VistaAgregarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.botonResgitrarInformacion);
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.botonVerPrecio);
            this.Controls.Add(this.labelPrecioTotal);
            this.Controls.Add(this.botonCheckOut);
            this.Controls.Add(this.textCheckOut);
            this.Controls.Add(this.textCheckIn);
            this.Controls.Add(this.botonChechIn);
            this.Controls.Add(this.botonRegistrarCliente);
            this.Controls.Add(this.monthCalendario);
            this.Controls.Add(this.botonRegresar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDescuntos);
            this.Controls.Add(this.comboBoxHabitacion);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "VistaAgregarReservas";
            this.Text = "VistaAgregarReservas";
            this.Load += new System.EventHandler(this.VistaAgregarReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textIdentificacion;
        public System.Windows.Forms.ComboBox comboBoxHabitacion;
        public System.Windows.Forms.ComboBox comboBoxDescuntos;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button botonRegresar;
        public System.Windows.Forms.MonthCalendar monthCalendario;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button botonRegistrarCliente;
        public System.Windows.Forms.Button botonChechIn;
        public System.Windows.Forms.TextBox textCheckIn;
        public System.Windows.Forms.TextBox textCheckOut;
        public System.Windows.Forms.Button botonCheckOut;
        public System.Windows.Forms.Label labelPrecioTotal;
        public System.Windows.Forms.Button botonVerPrecio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logoImg;
        public System.Windows.Forms.Button botonResgitrarInformacion;
    }
}