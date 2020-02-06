namespace MongoNBP.Forme.KorisnikForme
{
    partial class DodatneNapomene
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStanice = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txbPadavine = new System.Windows.Forms.RichTextBox();
            this.txbTemperatura = new System.Windows.Forms.RichTextBox();
            this.txbVlaznost = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPadavine);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Padavine";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTemperatura);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(177, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 497);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temperatura";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbVlaznost);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(490, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 497);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vlaznost vazduha";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPrikazi);
            this.groupBox4.Controls.Add(this.cmbStanice);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(680, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(205, 289);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vremenska stanica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ukoliko zelite da pratite\r\ndodatne informacije\r\no vremenskim parametrima\r\nneophod" +
    "no je da izaberete\r\nodgovarajucu \r\nvremensku stanicu.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbStanice
            // 
            this.cmbStanice.FormattingEnabled = true;
            this.cmbStanice.Location = new System.Drawing.Point(19, 159);
            this.cmbStanice.Name = "cmbStanice";
            this.cmbStanice.Size = new System.Drawing.Size(168, 24);
            this.cmbStanice.TabIndex = 1;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(67, 209);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(120, 27);
            this.btnPrikazi.TabIndex = 2;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txbPadavine
            // 
            this.txbPadavine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbPadavine.Location = new System.Drawing.Point(3, 18);
            this.txbPadavine.Name = "txbPadavine";
            this.txbPadavine.Size = new System.Drawing.Size(171, 476);
            this.txbPadavine.TabIndex = 0;
            this.txbPadavine.Text = "";
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbTemperatura.Location = new System.Drawing.Point(3, 18);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(307, 476);
            this.txbTemperatura.TabIndex = 0;
            this.txbTemperatura.Text = "";
            // 
            // txbVlaznost
            // 
            this.txbVlaznost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbVlaznost.Location = new System.Drawing.Point(3, 18);
            this.txbVlaznost.Name = "txbVlaznost";
            this.txbVlaznost.Size = new System.Drawing.Size(181, 476);
            this.txbVlaznost.TabIndex = 0;
            this.txbVlaznost.Text = "";
            // 
            // DodatneNapomene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 497);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodatneNapomene";
            this.Text = "DODATNE NAPOMENE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txbPadavine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txbTemperatura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txbVlaznost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.ComboBox cmbStanice;
        private System.Windows.Forms.Label label1;
    }
}