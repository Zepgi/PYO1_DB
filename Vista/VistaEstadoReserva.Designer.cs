namespace PY1_BD.Vista
{
    partial class VistaEstadoReserva
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
            this.button1 = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.comboBoxVerReservas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(653, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 44;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.Color.SaddleBrown;
            this.botonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.ForeColor = System.Drawing.Color.White;
            this.botonBorrar.Location = new System.Drawing.Point(352, 314);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(69, 41);
            this.botonBorrar.TabIndex = 43;
            this.botonBorrar.Text = "Aplicar";
            this.botonBorrar.UseVisualStyleBackColor = false;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // comboBoxVerReservas
            // 
            this.comboBoxVerReservas.FormattingEnabled = true;
            this.comboBoxVerReservas.Location = new System.Drawing.Point(300, 186);
            this.comboBoxVerReservas.Name = "comboBoxVerReservas";
            this.comboBoxVerReservas.Size = new System.Drawing.Size(171, 21);
            this.comboBoxVerReservas.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SaddleBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Ingrese numero de reserva a modicifar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(234, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 40;
            this.label1.Text = "Estados de reserva";
            // 
            // botonVer
            // 
            this.botonVer.BackColor = System.Drawing.Color.SaddleBrown;
            this.botonVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVer.ForeColor = System.Drawing.Color.White;
            this.botonVer.Location = new System.Drawing.Point(352, 139);
            this.botonVer.Name = "botonVer";
            this.botonVer.Size = new System.Drawing.Size(69, 41);
            this.botonVer.TabIndex = 39;
            this.botonVer.Text = "Ver";
            this.botonVer.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SaddleBrown;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ver reservas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 45;
            // 
            // VistaEstadoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(808, 471);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.comboBoxVerReservas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonVer);
            this.Controls.Add(this.label7);
            this.MinimizeBox = false;
            this.Name = "VistaEstadoReserva";
            this.Text = "Hotel Karpas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonBorrar;
        private System.Windows.Forms.ComboBox comboBoxVerReservas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonVer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}