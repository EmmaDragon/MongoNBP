namespace MongoDB_Repository.Forme.ZaposleniForme
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
            this.lblVlaznost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrMerenja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVlaznost
            // 
            this.lblVlaznost.AutoSize = true;
            this.lblVlaznost.Location = new System.Drawing.Point(720, 270);
            this.lblVlaznost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVlaznost.Name = "lblVlaznost";
            this.lblVlaznost.Size = new System.Drawing.Size(0, 20);
            this.lblVlaznost.TabIndex = 23;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.MaximumSize = new System.Drawing.Size(406, 374);
            this.groupBox1.MinimumSize = new System.Drawing.Size(406, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 374);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statisticki podaci";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(223, 305);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(138, 31);
            this.btnIzracunaj.TabIndex = 42;
            this.btnIzracunaj.Text = "IZRACUNAJ";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // numBrMerenja
            // 
            this.numBrMerenja.Location = new System.Drawing.Point(184, 270);
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
            this.numBrMerenja.Size = new System.Drawing.Size(177, 26);
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
            this.label5.Location = new System.Drawing.Point(60, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Broj merenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(447, 60);
            this.label4.TabIndex = 39;
            this.label4.Text = "Da biste dobili odgovarajuce statisticke podatke\r\nneophodno je da unesete broj me" +
    "renja za koja zelite\r\nda izracunate statistiku.\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPritisak
            // 
            this.lblPritisak.AutoSize = true;
            this.lblPritisak.Location = new System.Drawing.Point(236, 355);
            this.lblPritisak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPritisak.Name = "lblPritisak";
            this.lblPritisak.Size = new System.Drawing.Size(0, 20);
            this.lblPritisak.TabIndex = 38;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(236, 271);
            this.lblTemperatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(0, 20);
            this.lblTemperatura.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vlaznost vazduha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Padavine:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Temperatura:";
            // 
            // txbVlaznost
            // 
            this.txbVlaznost.Location = new System.Drawing.Point(160, 138);
            this.txbVlaznost.Margin = new System.Windows.Forms.Padding(0);
            this.txbVlaznost.Name = "txbVlaznost";
            this.txbVlaznost.ReadOnly = true;
            this.txbVlaznost.Size = new System.Drawing.Size(208, 26);
            this.txbVlaznost.TabIndex = 33;
            // 
            // txbPadavine
            // 
            this.txbPadavine.Location = new System.Drawing.Point(161, 90);
            this.txbPadavine.Margin = new System.Windows.Forms.Padding(0);
            this.txbPadavine.Name = "txbPadavine";
            this.txbPadavine.ReadOnly = true;
            this.txbPadavine.Size = new System.Drawing.Size(208, 26);
            this.txbPadavine.TabIndex = 32;
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(160, 35);
            this.txbTemperatura.Margin = new System.Windows.Forms.Padding(0);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.ReadOnly = true;
            this.txbTemperatura.Size = new System.Drawing.Size(209, 26);
            this.txbTemperatura.TabIndex = 31;
            // 
            // Statistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(429, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVlaznost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 434);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(447, 434);
            this.Name = "Statistika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STATISTIKA";
            this.Load += new System.EventHandler(this.Statistika_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrMerenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVlaznost;
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
    }
}