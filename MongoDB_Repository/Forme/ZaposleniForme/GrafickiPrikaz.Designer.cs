namespace MongoDB_Repository.Forme.ZaposleniForme
{
    partial class GrafickiPrikaz
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grbPrikaz = new System.Windows.Forms.GroupBox();
            this.rdbLogaritamski = new System.Windows.Forms.RadioButton();
            this.rdbLinearni = new System.Windows.Forms.RadioButton();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.grbPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPrikaz
            // 
            this.grbPrikaz.Controls.Add(this.rdbLogaritamski);
            this.grbPrikaz.Controls.Add(this.rdbLinearni);
            this.grbPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrikaz.Location = new System.Drawing.Point(574, 335);
            this.grbPrikaz.Name = "grbPrikaz";
            this.grbPrikaz.Size = new System.Drawing.Size(200, 103);
            this.grbPrikaz.TabIndex = 4;
            this.grbPrikaz.TabStop = false;
            this.grbPrikaz.Text = "Prikaz";
            // 
            // rdbLogaritamski
            // 
            this.rdbLogaritamski.AutoSize = true;
            this.rdbLogaritamski.Location = new System.Drawing.Point(6, 30);
            this.rdbLogaritamski.Name = "rdbLogaritamski";
            this.rdbLogaritamski.Size = new System.Drawing.Size(143, 20);
            this.rdbLogaritamski.TabIndex = 1;
            this.rdbLogaritamski.Text = "Logaritamski Prikaz";
            this.rdbLogaritamski.UseVisualStyleBackColor = true;
            this.rdbLogaritamski.CheckedChanged += new System.EventHandler(this.rdbLogaritamski_CheckedChanged);
            // 
            // rdbLinearni
            // 
            this.rdbLinearni.AutoSize = true;
            this.rdbLinearni.Checked = true;
            this.rdbLinearni.Location = new System.Drawing.Point(6, 64);
            this.rdbLinearni.Name = "rdbLinearni";
            this.rdbLinearni.Size = new System.Drawing.Size(113, 20);
            this.rdbLinearni.TabIndex = 2;
            this.rdbLinearni.TabStop = true;
            this.rdbLinearni.Text = "Linearni Prikaz";
            this.rdbLinearni.UseVisualStyleBackColor = true;
            this.rdbLinearni.CheckedChanged += new System.EventHandler(this.rdbLinearni_CheckedChanged);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Padavine";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Vlaznost vazduha";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(556, 426);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 500;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // GrafickiPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(798, 442);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.grbPrikaz);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 487);
            this.MinimizeBox = false;
            this.Name = "GrafickiPrikaz";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "GRAFICKI PRIKAZ ZA ZAPOSLENOG";
            this.Load += new System.EventHandler(this.Ucitavanje);
            this.grbPrikaz.ResumeLayout(false);
            this.grbPrikaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrikaz;
        private System.Windows.Forms.RadioButton rdbLogaritamski;
        private System.Windows.Forms.RadioButton rdbLinearni;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timerUpdate;
    }
}