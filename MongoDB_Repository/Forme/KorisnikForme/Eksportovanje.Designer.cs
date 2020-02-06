namespace MongoDB_Repository.Forme.KorisnikForme
{
    partial class Eksportovanje
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportTxt.Location = new System.Drawing.Point(254, 86);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.Size = new System.Drawing.Size(121, 21);
            this.btnExportTxt.TabIndex = 1;
            this.btnExportTxt.Text = "Eksportuj";
            this.btnExportTxt.UseVisualStyleBackColor = true;
            this.btnExportTxt.Click += new System.EventHandler(this.BtnExportTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.MinimumSize = new System.Drawing.Size(350, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izaberite vremensku stanicu cije podatke zelite da eksportujete.";
            // 
            // Eksportovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(387, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(403, 158);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(403, 158);
            this.Name = "Eksportovanje";
            this.Text = "Eksportovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}