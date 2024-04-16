namespace PY1_BD.Vista {
    partial class VistaReporteria {
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.botonReporteriaReservasIngresar = new System.Windows.Forms.Button();
			this.textReporteriaCliente = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hOTELKARPASDataSet1 = new PY1_BD.HOTELKARPASDataSet1();
			this.botonAtras = new System.Windows.Forms.Button();
			this.botonReporteriaReservas = new System.Windows.Forms.Button();
			this.botonReporteriaCancelar = new System.Windows.Forms.Button();
			this.botonReporteriaTopClient = new System.Windows.Forms.Button();
			this.reservaTableAdapter = new PY1_BD.HOTELKARPASDataSet1TableAdapters.ReservaTableAdapter();
			this.reservaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.hOTELKARPASDataSet11 = new PY1_BD.HOTELKARPASDataSet1();
			this.dataTablaReporteria = new System.Windows.Forms.DataGridView();
			this.textReporteriaHabitacion = new System.Windows.Forms.TextBox();
			this.botonReporteriaHabitacionIngresar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.logoImg = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btLogins = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTablaReporteria)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(25, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Todas las reservas";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Info;
			this.label2.Location = new System.Drawing.Point(933, 229);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(257, 34);
			this.label2.TabIndex = 2;
			this.label2.Text = "Reservas por cliente";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Info;
			this.label3.Location = new System.Drawing.Point(15, 304);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(359, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cancelaciones Realizadas";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(25, 421);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(315, 34);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cliente mas frecuente";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// botonReporteriaReservasIngresar
			// 
			this.botonReporteriaReservasIngresar.BackColor = System.Drawing.Color.LemonChiffon;
			this.botonReporteriaReservasIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonReporteriaReservasIngresar.Location = new System.Drawing.Point(939, 314);
			this.botonReporteriaReservasIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botonReporteriaReservasIngresar.Name = "botonReporteriaReservasIngresar";
			this.botonReporteriaReservasIngresar.Size = new System.Drawing.Size(49, 41);
			this.botonReporteriaReservasIngresar.TabIndex = 9;
			this.botonReporteriaReservasIngresar.Text = "✔";
			this.botonReporteriaReservasIngresar.UseVisualStyleBackColor = false;
			// 
			// textReporteriaCliente
			// 
			this.textReporteriaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textReporteriaCliente.Location = new System.Drawing.Point(1007, 310);
			this.textReporteriaCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textReporteriaCliente.Multiline = true;
			this.textReporteriaCliente.Name = "textReporteriaCliente";
			this.textReporteriaCliente.Size = new System.Drawing.Size(199, 41);
			this.textReporteriaCliente.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Info;
			this.label5.Location = new System.Drawing.Point(967, 263);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(296, 31);
			this.label5.TabIndex = 11;
			this.label5.Text = "Ingrese la cedula del cliente:";
			// 
			// reservaBindingSource
			// 
			this.reservaBindingSource.DataMember = "Reserva";
			this.reservaBindingSource.DataSource = this.hOTELKARPASDataSet1;
			// 
			// hOTELKARPASDataSet1
			// 
			this.hOTELKARPASDataSet1.DataSetName = "HOTELKARPASDataSet1";
			this.hOTELKARPASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// botonAtras
			// 
			this.botonAtras.BackColor = System.Drawing.Color.Turquoise;
			this.botonAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonAtras.Location = new System.Drawing.Point(1176, 882);
			this.botonAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botonAtras.Name = "botonAtras";
			this.botonAtras.Size = new System.Drawing.Size(125, 34);
			this.botonAtras.TabIndex = 14;
			this.botonAtras.Text = "Atras";
			this.botonAtras.UseVisualStyleBackColor = false;
			this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
			// 
			// botonReporteriaReservas
			// 
			this.botonReporteriaReservas.BackColor = System.Drawing.Color.LemonChiffon;
			this.botonReporteriaReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonReporteriaReservas.Location = new System.Drawing.Point(100, 244);
			this.botonReporteriaReservas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botonReporteriaReservas.Name = "botonReporteriaReservas";
			this.botonReporteriaReservas.Size = new System.Drawing.Size(129, 32);
			this.botonReporteriaReservas.TabIndex = 10;
			this.botonReporteriaReservas.Text = "Ver";
			this.botonReporteriaReservas.UseVisualStyleBackColor = false;
			// 
			// botonReporteriaCancelar
			// 
			this.botonReporteriaCancelar.BackColor = System.Drawing.Color.LemonChiffon;
			this.botonReporteriaCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonReporteriaCancelar.Location = new System.Drawing.Point(100, 364);
			this.botonReporteriaCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botonReporteriaCancelar.Name = "botonReporteriaCancelar";
			this.botonReporteriaCancelar.Size = new System.Drawing.Size(125, 34);
			this.botonReporteriaCancelar.TabIndex = 16;
			this.botonReporteriaCancelar.Text = "Ver";
			this.botonReporteriaCancelar.UseVisualStyleBackColor = false;
			// 
			// botonReporteriaTopClient
			// 
			this.botonReporteriaTopClient.BackColor = System.Drawing.Color.LemonChiffon;
			this.botonReporteriaTopClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonReporteriaTopClient.Location = new System.Drawing.Point(100, 458);
			this.botonReporteriaTopClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botonReporteriaTopClient.Name = "botonReporteriaTopClient";
			this.botonReporteriaTopClient.Size = new System.Drawing.Size(125, 32);
			this.botonReporteriaTopClient.TabIndex = 17;
			this.botonReporteriaTopClient.Text = "Ver";
			this.botonReporteriaTopClient.UseVisualStyleBackColor = false;
			// 
			// reservaTableAdapter
			// 
			this.reservaTableAdapter.ClearBeforeFill = true;
			// 
			// reservaBindingSource1
			// 
			this.reservaBindingSource1.DataMember = "Reserva";
			this.reservaBindingSource1.DataSource = this.hOTELKARPASDataSet11;
			// 
			// hOTELKARPASDataSet11
			// 
			this.hOTELKARPASDataSet11.DataSetName = "HOTELKARPASDataSet1";
			this.hOTELKARPASDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataTablaReporteria
			// 
			this.dataTablaReporteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataTablaReporteria.Location = new System.Drawing.Point(60, 524);
			this.dataTablaReporteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataTablaReporteria.Name = "dataTablaReporteria";
			this.dataTablaReporteria.RowHeadersWidth = 51;
			this.dataTablaReporteria.RowTemplate.Height = 24;
			this.dataTablaReporteria.Size = new System.Drawing.Size(1165, 336);
			this.dataTablaReporteria.TabIndex = 18;
			// 
			// textReporteriaHabitacion
			// 
			this.textReporteriaHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textReporteriaHabitacion.Location = new System.Drawing.Point(1007, 418);
			this.textReporteriaHabitacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textReporteriaHabitacion.Multiline = true;
			this.textReporteriaHabitacion.Name = "textReporteriaHabitacion";
			this.textReporteriaHabitacion.Size = new System.Drawing.Size(199, 42);
			this.textReporteriaHabitacion.TabIndex = 21;
			// 
			// botonReporteriaHabitacionIngresar
			// 
			this.botonReporteriaHabitacionIngresar.BackColor = System.Drawing.Color.LemonChiffon;
			this.botonReporteriaHabitacionIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonReporteriaHabitacionIngresar.Location = new System.Drawing.Point(939, 425);
			this.botonReporteriaHabitacionIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botonReporteriaHabitacionIngresar.Name = "botonReporteriaHabitacionIngresar";
			this.botonReporteriaHabitacionIngresar.Size = new System.Drawing.Size(48, 41);
			this.botonReporteriaHabitacionIngresar.TabIndex = 20;
			this.botonReporteriaHabitacionIngresar.Text = "✔";
			this.botonReporteriaHabitacionIngresar.UseVisualStyleBackColor = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.Info;
			this.label6.Location = new System.Drawing.Point(933, 382);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(399, 34);
			this.label6.TabIndex = 19;
			this.label6.Text = "Ingrese la Habitacion a buscar";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.Info;
			this.label7.Image = global::PY1_BD.Properties.Resources.Color;
			this.label7.Location = new System.Drawing.Point(531, 118);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(240, 39);
			this.label7.TabIndex = 22;
			this.label7.Text = "Reporteria";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// logoImg
			// 
			this.logoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.logoImg.BackColor = System.Drawing.Color.Transparent;
			this.logoImg.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.logoImg.Image = global::PY1_BD.Properties.Resources.Logo;
			this.logoImg.Location = new System.Drawing.Point(447, -23);
			this.logoImg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.logoImg.Name = "logoImg";
			this.logoImg.Size = new System.Drawing.Size(401, 181);
			this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoImg.TabIndex = 23;
			this.logoImg.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox1.Image = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox1.Location = new System.Drawing.Point(-79, -7);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1464, 180);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox2.Image = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox2.Location = new System.Drawing.Point(548, 118);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(199, 527);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 25;
			this.pictureBox2.TabStop = false;
			// 
			// btLogins
			// 
			this.btLogins.BackColor = System.Drawing.Color.LemonChiffon;
			this.btLogins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLogins.Location = new System.Drawing.Point(367, 244);
			this.btLogins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btLogins.Name = "btLogins";
			this.btLogins.Size = new System.Drawing.Size(129, 32);
			this.btLogins.TabIndex = 27;
			this.btLogins.Text = "Ver";
			this.btLogins.UseVisualStyleBackColor = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Info;
			this.label8.Location = new System.Drawing.Point(381, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 34);
			this.label8.TabIndex = 26;
			this.label8.Text = "Logins";
			// 
			// VistaReporteria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1316, 919);
			this.Controls.Add(this.btLogins);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.logoImg);
			this.Controls.Add(this.textReporteriaHabitacion);
			this.Controls.Add(this.botonReporteriaHabitacionIngresar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataTablaReporteria);
			this.Controls.Add(this.botonReporteriaTopClient);
			this.Controls.Add(this.botonReporteriaCancelar);
			this.Controls.Add(this.botonReporteriaReservas);
			this.Controls.Add(this.botonAtras);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textReporteriaCliente);
			this.Controls.Add(this.botonReporteriaReservasIngresar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "VistaReporteria";
			this.Text = "Hotel Karpas";
			this.Load += new System.EventHandler(this.VistaReporteria_Load);
			((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTablaReporteria)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button botonReporteriaReservasIngresar;
        public System.Windows.Forms.TextBox textReporteriaCliente;
        private System.Windows.Forms.Label label5;
        private HOTELKARPASDataSet1 hOTELKARPASDataSet1;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private HOTELKARPASDataSet1TableAdapters.ReservaTableAdapter reservaTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn temporadaDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button botonAtras;
        public System.Windows.Forms.Button botonReporteriaReservas;
        public System.Windows.Forms.Button botonReporteriaCancelar;
        public System.Windows.Forms.Button botonReporteriaTopClient;
        private HOTELKARPASDataSet1 hOTELKARPASDataSet11;
        private System.Windows.Forms.BindingSource reservaBindingSource1;
        public System.Windows.Forms.DataGridView dataTablaReporteria;
        public System.Windows.Forms.TextBox textReporteriaHabitacion;
        public System.Windows.Forms.Button botonReporteriaHabitacionIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.Button btLogins;
		private System.Windows.Forms.Label label8;
	}
}