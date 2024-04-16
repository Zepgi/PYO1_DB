namespace PY1_BD.Vista
{
    partial class VistaGraficos
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.logoImg = new System.Windows.Forms.PictureBox();
			this.Graficas = new System.Windows.Forms.Label();
			this.chartGraficosGenerales = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.botonRegresar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btRecepChart = new System.Windows.Forms.Button();
			this.btClientChart = new System.Windows.Forms.Button();
			this.btTopChart = new System.Windows.Forms.Button();
			this.hOTELKARPASDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hOTELKARPASDataSet1 = new PY1_BD.HOTELKARPASDataSet1();
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartGraficosGenerales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// logoImg
			// 
			this.logoImg.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.logoImg.BackColor = System.Drawing.Color.Transparent;
			this.logoImg.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.logoImg.Image = global::PY1_BD.Properties.Resources.Logo;
			this.logoImg.Location = new System.Drawing.Point(1138, -8);
			this.logoImg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.logoImg.Name = "logoImg";
			this.logoImg.Size = new System.Drawing.Size(156, 169);
			this.logoImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.logoImg.TabIndex = 14;
			this.logoImg.TabStop = false;
			// 
			// Graficas
			// 
			this.Graficas.AutoSize = true;
			this.Graficas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Graficas.ForeColor = System.Drawing.Color.LemonChiffon;
			this.Graficas.Location = new System.Drawing.Point(427, 9);
			this.Graficas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Graficas.Name = "Graficas";
			this.Graficas.Size = new System.Drawing.Size(184, 47);
			this.Graficas.TabIndex = 18;
			this.Graficas.Text = "Graficas";
			// 
			// chartGraficosGenerales
			// 
			this.chartGraficosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.chartGraficosGenerales.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
			this.chartGraficosGenerales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.chartGraficosGenerales.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
			this.chartGraficosGenerales.BorderlineColor = System.Drawing.Color.Transparent;
			chartArea1.Name = "ChartArea1";
			this.chartGraficosGenerales.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartGraficosGenerales.Legends.Add(legend1);
			this.chartGraficosGenerales.Location = new System.Drawing.Point(221, 101);
			this.chartGraficosGenerales.Margin = new System.Windows.Forms.Padding(4);
			this.chartGraficosGenerales.Name = "chartGraficosGenerales";
			this.chartGraficosGenerales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			series1.IsValueShownAsLabel = true;
			series1.IsXValueIndexed = true;
			series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			series1.Legend = "Legend1";
			series1.Name = "sChart";
			series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chartGraficosGenerales.Series.Add(series1);
			this.chartGraficosGenerales.Size = new System.Drawing.Size(773, 553);
			this.chartGraficosGenerales.TabIndex = 19;
			// 
			// botonRegresar
			// 
			this.botonRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botonRegresar.Location = new System.Drawing.Point(1122, 682);
			this.botonRegresar.Margin = new System.Windows.Forms.Padding(4);
			this.botonRegresar.Name = "botonRegresar";
			this.botonRegresar.Size = new System.Drawing.Size(151, 37);
			this.botonRegresar.TabIndex = 20;
			this.botonRegresar.Text = "Regresar";
			this.botonRegresar.UseVisualStyleBackColor = true;
			this.botonRegresar.Click += new System.EventHandler(this.botonRegresar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.pictureBox1.Location = new System.Drawing.Point(1030, -111);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(257, 845);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// btRecepChart
			// 
			this.btRecepChart.BackColor = System.Drawing.Color.Transparent;
			this.btRecepChart.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.btRecepChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btRecepChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRecepChart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btRecepChart.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btRecepChart.Location = new System.Drawing.Point(13, 329);
			this.btRecepChart.Margin = new System.Windows.Forms.Padding(4);
			this.btRecepChart.Name = "btRecepChart";
			this.btRecepChart.Size = new System.Drawing.Size(182, 73);
			this.btRecepChart.TabIndex = 25;
			this.btRecepChart.Text = "Recepcionista con Más Reservas";
			this.btRecepChart.UseVisualStyleBackColor = false;
			// 
			// btClientChart
			// 
			this.btClientChart.BackColor = System.Drawing.Color.Transparent;
			this.btClientChart.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.btClientChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btClientChart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btClientChart.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btClientChart.Location = new System.Drawing.Point(13, 256);
			this.btClientChart.Margin = new System.Windows.Forms.Padding(4);
			this.btClientChart.Name = "btClientChart";
			this.btClientChart.Size = new System.Drawing.Size(182, 73);
			this.btClientChart.TabIndex = 24;
			this.btClientChart.Text = "Clientes por Residencia";
			this.btClientChart.UseVisualStyleBackColor = false;
			// 
			// btTopChart
			// 
			this.btTopChart.BackColor = System.Drawing.Color.Transparent;
			this.btTopChart.BackgroundImage = global::PY1_BD.Properties.Resources.Color;
			this.btTopChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btTopChart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btTopChart.ForeColor = System.Drawing.Color.LemonChiffon;
			this.btTopChart.Location = new System.Drawing.Point(13, 402);
			this.btTopChart.Margin = new System.Windows.Forms.Padding(4);
			this.btTopChart.Name = "btTopChart";
			this.btTopChart.Size = new System.Drawing.Size(182, 73);
			this.btTopChart.TabIndex = 23;
			this.btTopChart.Text = "Top Fechas de Reservación";
			this.btTopChart.UseVisualStyleBackColor = false;
			// 
			// hOTELKARPASDataSet1BindingSource
			// 
			this.hOTELKARPASDataSet1BindingSource.DataSource = this.hOTELKARPASDataSet1;
			this.hOTELKARPASDataSet1BindingSource.Position = 0;
			// 
			// hOTELKARPASDataSet1
			// 
			this.hOTELKARPASDataSet1.DataSetName = "HOTELKARPASDataSet1";
			this.hOTELKARPASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// VistaGraficos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1286, 732);
			this.Controls.Add(this.btRecepChart);
			this.Controls.Add(this.btClientChart);
			this.Controls.Add(this.btTopChart);
			this.Controls.Add(this.botonRegresar);
			this.Controls.Add(this.chartGraficosGenerales);
			this.Controls.Add(this.Graficas);
			this.Controls.Add(this.logoImg);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "VistaGraficos";
			this.Text = "VistaGraficos";
			((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartGraficosGenerales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hOTELKARPASDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.Label Graficas;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartGraficosGenerales;
        public System.Windows.Forms.Button botonRegresar;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Button btRecepChart;
		public System.Windows.Forms.Button btClientChart;
		public System.Windows.Forms.Button btTopChart;
		private System.Windows.Forms.BindingSource hOTELKARPASDataSet1BindingSource;
		private HOTELKARPASDataSet1 hOTELKARPASDataSet1;
	}
}