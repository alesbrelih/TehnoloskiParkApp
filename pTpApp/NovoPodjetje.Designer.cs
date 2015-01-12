namespace pTpApp
{
    partial class NovoPodjetje
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
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImePodjetja = new System.Windows.Forms.Label();
            this.btnPotrdi = new System.Windows.Forms.Button();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblPodrobnosti = new System.Windows.Forms.Label();
            this.cBoxOsebe = new System.Windows.Forms.ComboBox();
            this.tBoxImeP = new System.Windows.Forms.TextBox();
            this.gBoxClan = new System.Windows.Forms.GroupBox();
            this.btnClan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxClanstvo = new System.Windows.Forms.ComboBox();
            this.gBoxNajem = new System.Windows.Forms.GroupBox();
            this.btnNajem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxNajem = new System.Windows.Forms.ComboBox();
            this.gBoxPartner = new System.Windows.Forms.GroupBox();
            this.btnPartner = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxPartner = new System.Windows.Forms.ComboBox();
            this.pnlLabel.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.gBoxClan.SuspendLayout();
            this.gBoxNajem.SuspendLayout();
            this.gBoxPartner.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabel
            // 
            this.pnlLabel.Controls.Add(this.label1);
            this.pnlLabel.Controls.Add(this.lblImePodjetja);
            this.pnlLabel.Controls.Add(this.btnPotrdi);
            this.pnlLabel.Controls.Add(this.btnIzhod);
            this.pnlLabel.Location = new System.Drawing.Point(13, 13);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(131, 162);
            this.pnlLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontaktna oseba:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImePodjetja
            // 
            this.lblImePodjetja.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePodjetja.Location = new System.Drawing.Point(4, 4);
            this.lblImePodjetja.Name = "lblImePodjetja";
            this.lblImePodjetja.Size = new System.Drawing.Size(124, 23);
            this.lblImePodjetja.TabIndex = 0;
            this.lblImePodjetja.Text = "Ime Podjetja:";
            this.lblImePodjetja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPotrdi
            // 
            this.btnPotrdi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotrdi.Location = new System.Drawing.Point(7, 88);
            this.btnPotrdi.Name = "btnPotrdi";
            this.btnPotrdi.Size = new System.Drawing.Size(121, 32);
            this.btnPotrdi.TabIndex = 5;
            this.btnPotrdi.Text = "Potrdi";
            this.btnPotrdi.UseVisualStyleBackColor = true;
            this.btnPotrdi.Click += new System.EventHandler(this.btnPotrdi_Click);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzhod.Location = new System.Drawing.Point(7, 124);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(121, 32);
            this.btnIzhod.TabIndex = 6;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnPonastavi_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblPodrobnosti);
            this.pnlInput.Controls.Add(this.cBoxOsebe);
            this.pnlInput.Controls.Add(this.tBoxImeP);
            this.pnlInput.Location = new System.Drawing.Point(150, 13);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(430, 50);
            this.pnlInput.TabIndex = 1;
            // 
            // lblPodrobnosti
            // 
            this.lblPodrobnosti.AutoSize = true;
            this.lblPodrobnosti.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodrobnosti.Location = new System.Drawing.Point(278, 31);
            this.lblPodrobnosti.Name = "lblPodrobnosti";
            this.lblPodrobnosti.Size = new System.Drawing.Size(64, 15);
            this.lblPodrobnosti.TabIndex = 2;
            this.lblPodrobnosti.Text = "Podrobnosti";
            this.lblPodrobnosti.Click += new System.EventHandler(this.lblPodrobnosti_Click);
            // 
            // cBoxOsebe
            // 
            this.cBoxOsebe.Enabled = false;
            this.cBoxOsebe.FormattingEnabled = true;
            this.cBoxOsebe.Location = new System.Drawing.Point(19, 27);
            this.cBoxOsebe.Name = "cBoxOsebe";
            this.cBoxOsebe.Size = new System.Drawing.Size(252, 21);
            this.cBoxOsebe.TabIndex = 1;
            this.cBoxOsebe.SelectionChangeCommitted += new System.EventHandler(this.cBoxOsebe_SelectionChangeCommitted);
            // 
            // tBoxImeP
            // 
            this.tBoxImeP.Location = new System.Drawing.Point(19, 4);
            this.tBoxImeP.Name = "tBoxImeP";
            this.tBoxImeP.Size = new System.Drawing.Size(252, 20);
            this.tBoxImeP.TabIndex = 0;
            // 
            // gBoxClan
            // 
            this.gBoxClan.Controls.Add(this.btnClan);
            this.gBoxClan.Controls.Add(this.label7);
            this.gBoxClan.Controls.Add(this.cBoxClanstvo);
            this.gBoxClan.Location = new System.Drawing.Point(150, 69);
            this.gBoxClan.Name = "gBoxClan";
            this.gBoxClan.Size = new System.Drawing.Size(360, 100);
            this.gBoxClan.TabIndex = 7;
            this.gBoxClan.TabStop = false;
            this.gBoxClan.Text = "Član";
            // 
            // btnClan
            // 
            this.btnClan.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClan.Location = new System.Drawing.Point(22, 59);
            this.btnClan.Name = "btnClan";
            this.btnClan.Size = new System.Drawing.Size(121, 32);
            this.btnClan.TabIndex = 7;
            this.btnClan.Text = "Dodaj/Uredi";
            this.btnClan.UseVisualStyleBackColor = true;
            this.btnClan.Click += new System.EventHandler(this.btnClan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pregled";
            // 
            // cBoxClanstvo
            // 
            this.cBoxClanstvo.FormattingEnabled = true;
            this.cBoxClanstvo.Location = new System.Drawing.Point(22, 32);
            this.cBoxClanstvo.Name = "cBoxClanstvo";
            this.cBoxClanstvo.Size = new System.Drawing.Size(320, 21);
            this.cBoxClanstvo.TabIndex = 5;
            this.cBoxClanstvo.SelectionChangeCommitted += new System.EventHandler(this.cBoxClanstvo_SelectionChangeCommitted);
            // 
            // gBoxNajem
            // 
            this.gBoxNajem.Controls.Add(this.btnNajem);
            this.gBoxNajem.Controls.Add(this.label8);
            this.gBoxNajem.Controls.Add(this.cBoxNajem);
            this.gBoxNajem.Location = new System.Drawing.Point(150, 175);
            this.gBoxNajem.Name = "gBoxNajem";
            this.gBoxNajem.Size = new System.Drawing.Size(360, 99);
            this.gBoxNajem.TabIndex = 8;
            this.gBoxNajem.TabStop = false;
            this.gBoxNajem.Text = "Najem";
            // 
            // btnNajem
            // 
            this.btnNajem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNajem.Location = new System.Drawing.Point(22, 59);
            this.btnNajem.Name = "btnNajem";
            this.btnNajem.Size = new System.Drawing.Size(121, 32);
            this.btnNajem.TabIndex = 7;
            this.btnNajem.Text = "Dodaj/Uredi";
            this.btnNajem.UseVisualStyleBackColor = true;
            this.btnNajem.Click += new System.EventHandler(this.btnNajem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Pregled";
            // 
            // cBoxNajem
            // 
            this.cBoxNajem.FormattingEnabled = true;
            this.cBoxNajem.Location = new System.Drawing.Point(22, 32);
            this.cBoxNajem.Name = "cBoxNajem";
            this.cBoxNajem.Size = new System.Drawing.Size(320, 21);
            this.cBoxNajem.TabIndex = 5;
            this.cBoxNajem.SelectionChangeCommitted += new System.EventHandler(this.cBoxNajem_SelectionChangeCommitted);
            // 
            // gBoxPartner
            // 
            this.gBoxPartner.Controls.Add(this.btnPartner);
            this.gBoxPartner.Controls.Add(this.label9);
            this.gBoxPartner.Controls.Add(this.cBoxPartner);
            this.gBoxPartner.Location = new System.Drawing.Point(150, 280);
            this.gBoxPartner.Name = "gBoxPartner";
            this.gBoxPartner.Size = new System.Drawing.Size(360, 100);
            this.gBoxPartner.TabIndex = 9;
            this.gBoxPartner.TabStop = false;
            this.gBoxPartner.Text = "Partnerstvo";
            // 
            // btnPartner
            // 
            this.btnPartner.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartner.Location = new System.Drawing.Point(22, 59);
            this.btnPartner.Name = "btnPartner";
            this.btnPartner.Size = new System.Drawing.Size(121, 32);
            this.btnPartner.TabIndex = 7;
            this.btnPartner.Text = "Dodaj/Uredi";
            this.btnPartner.UseVisualStyleBackColor = true;
            this.btnPartner.Click += new System.EventHandler(this.btnPartner_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Pregled";
            // 
            // cBoxPartner
            // 
            this.cBoxPartner.FormattingEnabled = true;
            this.cBoxPartner.Location = new System.Drawing.Point(22, 32);
            this.cBoxPartner.Name = "cBoxPartner";
            this.cBoxPartner.Size = new System.Drawing.Size(320, 21);
            this.cBoxPartner.TabIndex = 5;
            this.cBoxPartner.SelectionChangeCommitted += new System.EventHandler(this.cBoxPartner_SelectionChangeCommitted);
            // 
            // NovoPodjetje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 517);
            this.Controls.Add(this.gBoxPartner);
            this.Controls.Add(this.gBoxNajem);
            this.Controls.Add(this.gBoxClan);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlLabel);
            this.MaximumSize = new System.Drawing.Size(600, 544);
            this.MinimumSize = new System.Drawing.Size(600, 544);
            this.Name = "NovoPodjetje";
            this.Text = "Novo Podjetje";
            this.Load += new System.EventHandler(this.NovoPodjetje_Load);
            this.Shown += new System.EventHandler(this.NovoPodjetje_Shown);
            this.pnlLabel.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.gBoxClan.ResumeLayout(false);
            this.gBoxClan.PerformLayout();
            this.gBoxNajem.ResumeLayout(false);
            this.gBoxNajem.PerformLayout();
            this.gBoxPartner.ResumeLayout(false);
            this.gBoxPartner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImePodjetja;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.ComboBox cBoxOsebe;
        private System.Windows.Forms.TextBox tBoxImeP;
        private System.Windows.Forms.Button btnPotrdi;
        private System.Windows.Forms.Button btnIzhod;
        private System.Windows.Forms.GroupBox gBoxClan;
        private System.Windows.Forms.Button btnClan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBoxClanstvo;
        private System.Windows.Forms.GroupBox gBoxNajem;
        private System.Windows.Forms.Button btnNajem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxNajem;
        private System.Windows.Forms.GroupBox gBoxPartner;
        private System.Windows.Forms.Button btnPartner;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxPartner;
        private System.Windows.Forms.Label lblPodrobnosti;
    }
}