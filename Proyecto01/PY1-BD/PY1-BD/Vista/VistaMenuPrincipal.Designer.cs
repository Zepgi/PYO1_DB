namespace PY1_BD
{
    partial class VistaMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainP = new System.Windows.Forms.Label();
            this.logging = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainP
            // 
            this.MainP.AutoSize = true;
            this.MainP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainP.Location = new System.Drawing.Point(397, 40);
            this.MainP.Name = "MainP";
            this.MainP.Size = new System.Drawing.Size(136, 24);
            this.MainP.TabIndex = 0;
            this.MainP.Text = "Menu Principal";
            this.MainP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MainP.Click += new System.EventHandler(this.label1_Click);
            // 
            // logging
            // 
            this.logging.Location = new System.Drawing.Point(416, 130);
            this.logging.Name = "logging";
            this.logging.Size = new System.Drawing.Size(75, 23);
            this.logging.TabIndex = 1;
            this.logging.Text = "Logging";
            this.logging.UseVisualStyleBackColor = true;
            this.logging.Click += new System.EventHandler(this.logging_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VistaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 594);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.logging);
            this.Controls.Add(this.MainP);
            this.Name = "VistaMenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainP;
        private System.Windows.Forms.Button logging;
        private System.Windows.Forms.Button button2;
    }
}

