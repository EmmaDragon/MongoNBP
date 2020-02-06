namespace MongoDB_Repository.Forme.AdminForme
{
    partial class VremenskeStanice
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
            this.lblUputstvo = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.listaStanica = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinTemperatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxTemperatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinPadavine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPadavine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MinVlaznost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxVlaznost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblUputstvo
            // 
            this.lblUputstvo.AutoSize = true;
            this.lblUputstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUputstvo.Location = new System.Drawing.Point(906, 26);
            this.lblUputstvo.Name = "lblUputstvo";
            this.lblUputstvo.Size = new System.Drawing.Size(192, 48);
            this.lblUputstvo.TabIndex = 1;
            this.lblUputstvo.Text = "Tabela levo sadrzi podatke\r\no svim postojecim vremenskim\r\nstanicama za ";
            this.lblUputstvo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(924, 363);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(174, 43);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(924, 439);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(174, 43);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // listaStanica
            // 
            this.listaStanica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listaStanica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv,
            this.Mesto,
            this.MinTemperatura,
            this.MaxTemperatura,
            this.MinPadavine,
            this.MaxPadavine,
            this.MinVlaznost,
            this.MaxVlaznost});
            this.listaStanica.FullRowSelect = true;
            this.listaStanica.GridLines = true;
            this.listaStanica.HideSelection = false;
            this.listaStanica.Location = new System.Drawing.Point(1, -2);
            this.listaStanica.Name = "listaStanica";
            this.listaStanica.Size = new System.Drawing.Size(892, 496);
            this.listaStanica.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listaStanica.TabIndex = 4;
            this.listaStanica.UseCompatibleStateImageBehavior = false;
            this.listaStanica.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 30;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Naziv.Width = 100;
            // 
            // Mesto
            // 
            this.Mesto.Text = "Mesto";
            this.Mesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mesto.Width = 120;
            // 
            // MinTemperatura
            // 
            this.MinTemperatura.Text = "Min Temperatura";
            this.MinTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinTemperatura.Width = 100;
            // 
            // MaxTemperatura
            // 
            this.MaxTemperatura.Text = "Max Temperatura";
            this.MaxTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxTemperatura.Width = 100;
            // 
            // MinPadavine
            // 
            this.MinPadavine.Text = "Min Padavine";
            this.MinPadavine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinPadavine.Width = 100;
            // 
            // MaxPadavine
            // 
            this.MaxPadavine.Text = "Max Padavine";
            this.MaxPadavine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxPadavine.Width = 100;
            // 
            // MinVlaznost
            // 
            this.MinVlaznost.Text = "Min Vlaznost Vazduha";
            this.MinVlaznost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinVlaznost.Width = 120;
            // 
            // MaxVlaznost
            // 
            this.MaxVlaznost.Text = "Max Vlaznost Vazduha";
            this.MaxVlaznost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxVlaznost.Width = 120;
            // 
            // VremenskeStanice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1118, 494);
            this.Controls.Add(this.listaStanica);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.lblUputstvo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1134, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1134, 533);
            this.Name = "VremenskeStanice";
            this.Text = "VREMENSKE STANICE";
            this.Load += new System.EventHandler(this.VremenskeStanice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUputstvo;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ListView listaStanica;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader Mesto;
        private System.Windows.Forms.ColumnHeader MinTemperatura;
        private System.Windows.Forms.ColumnHeader MaxTemperatura;
        private System.Windows.Forms.ColumnHeader MinPadavine;
        private System.Windows.Forms.ColumnHeader MaxPadavine;
        private System.Windows.Forms.ColumnHeader MinVlaznost;
        private System.Windows.Forms.ColumnHeader MaxVlaznost;
    }
}