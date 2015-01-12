namespace pTpApp
{
    partial class Clanstvo
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
            this.pnlClan = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPotrdi = new System.Windows.Forms.Button();
            this.cBoxTip = new System.Windows.Forms.ComboBox();
            this.lblTipClanstva = new System.Windows.Forms.Label();
            this.DTKonec = new System.Windows.Forms.DateTimePicker();
            this.DTZacetek = new System.Windows.Forms.DateTimePicker();
            this.lblClanstvo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxClanstva = new System.Windows.Forms.ComboBox();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.btnPotrdiIzhod = new System.Windows.Forms.Button();
            this.pnlClan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClan
            // 
            this.pnlClan.Controls.Add(this.label3);
            this.pnlClan.Controls.Add(this.label2);
            this.pnlClan.Controls.Add(this.btnPotrdi);
            this.pnlClan.Controls.Add(this.cBoxTip);
            this.pnlClan.Controls.Add(this.lblTipClanstva);
            this.pnlClan.Controls.Add(this.DTKonec);
            this.pnlClan.Controls.Add(this.DTZacetek);
            this.pnlClan.Controls.Add(this.lblClanstvo);
            this.pnlClan.Location = new System.Drawing.Point(16, 49);
            this.pnlClan.Name = "pnlClan";
            this.pnlClan.Size = new System.Drawing.Size(308, 206);
            this.pnlClan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Konec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Začetek";
            // 
            // btnPotrdi
            // 
            this.btnPotrdi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotrdi.Location = new System.Drawing.Point(18, 169);
            this.btnPotrdi.Name = "btnPotrdi";
            this.btnPotrdi.Size = new System.Drawing.Size(121, 23);
            this.btnPotrdi.TabIndex = 6;
            this.btnPotrdi.Text = "Potrdi spremembe";
            this.btnPotrdi.UseVisualStyleBackColor = true;
            this.btnPotrdi.Click += new System.EventHandler(this.btnPotrdi_Click);
            // 
            // cBoxTip
            // 
            this.cBoxTip.FormattingEnabled = true;
            this.cBoxTip.Location = new System.Drawing.Point(106, 18);
            this.cBoxTip.Name = "cBoxTip";
            this.cBoxTip.Size = new System.Drawing.Size(167, 21);
            this.cBoxTip.TabIndex = 4;
            // 
            // lblTipClanstva
            // 
            this.lblTipClanstva.AutoSize = true;
            this.lblTipClanstva.Location = new System.Drawing.Point(15, 21);
            this.lblTipClanstva.Name = "lblTipClanstva";
            this.lblTipClanstva.Size = new System.Drawing.Size(22, 13);
            this.lblTipClanstva.TabIndex = 3;
            this.lblTipClanstva.Text = "Tip";
            // 
            // DTKonec
            // 
            this.DTKonec.Location = new System.Drawing.Point(106, 118);
            this.DTKonec.Name = "DTKonec";
            this.DTKonec.Size = new System.Drawing.Size(167, 20);
            this.DTKonec.TabIndex = 2;
            // 
            // DTZacetek
            // 
            this.DTZacetek.Location = new System.Drawing.Point(106, 67);
            this.DTZacetek.Name = "DTZacetek";
            this.DTZacetek.Size = new System.Drawing.Size(167, 20);
            this.DTZacetek.TabIndex = 1;
            // 
            // lblClanstvo
            // 
            this.lblClanstvo.AutoSize = true;
            this.lblClanstvo.Location = new System.Drawing.Point(41, 0);
            this.lblClanstvo.Name = "lblClanstvo";
            this.lblClanstvo.Size = new System.Drawing.Size(48, 13);
            this.lblClanstvo.TabIndex = 0;
            this.lblClanstvo.Text = "Članstvo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Članstva";
            // 
            // cBoxClanstva
            // 
            this.cBoxClanstva.FormattingEnabled = true;
            this.cBoxClanstva.Location = new System.Drawing.Point(67, 12);
            this.cBoxClanstva.Name = "cBoxClanstva";
            this.cBoxClanstva.Size = new System.Drawing.Size(257, 21);
            this.cBoxClanstva.TabIndex = 5;
            this.cBoxClanstva.SelectionChangeCommitted += new System.EventHandler(this.cBoxClanstva_SelectionChangeCommitted);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzhod.Location = new System.Drawing.Point(168, 270);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(121, 23);
            this.btnIzhod.TabIndex = 7;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnIzhod_Click);
            // 
            // btnPotrdiIzhod
            // 
            this.btnPotrdiIzhod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotrdiIzhod.Location = new System.Drawing.Point(34, 270);
            this.btnPotrdiIzhod.Name = "btnPotrdiIzhod";
            this.btnPotrdiIzhod.Size = new System.Drawing.Size(121, 23);
            this.btnPotrdiIzhod.TabIndex = 8;
            this.btnPotrdiIzhod.Text = "Potrdi in izhod";
            this.btnPotrdiIzhod.UseVisualStyleBackColor = true;
            this.btnPotrdiIzhod.Click += new System.EventHandler(this.btnPotrdiIzhod_Click);
            // 
            // Clanstvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 322);
            this.Controls.Add(this.btnPotrdiIzhod);
            this.Controls.Add(this.btnIzhod);
            this.Controls.Add(this.cBoxClanstva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlClan);
            this.MaximumSize = new System.Drawing.Size(357, 349);
            this.MinimumSize = new System.Drawing.Size(357, 349);
            this.Name = "Clanstvo";
            this.Text = "Clanstvo";
            this.Load += new System.EventHandler(this.Clanstvo_Load);
            this.Shown += new System.EventHandler(this.Clanstvo_Shown);
            this.pnlClan.ResumeLayout(false);
            this.pnlClan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlClan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxTip;
        private System.Windows.Forms.Label lblTipClanstva;
        private System.Windows.Forms.DateTimePicker DTKonec;
        private System.Windows.Forms.DateTimePicker DTZacetek;
        private System.Windows.Forms.Label lblClanstvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxClanstva;
        private System.Windows.Forms.Button btnPotrdi;
        private System.Windows.Forms.Button btnIzhod;
        private System.Windows.Forms.Button btnPotrdiIzhod;
    }
}