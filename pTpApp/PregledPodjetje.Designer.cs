namespace pTpApp
{
    partial class PregledPodjetje
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
            this.gBoxPodjetje = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lViewPartner = new System.Windows.Forms.ListView();
            this.cHOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPartOd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHPartDO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lViewNajem = new System.Windows.Forms.ListView();
            this.chNajemOd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHNajemDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBoxClani = new System.Windows.Forms.GroupBox();
            this.lViewClan = new System.Windows.Forms.ListView();
            this.cHTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHDatumZac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHDatumKon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblImePodjetja = new System.Windows.Forms.Label();
            this.gBoxKontaktna = new System.Windows.Forms.GroupBox();
            this.lblTujec = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPriimek = new System.Windows.Forms.Label();
            this.lblImeOsebe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxPodjetje.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxClani.SuspendLayout();
            this.gBoxKontaktna.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxPodjetje
            // 
            this.gBoxPodjetje.Controls.Add(this.btnOK);
            this.gBoxPodjetje.Controls.Add(this.groupBox2);
            this.gBoxPodjetje.Controls.Add(this.groupBox1);
            this.gBoxPodjetje.Controls.Add(this.gBoxClani);
            this.gBoxPodjetje.Controls.Add(this.lblImePodjetja);
            this.gBoxPodjetje.Controls.Add(this.gBoxKontaktna);
            this.gBoxPodjetje.Controls.Add(this.label1);
            this.gBoxPodjetje.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPodjetje.Location = new System.Drawing.Point(13, 13);
            this.gBoxPodjetje.Name = "gBoxPodjetje";
            this.gBoxPodjetje.Size = new System.Drawing.Size(406, 718);
            this.gBoxPodjetje.TabIndex = 0;
            this.gBoxPodjetje.TabStop = false;
            this.gBoxPodjetje.Text = "PODJETJE";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(16, 689);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lViewPartner);
            this.groupBox2.Location = new System.Drawing.Point(10, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 148);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PARTNERSTVA";
            // 
            // lViewPartner
            // 
            this.lViewPartner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHOpis,
            this.chPartOd,
            this.cHPartDO});
            this.lViewPartner.Location = new System.Drawing.Point(6, 22);
            this.lViewPartner.Name = "lViewPartner";
            this.lViewPartner.Size = new System.Drawing.Size(368, 120);
            this.lViewPartner.TabIndex = 1;
            this.lViewPartner.UseCompatibleStateImageBehavior = false;
            this.lViewPartner.View = System.Windows.Forms.View.Details;
            // 
            // cHOpis
            // 
            this.cHOpis.Text = "OPIS";
            this.cHOpis.Width = 172;
            // 
            // chPartOd
            // 
            this.chPartOd.Text = "OD";
            this.chPartOd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPartOd.Width = 96;
            // 
            // cHPartDO
            // 
            this.cHPartDO.Text = "DO";
            this.cHPartDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHPartDO.Width = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lViewNajem);
            this.groupBox1.Location = new System.Drawing.Point(10, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NAJEMI";
            // 
            // lViewNajem
            // 
            this.lViewNajem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNajemOd,
            this.cHNajemDo});
            this.lViewNajem.Location = new System.Drawing.Point(9, 21);
            this.lViewNajem.Name = "lViewNajem";
            this.lViewNajem.Size = new System.Drawing.Size(368, 120);
            this.lViewNajem.TabIndex = 1;
            this.lViewNajem.UseCompatibleStateImageBehavior = false;
            this.lViewNajem.View = System.Windows.Forms.View.Details;
            // 
            // chNajemOd
            // 
            this.chNajemOd.Text = "OD";
            this.chNajemOd.Width = 178;
            // 
            // cHNajemDo
            // 
            this.cHNajemDo.Text = "DO";
            this.cHNajemDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHNajemDo.Width = 185;
            // 
            // gBoxClani
            // 
            this.gBoxClani.Controls.Add(this.lViewClan);
            this.gBoxClani.Location = new System.Drawing.Point(10, 235);
            this.gBoxClani.Name = "gBoxClani";
            this.gBoxClani.Size = new System.Drawing.Size(383, 141);
            this.gBoxClani.TabIndex = 7;
            this.gBoxClani.TabStop = false;
            this.gBoxClani.Text = "ČLANSTVA";
            // 
            // lViewClan
            // 
            this.lViewClan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHTip,
            this.cHDatumZac,
            this.cHDatumKon});
            this.lViewClan.Location = new System.Drawing.Point(9, 22);
            this.lViewClan.Name = "lViewClan";
            this.lViewClan.Size = new System.Drawing.Size(368, 113);
            this.lViewClan.TabIndex = 0;
            this.lViewClan.UseCompatibleStateImageBehavior = false;
            this.lViewClan.View = System.Windows.Forms.View.Details;
            // 
            // cHTip
            // 
            this.cHTip.Text = "TIP ČLANA";
            this.cHTip.Width = 150;
            // 
            // cHDatumZac
            // 
            this.cHDatumZac.Text = "OD";
            this.cHDatumZac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHDatumZac.Width = 103;
            // 
            // cHDatumKon
            // 
            this.cHDatumKon.Text = "DO";
            this.cHDatumKon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHDatumKon.Width = 110;
            // 
            // lblImePodjetja
            // 
            this.lblImePodjetja.AutoSize = true;
            this.lblImePodjetja.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePodjetja.Location = new System.Drawing.Point(123, 22);
            this.lblImePodjetja.Name = "lblImePodjetja";
            this.lblImePodjetja.Size = new System.Drawing.Size(11, 16);
            this.lblImePodjetja.TabIndex = 6;
            this.lblImePodjetja.Text = "/";
            // 
            // gBoxKontaktna
            // 
            this.gBoxKontaktna.Controls.Add(this.lblTujec);
            this.gBoxKontaktna.Controls.Add(this.lblTelefon);
            this.gBoxKontaktna.Controls.Add(this.lblEmail);
            this.gBoxKontaktna.Controls.Add(this.lblPriimek);
            this.gBoxKontaktna.Controls.Add(this.lblImeOsebe);
            this.gBoxKontaktna.Controls.Add(this.label6);
            this.gBoxKontaktna.Controls.Add(this.label5);
            this.gBoxKontaktna.Controls.Add(this.label4);
            this.gBoxKontaktna.Controls.Add(this.label3);
            this.gBoxKontaktna.Controls.Add(this.label2);
            this.gBoxKontaktna.Location = new System.Drawing.Point(10, 53);
            this.gBoxKontaktna.Name = "gBoxKontaktna";
            this.gBoxKontaktna.Size = new System.Drawing.Size(383, 175);
            this.gBoxKontaktna.TabIndex = 1;
            this.gBoxKontaktna.TabStop = false;
            this.gBoxKontaktna.Text = "KONTAKTNA OSEBA";
            // 
            // lblTujec
            // 
            this.lblTujec.AutoSize = true;
            this.lblTujec.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTujec.Location = new System.Drawing.Point(113, 137);
            this.lblTujec.Name = "lblTujec";
            this.lblTujec.Size = new System.Drawing.Size(11, 16);
            this.lblTujec.TabIndex = 9;
            this.lblTujec.Text = "/";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(113, 112);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(11, 16);
            this.lblTelefon.TabIndex = 8;
            this.lblTelefon.Text = "/";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(113, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(11, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "/";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            this.lblEmail.MouseHover += new System.EventHandler(this.lblEmail_MouseHover);
            // 
            // lblPriimek
            // 
            this.lblPriimek.AutoSize = true;
            this.lblPriimek.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriimek.Location = new System.Drawing.Point(113, 60);
            this.lblPriimek.Name = "lblPriimek";
            this.lblPriimek.Size = new System.Drawing.Size(11, 16);
            this.lblPriimek.TabIndex = 6;
            this.lblPriimek.Text = "/";
            // 
            // lblImeOsebe
            // 
            this.lblImeOsebe.AutoSize = true;
            this.lblImeOsebe.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeOsebe.Location = new System.Drawing.Point(113, 35);
            this.lblImeOsebe.Name = "lblImeOsebe";
            this.lblImeOsebe.Size = new System.Drawing.Size(11, 16);
            this.lblImeOsebe.TabIndex = 5;
            this.lblImeOsebe.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "TUJEC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-MAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRIIMEK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "IME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "IME PODJETJA:";
            // 
            // PregledPodjetje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 734);
            this.Controls.Add(this.gBoxPodjetje);
            this.MaximumSize = new System.Drawing.Size(450, 761);
            this.MinimumSize = new System.Drawing.Size(450, 761);
            this.Name = "PregledPodjetje";
            this.Text = "PregledPodjetje";
            this.Shown += new System.EventHandler(this.PregledPodjetje_Shown);
            this.gBoxPodjetje.ResumeLayout(false);
            this.gBoxPodjetje.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gBoxClani.ResumeLayout(false);
            this.gBoxKontaktna.ResumeLayout(false);
            this.gBoxKontaktna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxPodjetje;
        private System.Windows.Forms.GroupBox gBoxKontaktna;
        private System.Windows.Forms.Label lblImeOsebe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImePodjetja;
        private System.Windows.Forms.Label lblTujec;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPriimek;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lViewPartner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lViewNajem;
        private System.Windows.Forms.GroupBox gBoxClani;
        private System.Windows.Forms.ListView lViewClan;
        private System.Windows.Forms.ColumnHeader cHTip;
        private System.Windows.Forms.ColumnHeader cHDatumZac;
        private System.Windows.Forms.ColumnHeader cHDatumKon;
        private System.Windows.Forms.ColumnHeader cHOpis;
        private System.Windows.Forms.ColumnHeader chPartOd;
        private System.Windows.Forms.ColumnHeader cHPartDO;
        private System.Windows.Forms.ColumnHeader chNajemOd;
        private System.Windows.Forms.ColumnHeader cHNajemDo;
    }
}