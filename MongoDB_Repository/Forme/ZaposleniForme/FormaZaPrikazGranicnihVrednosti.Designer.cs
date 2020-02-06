namespace MongoDB_Repository.Forme.ZaposleniForme
{
    partial class FormaZaPrikazGranicnihVrednosti
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblMaksimum = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinVrednost = new System.Windows.Forms.Label();
            this.lblMaxVrednost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(250, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 28);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblMaksimum
            // 
            this.lblMaksimum.AutoSize = true;
            this.lblMaksimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaksimum.Location = new System.Drawing.Point(198, 81);
            this.lblMaksimum.Name = "lblMaksimum";
            this.lblMaksimum.Size = new System.Drawing.Size(0, 16);
            this.lblMaksimum.TabIndex = 8;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimum.Location = new System.Drawing.Point(198, 34);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(0, 16);
            this.lblMinimum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Maksimalna vrednost :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minimalna vrednost :";
            // 
            // lblMinVrednost
            // 
            this.lblMinVrednost.AutoSize = true;
            this.lblMinVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMinVrednost.Location = new System.Drawing.Point(247, 34);
            this.lblMinVrednost.Name = "lblMinVrednost";
            this.lblMinVrednost.Size = new System.Drawing.Size(32, 16);
            this.lblMinVrednost.TabIndex = 10;
            this.lblMinVrednost.Text = "min";
            // 
            // lblMaxVrednost
            // 
            this.lblMaxVrednost.AutoSize = true;
            this.lblMaxVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMaxVrednost.Location = new System.Drawing.Point(247, 81);
            this.lblMaxVrednost.Name = "lblMaxVrednost";
            this.lblMaxVrednost.Size = new System.Drawing.Size(36, 16);
            this.lblMaxVrednost.TabIndex = 11;
            this.lblMaxVrednost.Text = "max";
            // 
            // FormaZaPrikazGranicnihVrednosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(355, 180);
            this.Controls.Add(this.lblMaxVrednost);
            this.Controls.Add(this.lblMinVrednost);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMaksimum);
            this.Controls.Add(this.lblMinimum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(371, 219);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(371, 219);
            this.Name = "FormaZaPrikazGranicnihVrednosti";
            this.Text = "GRANICNE VREDNOSTI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Label lblMaksimum;
        public System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinVrednost;
        private System.Windows.Forms.Label lblMaxVrednost;
    }
}