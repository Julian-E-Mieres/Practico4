namespace Practico4
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesde = new System.Windows.Forms.TextBox();
            this.textBoxHasta = new System.Windows.Forms.TextBox();
            this.BGenerarFuncion = new System.Windows.Forms.Button();
            this.BNumPares = new System.Windows.Forms.Button();
            this.BNumImpares = new System.Windows.Forms.Button();
            this.BNumPrimos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Numeros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta";
            // 
            // textBoxDesde
            // 
            this.textBoxDesde.Location = new System.Drawing.Point(90, 91);
            this.textBoxDesde.Name = "textBoxDesde";
            this.textBoxDesde.Size = new System.Drawing.Size(149, 22);
            this.textBoxDesde.TabIndex = 3;
            // 
            // textBoxHasta
            // 
            this.textBoxHasta.Location = new System.Drawing.Point(90, 152);
            this.textBoxHasta.Name = "textBoxHasta";
            this.textBoxHasta.Size = new System.Drawing.Size(148, 22);
            this.textBoxHasta.TabIndex = 4;
            // 
            // BGenerarFuncion
            // 
            this.BGenerarFuncion.Location = new System.Drawing.Point(100, 219);
            this.BGenerarFuncion.Name = "BGenerarFuncion";
            this.BGenerarFuncion.Size = new System.Drawing.Size(129, 31);
            this.BGenerarFuncion.TabIndex = 5;
            this.BGenerarFuncion.Text = "Generar Función";
            this.BGenerarFuncion.UseVisualStyleBackColor = true;
            this.BGenerarFuncion.Click += new System.EventHandler(this.BGenerarFuncion_Click);
            // 
            // BNumPares
            // 
            this.BNumPares.Location = new System.Drawing.Point(100, 276);
            this.BNumPares.Name = "BNumPares";
            this.BNumPares.Size = new System.Drawing.Size(130, 26);
            this.BNumPares.TabIndex = 6;
            this.BNumPares.Text = "Números Pares";
            this.BNumPares.UseVisualStyleBackColor = true;
            this.BNumPares.Click += new System.EventHandler(this.BNumPares_Click);
            // 
            // BNumImpares
            // 
            this.BNumImpares.Location = new System.Drawing.Point(100, 325);
            this.BNumImpares.Name = "BNumImpares";
            this.BNumImpares.Size = new System.Drawing.Size(129, 30);
            this.BNumImpares.TabIndex = 7;
            this.BNumImpares.Text = "Números impares";
            this.BNumImpares.UseVisualStyleBackColor = true;
            this.BNumImpares.Click += new System.EventHandler(this.BNumImpares_Click);
            // 
            // BNumPrimos
            // 
            this.BNumPrimos.Location = new System.Drawing.Point(100, 384);
            this.BNumPrimos.Name = "BNumPrimos";
            this.BNumPrimos.Size = new System.Drawing.Size(129, 31);
            this.BNumPrimos.TabIndex = 8;
            this.BNumPrimos.Text = "Números Primos";
            this.BNumPrimos.UseVisualStyleBackColor = true;
            this.BNumPrimos.Click += new System.EventHandler(this.BNumPrimos_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(401, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 388);
            this.listBox1.TabIndex = 9;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(815, 91);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(467, 373);
            this.chart.TabIndex = 10;
            this.chart.Text = "Gráfica";
            // 
            // BGenerar
            // 
            this.BGenerar.Location = new System.Drawing.Point(879, 512);
            this.BGenerar.Name = "BGenerar";
            this.BGenerar.Size = new System.Drawing.Size(130, 23);
            this.BGenerar.TabIndex = 11;
            this.BGenerar.Text = "Generar Gráfica";
            this.BGenerar.UseVisualStyleBackColor = true;
            this.BGenerar.Click += new System.EventHandler(this.BGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 579);
            this.Controls.Add(this.BGenerar);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BNumPrimos);
            this.Controls.Add(this.BNumImpares);
            this.Controls.Add(this.BNumPares);
            this.Controls.Add(this.BGenerarFuncion);
            this.Controls.Add(this.textBoxHasta);
            this.Controls.Add(this.textBoxDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario 4";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDesde;
        private System.Windows.Forms.TextBox textBoxHasta;
        private System.Windows.Forms.Button BGenerarFuncion;
        private System.Windows.Forms.Button BNumPares;
        private System.Windows.Forms.Button BNumImpares;
        private System.Windows.Forms.Button BNumPrimos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button BGenerar;
    }
}

