namespace MongoDB_Repository.Forme.KorisnikForme
{
    partial class GlavnaStranica
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
            this.izmeniLicnePodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.unesiPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.padavineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vlaznostVazduhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eksportujMerenjaVremenskihStanicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dodatneNapomeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // izmeniLicnePodatkeToolStripMenuItem
            // 
            this.izmeniLicnePodatkeToolStripMenuItem.Name = "izmeniLicnePodatkeToolStripMenuItem";
            this.izmeniLicnePodatkeToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.izmeniLicnePodatkeToolStripMenuItem.Text = "Izmeni licne podatke";
            this.izmeniLicnePodatkeToolStripMenuItem.Click += new System.EventHandler(this.IzmeniLicnePodatkeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 198);
            this.label1.TabIndex = 0;
            this.label1.Text = "IME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unesiPodatkeToolStripMenuItem
            // 
            this.unesiPodatkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperaturaToolStripMenuItem1,
            this.padavineToolStripMenuItem1,
            this.vlaznostVazduhaToolStripMenuItem1});
            this.unesiPodatkeToolStripMenuItem.Name = "unesiPodatkeToolStripMenuItem";
            this.unesiPodatkeToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.unesiPodatkeToolStripMenuItem.Text = "Graficki prikaz podataka";
            this.unesiPodatkeToolStripMenuItem.Click += new System.EventHandler(this.unesiPodatkeToolStripMenuItem_Click);
            // 
            // temperaturaToolStripMenuItem1
            // 
            this.temperaturaToolStripMenuItem1.Name = "temperaturaToolStripMenuItem1";
            this.temperaturaToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.temperaturaToolStripMenuItem1.Text = "Temperatura";
            this.temperaturaToolStripMenuItem1.Click += new System.EventHandler(this.TemperaturaToolStripMenuItem1_Click);
            // 
            // padavineToolStripMenuItem1
            // 
            this.padavineToolStripMenuItem1.Name = "padavineToolStripMenuItem1";
            this.padavineToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.padavineToolStripMenuItem1.Text = "Padavine";
            this.padavineToolStripMenuItem1.Click += new System.EventHandler(this.PadavineToolStripMenuItem1_Click);
            // 
            // vlaznostVazduhaToolStripMenuItem1
            // 
            this.vlaznostVazduhaToolStripMenuItem1.Name = "vlaznostVazduhaToolStripMenuItem1";
            this.vlaznostVazduhaToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.vlaznostVazduhaToolStripMenuItem1.Text = "Vlaznost vazduha";
            this.vlaznostVazduhaToolStripMenuItem1.Click += new System.EventHandler(this.VlaznostVazduhaToolStripMenuItem1_Click);
            // 
            // formeToolStripMenuItem
            // 
            this.formeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiPodatkeToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.izmeniLicnePodatkeToolStripMenuItem,
            this.eksportujMerenjaVremenskihStanicaToolStripMenuItem,
            this.dodatneNapomeneToolStripMenuItem});
            this.formeToolStripMenuItem.Name = "formeToolStripMenuItem";
            this.formeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.formeToolStripMenuItem.Text = "Opcije";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.StatistikaToolStripMenuItem_Click);
            // 
            // eksportujMerenjaVremenskihStanicaToolStripMenuItem
            // 
            this.eksportujMerenjaVremenskihStanicaToolStripMenuItem.Name = "eksportujMerenjaVremenskihStanicaToolStripMenuItem";
            this.eksportujMerenjaVremenskihStanicaToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.eksportujMerenjaVremenskihStanicaToolStripMenuItem.Text = "Eksportuj merenja vremenskih stanica";
            this.eksportujMerenjaVremenskihStanicaToolStripMenuItem.Click += new System.EventHandler(this.EksportujMerenjaVremenskihStanicaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(301, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 182);
            this.label2.TabIndex = 1;
            this.label2.Text = "PREZIME:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblIme.Location = new System.Drawing.Point(99, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(96, 198);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "label5";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrezime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPrezime.Location = new System.Drawing.Point(99, 198);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(96, 182);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "label5";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.85994F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.14006F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrezime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(103, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.67876F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.53368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 541);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 161);
            this.label3.TabIndex = 14;
            this.label3.Text = "KORISNICKO IME:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(99, 380);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 161);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "label5";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 541);
            this.label4.TabIndex = 3;
            this.label4.Text = "LIČNI PODACI \r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(103, 541);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // dodatneNapomeneToolStripMenuItem
            // 
            this.dodatneNapomeneToolStripMenuItem.Name = "dodatneNapomeneToolStripMenuItem";
            this.dodatneNapomeneToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.dodatneNapomeneToolStripMenuItem.Text = "Dodatne napomene";
            this.dodatneNapomeneToolStripMenuItem.Click += new System.EventHandler(this.dodatneNapomeneToolStripMenuItem_Click);
            // 
            // GlavnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1156, 541);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GlavnaStranica";
            this.Text = "GLAVNA STRANICA KORISNIKA";
            this.Load += new System.EventHandler(this.GlavnaStranica_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem izmeniLicnePodatkeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem unesiPodatkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem padavineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vlaznostVazduhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eksportujMerenjaVremenskihStanicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodatneNapomeneToolStripMenuItem;
    }
}