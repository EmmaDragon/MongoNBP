namespace MongoDB_Repository.Forme.KorisnikForme
{
    partial class LogIn_Korisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Korisnik));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKreirajNalog = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-15, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 45);
            this.label1.TabIndex = 18;
            this.label1.Text = "                                 DOBRODOŠLI \r\n                              NA ST" +
    "RANICU ZA \r\n                         LOGOVANJE KORISNIKA ";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(126, 308);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 31);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "DALJE ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.HideSelection = false;
            this.txbPassword.Location = new System.Drawing.Point(71, 245);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(177, 22);
            this.txbPassword.TabIndex = 16;
            this.txbPassword.Tag = "";
            this.txbPassword.Text = "Password";
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // txbUsername
            // 
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsername.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(71, 206);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(177, 22);
            this.txbUsername.TabIndex = 15;
            this.txbUsername.Tag = "";
            this.txbUsername.Text = "Username";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblKreirajNalog
            // 
            this.lblKreirajNalog.AutoSize = true;
            this.lblKreirajNalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKreirajNalog.Location = new System.Drawing.Point(123, 270);
            this.lblKreirajNalog.Name = "lblKreirajNalog";
            this.lblKreirajNalog.Size = new System.Drawing.Size(77, 15);
            this.lblKreirajNalog.TabIndex = 19;
            this.lblKreirajNalog.TabStop = true;
            this.lblKreirajNalog.Text = "Kreiraj nalog";
            this.lblKreirajNalog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblKreirajNalog_LinkClicked);
            // 
            // LogIn_Korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(310, 350);
            this.Controls.Add(this.lblKreirajNalog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 389);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(326, 389);
            this.Name = "LogIn_Korisnik";
            this.Text = "LOGOVANJE KORISNIKA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblKreirajNalog;
    }
}