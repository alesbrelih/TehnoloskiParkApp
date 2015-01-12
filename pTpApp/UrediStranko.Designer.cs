namespace pTpApp
{
    partial class UrediStranko
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
            this.lblIme = new System.Windows.Forms.Label();
            this.cBoxImePriimek = new System.Windows.Forms.ComboBox();
            this.lblPodjetje = new System.Windows.Forms.Label();
            this.cBoxPodjetje = new System.Windows.Forms.ComboBox();
            this.gBoxTip = new System.Windows.Forms.GroupBox();
            this.chkTretji = new System.Windows.Forms.CheckBox();
            this.chkDrugi = new System.Windows.Forms.CheckBox();
            this.chkPrvi = new System.Windows.Forms.CheckBox();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.chkPotencialna = new System.Windows.Forms.CheckBox();
            this.podrobnostOseba = new System.Windows.Forms.Label();
            this.podrobnostPodjetje = new System.Windows.Forms.Label();
            this.gBoxTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(13, 13);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(81, 16);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime in Priimek";
            // 
            // cBoxImePriimek
            // 
            this.cBoxImePriimek.FormattingEnabled = true;
            this.cBoxImePriimek.Location = new System.Drawing.Point(92, 13);
            this.cBoxImePriimek.Name = "cBoxImePriimek";
            this.cBoxImePriimek.Size = new System.Drawing.Size(121, 21);
            this.cBoxImePriimek.TabIndex = 1;
            this.cBoxImePriimek.SelectionChangeCommitted += new System.EventHandler(this.cBoxImePriimek_SelectionChangeCommitted);
            // 
            // lblPodjetje
            // 
            this.lblPodjetje.AutoSize = true;
            this.lblPodjetje.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodjetje.Location = new System.Drawing.Point(16, 54);
            this.lblPodjetje.Name = "lblPodjetje";
            this.lblPodjetje.Size = new System.Drawing.Size(51, 16);
            this.lblPodjetje.TabIndex = 2;
            this.lblPodjetje.Text = "Podjetje";
            // 
            // cBoxPodjetje
            // 
            this.cBoxPodjetje.FormattingEnabled = true;
            this.cBoxPodjetje.Location = new System.Drawing.Point(92, 54);
            this.cBoxPodjetje.Name = "cBoxPodjetje";
            this.cBoxPodjetje.Size = new System.Drawing.Size(121, 21);
            this.cBoxPodjetje.TabIndex = 3;
            this.cBoxPodjetje.SelectionChangeCommitted += new System.EventHandler(this.cBoxPodjetje_SelectionChangeCommitted);
            // 
            // gBoxTip
            // 
            this.gBoxTip.Controls.Add(this.chkTretji);
            this.gBoxTip.Controls.Add(this.chkDrugi);
            this.gBoxTip.Controls.Add(this.chkPrvi);
            this.gBoxTip.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTip.Location = new System.Drawing.Point(19, 127);
            this.gBoxTip.Name = "gBoxTip";
            this.gBoxTip.Size = new System.Drawing.Size(226, 110);
            this.gBoxTip.TabIndex = 8;
            this.gBoxTip.TabStop = false;
            this.gBoxTip.Text = "Tip potencialne stranke";
            // 
            // chkTretji
            // 
            this.chkTretji.AutoSize = true;
            this.chkTretji.Location = new System.Drawing.Point(90, 75);
            this.chkTretji.Name = "chkTretji";
            this.chkTretji.Size = new System.Drawing.Size(120, 20);
            this.chkTretji.TabIndex = 9;
            this.chkTretji.Text = "Sola Podjetnistva";
            this.chkTretji.UseVisualStyleBackColor = true;
            this.chkTretji.Click += new System.EventHandler(this.chkTretji_Click);
            // 
            // chkDrugi
            // 
            this.chkDrugi.AutoSize = true;
            this.chkDrugi.Location = new System.Drawing.Point(90, 49);
            this.chkDrugi.Name = "chkDrugi";
            this.chkDrugi.Size = new System.Drawing.Size(118, 20);
            this.chkDrugi.TabIndex = 8;
            this.chkDrugi.Text = "Business Meetup";
            this.chkDrugi.UseVisualStyleBackColor = true;
            this.chkDrugi.Click += new System.EventHandler(this.chkDrugi_Click);
            // 
            // chkPrvi
            // 
            this.chkPrvi.AutoSize = true;
            this.chkPrvi.Location = new System.Drawing.Point(90, 24);
            this.chkPrvi.Name = "chkPrvi";
            this.chkPrvi.Size = new System.Drawing.Size(107, 20);
            this.chkPrvi.TabIndex = 7;
            this.chkPrvi.Text = "StartUp Vikend";
            this.chkPrvi.UseVisualStyleBackColor = true;
            this.chkPrvi.Click += new System.EventHandler(this.chkPrvi_Click);
            // 
            // btnNastavi
            // 
            this.btnNastavi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNastavi.Location = new System.Drawing.Point(16, 253);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(75, 23);
            this.btnNastavi.TabIndex = 9;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = true;
            this.btnNastavi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPreklici
            // 
            this.btnPreklici.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreklici.Location = new System.Drawing.Point(138, 253);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(75, 23);
            this.btnPreklici.TabIndex = 10;
            this.btnPreklici.Text = "Preklici";
            this.btnPreklici.UseVisualStyleBackColor = true;
            this.btnPreklici.Click += new System.EventHandler(this.btnPreklici_Click);
            // 
            // chkPotencialna
            // 
            this.chkPotencialna.AutoSize = true;
            this.chkPotencialna.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPotencialna.Location = new System.Drawing.Point(19, 101);
            this.chkPotencialna.Name = "chkPotencialna";
            this.chkPotencialna.Size = new System.Drawing.Size(131, 20);
            this.chkPotencialna.TabIndex = 11;
            this.chkPotencialna.Text = "Potencialna stranka";
            this.chkPotencialna.UseVisualStyleBackColor = true;
            this.chkPotencialna.Click += new System.EventHandler(this.chkPotencialna_Click);
            // 
            // podrobnostOseba
            // 
            this.podrobnostOseba.AutoSize = true;
            this.podrobnostOseba.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podrobnostOseba.Location = new System.Drawing.Point(219, 16);
            this.podrobnostOseba.Name = "podrobnostOseba";
            this.podrobnostOseba.Size = new System.Drawing.Size(64, 15);
            this.podrobnostOseba.TabIndex = 13;
            this.podrobnostOseba.Text = "Podrobnosti";
            this.podrobnostOseba.Click += new System.EventHandler(this.podrobnostOseba_Click);
            // 
            // podrobnostPodjetje
            // 
            this.podrobnostPodjetje.AutoSize = true;
            this.podrobnostPodjetje.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.podrobnostPodjetje.Location = new System.Drawing.Point(219, 56);
            this.podrobnostPodjetje.Name = "podrobnostPodjetje";
            this.podrobnostPodjetje.Size = new System.Drawing.Size(64, 15);
            this.podrobnostPodjetje.TabIndex = 14;
            this.podrobnostPodjetje.Text = "Podrobnosti";
            this.podrobnostPodjetje.Click += new System.EventHandler(this.podrobnostPodjetje_Click);
            // 
            // UrediStranko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 301);
            this.Controls.Add(this.podrobnostPodjetje);
            this.Controls.Add(this.podrobnostOseba);
            this.Controls.Add(this.chkPotencialna);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.gBoxTip);
            this.Controls.Add(this.cBoxPodjetje);
            this.Controls.Add(this.lblPodjetje);
            this.Controls.Add(this.cBoxImePriimek);
            this.Controls.Add(this.lblIme);
            this.MaximumSize = new System.Drawing.Size(313, 328);
            this.MinimumSize = new System.Drawing.Size(313, 328);
            this.Name = "UrediStranko";
            this.Text = "UrediStranko";
            this.Load += new System.EventHandler(this.UrediStranko_Load);
            this.Shown += new System.EventHandler(this.UrediStranko_Shown);
            this.gBoxTip.ResumeLayout(false);
            this.gBoxTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.ComboBox cBoxImePriimek;
        private System.Windows.Forms.Label lblPodjetje;
        private System.Windows.Forms.ComboBox cBoxPodjetje;
        private System.Windows.Forms.GroupBox gBoxTip;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.CheckBox chkPotencialna;
        private System.Windows.Forms.Label podrobnostOseba;
        private System.Windows.Forms.Label podrobnostPodjetje;
        private System.Windows.Forms.CheckBox chkTretji;
        private System.Windows.Forms.CheckBox chkDrugi;
        private System.Windows.Forms.CheckBox chkPrvi;
    }
}