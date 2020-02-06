namespace MongoDB_Repository.Forme.KorisnikForme
{
    partial class Statistika
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVremenskaS = new System.Windows.Forms.ComboBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.numBrMerenja = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPritisak = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbVlaznost = new System.Windows.Forms.TextBox();
            this.txbPadavine = new System.Windows.Forms.TextBox();
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.lblVlaznost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrMerenja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxVremenskaS);
            this.groupBox1.Controls.Add(this.btnIzracunaj);
            this.groupBox1.Controls.Add(this.numBrMerenja);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPritisak);
            this.groupBox1.Controls.Add(this.lblTemperatura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbVlaznost);
            this.groupBox1.Controls.Add(this.txbPadavine);
            this.groupBox1.Controls.Add(this.txbTemperatura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.MaximumSize = new System.Drawing.Size(380, 270);
            this.groupBox1.MinimumSize = new System.Drawing.Size(360, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(364, 320);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statisticki podaci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Vremenska Stanica:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // comboBoxVremenskaS
            // 
            this.comboBoxVremenskaS.FormattingEnabled = true;
            this.comboBoxVremenskaS.Location = new System.Drawing.Point(138, 214);
            this.comboBoxVremenskaS.Name = "comboBoxVremenskaS";
            this.comboBoxVremenskaS.Size = new System.Drawing.Size(188, 21);
            this.comboBoxVremenskaS.TabIndex = 43;
            this.comboBoxVremenskaS.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVremenskaS_SelectedIndexChanged);
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(222, 288);
            this.btnIzracunaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(104, 25);
            this.btnIzracunaj.TabIndex = 42;
            this.btnIzracunaj.Text = "IZRACUNAJ";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // numBrMerenja
            // 
            this.numBrMerenja.Location = new System.Drawing.Point(138, 251);
            this.numBrMerenja.Margin = new System.Windows.Forms.Padding(2);
            this.numBrMerenja.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numBrMerenja.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBrMerenja.Name = "numBrMerenja";
            this.numBrMerenja.Size = new System.Drawing.Size(188, 20);
            this.numBrMerenja.TabIndex = 41;
            this.numBrMerenja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBrMerenja.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Broj merenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.MaximumSize = new System.Drawing.Size(380, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 60);
            this.label4.TabIndex = 39;
            this.label4.Text = "Da biste dobili odgovarajuce statisticke podatke\r\nneophodno je da unesete broj me" +
    "renja i\r\nvremensku stanicu za koju zelite da \r\nizracunate statistiku.\r\n";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblPritisak
            // 
            this.lblPritisak.AutoSize = true;
            this.lblPritisak.Location = new System.Drawing.Point(177, 288);
            this.lblPritisak.Name = "lblPritisak";
            this.lblPritisak.Size = new System.Drawing.Size(0, 13);
            this.lblPritisak.TabIndex = 38;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(177, 220);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(0, 13);
            this.lblTemperatura.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vlaznost vazduha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Padavine:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Temperatura:";
            // 
            // txbVlaznost
            // 
            this.txbVlaznost.Location = new System.Drawing.Point(138, 113);
            this.txbVlaznost.Margin = new System.Windows.Forms.Padding(0);
            this.txbVlaznost.Name = "txbVlaznost";
            this.txbVlaznost.ReadOnly = true;
            this.txbVlaznost.Size = new System.Drawing.Size(188, 20);
            this.txbVlaznost.TabIndex = 33;
            // 
            // txbPadavine
            // 
            this.txbPadavine.Location = new System.Drawing.Point(138, 76);
            this.txbPadavine.Margin = new System.Windows.Forms.Padding(0);
            this.txbPadavine.Name = "txbPadavine";
            this.txbPadavine.ReadOnly = true;
            this.txbPadavine.Size = new System.Drawing.Size(188, 20);
            this.txbPadavine.TabIndex = 32;
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(138, 31);
            this.txbTemperatura.Margin = new System.Windows.Forms.Padding(0);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.ReadOnly = true;
            this.txbTemperatura.Size = new System.Drawing.Size(188, 20);
            this.txbTemperatura.TabIndex = 31;
            // 
            // lblVlaznost
            // 
            this.lblVlaznost.AutoSize = true;
            this.lblVlaznost.Location = new System.Drawing.Point(541, 222);
            this.lblVlaznost.Name = "lblVlaznost";
            this.lblVlaznost.Size = new System.Drawing.Size(0, 13);
            this.lblVlaznost.TabIndex = 32;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(384, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVlaznost);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(400, 380);
            this.MinimumSize = new System.Drawing.Size(400, 380);
            this.Name = "Statistika";
            this.Text = "STATISTIKA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrMerenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.NumericUpDown numBrMerenja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPritisak;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbVlaznost;
        private System.Windows.Forms.TextBox txbPadavine;
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.Label lblVlaznost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVremenskaS;
    }
}