namespace MongoDB_Repository.Forme.AdminForme
{
    partial class ZaposleniIzmene
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
            this.listaZaposlenih = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jmbg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zvanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listaStanica = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaZaposlenih
            // 
            this.listaZaposlenih.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listaZaposlenih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.Jmbg,
            this.Zvanje});
            this.listaZaposlenih.FullRowSelect = true;
            this.listaZaposlenih.GridLines = true;
            this.listaZaposlenih.HideSelection = false;
            this.listaZaposlenih.Location = new System.Drawing.Point(0, 0);
            this.listaZaposlenih.Name = "listaZaposlenih";
            this.listaZaposlenih.Size = new System.Drawing.Size(633, 450);
            this.listaZaposlenih.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listaZaposlenih.TabIndex = 0;
            this.listaZaposlenih.UseCompatibleStateImageBehavior = false;
            this.listaZaposlenih.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 30;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ime.Width = 150;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prezime.Width = 150;
            // 
            // Jmbg
            // 
            this.Jmbg.Text = "Jmbg";
            this.Jmbg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Jmbg.Width = 150;
            // 
            // Zvanje
            // 
            this.Zvanje.Text = "Zvanje";
            this.Zvanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Zvanje.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabela levo sadrzi podatke\r\no zaposlenima koji su rasporedjeni\r\nu odgovarajucoj v" +
    "remenkoj stanici.";
            // 
            // listaStanica
            // 
            this.listaStanica.FormattingEnabled = true;
            this.listaStanica.Location = new System.Drawing.Point(789, 87);
            this.listaStanica.Name = "listaStanica";
            this.listaStanica.Size = new System.Drawing.Size(134, 21);
            this.listaStanica.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vremenska Stanica:";
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(789, 129);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(134, 32);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(769, 358);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(154, 32);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(769, 406);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(154, 32);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // ZaposleniIzmene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaStanica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listaZaposlenih);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(955, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(955, 489);
            this.Name = "ZaposleniIzmene";
            this.Text = "ZAPOSLENI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaZaposlenih;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Jmbg;
        private System.Windows.Forms.ColumnHeader Zvanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listaStanica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
    }
}