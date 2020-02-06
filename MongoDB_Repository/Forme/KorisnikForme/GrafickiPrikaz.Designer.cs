namespace MongoDB_Repository.Forme.KorisnikForme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStanice = new System.Windows.Forms.ComboBox();
            this.grbPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPrikaz
            // 
            this.grbPrikaz.Controls.Add(this.rdbLogaritamski);
            this.grbPrikaz.Controls.Add(this.rdbLinearni);
            this.grbPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPrikaz.Location = new System.Drawing.Point(572, 318);
            this.grbPrikaz.Name = "grbPrikaz";
            this.grbPrikaz.Size = new System.Drawing.Size(216, 103);
            this.grbPrikaz.TabIndex = 6;
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
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(10, 11);
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
            this.chart.TabIndex = 7;
            this.chart.Text = "chart";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 800;
            this.timerUpdate.Tick += new System.EventHandler(this.TimerUpdate_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbStanice);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(572, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vremenska stanica";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(105, 154);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(89, 31);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vremenska stanica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite vremensku stanicu\r\ncija merenja zelite da vidite";
            // 
            // cmbStanice
            // 
            this.cmbStanice.FormattingEnabled = true;
            this.cmbStanice.Location = new System.Drawing.Point(6, 115);
            this.cmbStanice.Name = "cmbStanice";
            this.cmbStanice.Size = new System.Drawing.Size(188, 24);
            this.cmbStanice.TabIndex = 0;
            this.cmbStanice.SelectedIndexChanged += new System.EventHandler(this.CmbStanice_SelectedIndexChanged);
            // 
            // GrafickiPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbPrikaz);
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 487);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 487);
            this.Name = "GrafickiPrikaz";
            this.Text = "GRAFICKI PRIKAZ ZA KORISNIKA";
            this.Load += new System.EventHandler(this.GrafickiPrikaz_Load);
            this.grbPrikaz.ResumeLayout(false);
            this.grbPrikaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPrikaz;
        private System.Windows.Forms.RadioButton rdbLogaritamski;
        private System.Windows.Forms.RadioButton rdbLinearni;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStanice;
    }
}