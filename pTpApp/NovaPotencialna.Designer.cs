namespace pTpApp
{
    partial class NovaPotencialna
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
            this.lblStranka = new System.Windows.Forms.Label();
            this.pnlCBox = new System.Windows.Forms.Panel();
            this.cBoxStranke = new System.Windows.Forms.ComboBox();
            this.pnlChkB = new System.Windows.Forms.Panel();
            this.chkTretji = new System.Windows.Forms.CheckBox();
            this.chkDrugi = new System.Windows.Forms.CheckBox();
            this.chkPrvi = new System.Windows.Forms.CheckBox();
            this.lblPotencialna = new System.Windows.Forms.Label();
            this.btnPonastavi = new System.Windows.Forms.Button();
            this.btnUstvari = new System.Windows.Forms.Button();
            this.pnlLabel.SuspendLayout();
            this.pnlCBox.SuspendLayout();
            this.pnlChkB.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabel
            // 
            this.pnlLabel.Controls.Add(this.lblStranka);
            this.pnlLabel.Location = new System.Drawing.Point(13, 13);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(129, 74);
            this.pnlLabel.TabIndex = 0;
            // 
            // lblStranka
            // 
            this.lblStranka.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStranka.Location = new System.Drawing.Point(3, 16);
            this.lblStranka.Name = "lblStranka";
            this.lblStranka.Size = new System.Drawing.Size(123, 21);
            this.lblStranka.TabIndex = 1;
            this.lblStranka.Text = "Stranka";
            // 
            // pnlCBox
            // 
            this.pnlCBox.Controls.Add(this.cBoxStranke);
            this.pnlCBox.Location = new System.Drawing.Point(151, 13);
            this.pnlCBox.Name = "pnlCBox";
            this.pnlCBox.Size = new System.Drawing.Size(149, 74);
            this.pnlCBox.TabIndex = 1;
            // 
            // cBoxStranke
            // 
            this.cBoxStranke.FormattingEnabled = true;
            this.cBoxStranke.Location = new System.Drawing.Point(4, 16);
            this.cBoxStranke.Name = "cBoxStranke";
            this.cBoxStranke.Size = new System.Drawing.Size(142, 21);
            this.cBoxStranke.TabIndex = 0;
            this.cBoxStranke.SelectionChangeCommitted += new System.EventHandler(this.cBoxStranke_SelectionChangeCommitted);
            // 
            // pnlChkB
            // 
            this.pnlChkB.Controls.Add(this.chkTretji);
            this.pnlChkB.Controls.Add(this.chkDrugi);
            this.pnlChkB.Controls.Add(this.chkPrvi);
            this.pnlChkB.Controls.Add(this.lblPotencialna);
            this.pnlChkB.Location = new System.Drawing.Point(13, 102);
            this.pnlChkB.Name = "pnlChkB";
            this.pnlChkB.Size = new System.Drawing.Size(284, 74);
            this.pnlChkB.TabIndex = 2;
            // 
            // chkTretji
            // 
            this.chkTretji.AutoSize = true;
            this.chkTretji.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTretji.Location = new System.Drawing.Point(147, 51);
            this.chkTretji.Name = "chkTretji";
            this.chkTretji.Size = new System.Drawing.Size(120, 20);
            this.chkTretji.TabIndex = 6;
            this.chkTretji.Text = "Sola Podjetnistva";
            this.chkTretji.UseVisualStyleBackColor = true;
            // 
            // chkDrugi
            // 
            this.chkDrugi.AutoSize = true;
            this.chkDrugi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrugi.Location = new System.Drawing.Point(147, 30);
            this.chkDrugi.Name = "chkDrugi";
            this.chkDrugi.Size = new System.Drawing.Size(118, 20);
            this.chkDrugi.TabIndex = 5;
            this.chkDrugi.Text = "Business Meetup";
            this.chkDrugi.UseVisualStyleBackColor = true;
            // 
            // chkPrvi
            // 
            this.chkPrvi.AutoSize = true;
            this.chkPrvi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrvi.Location = new System.Drawing.Point(147, 6);
            this.chkPrvi.Name = "chkPrvi";
            this.chkPrvi.Size = new System.Drawing.Size(107, 20);
            this.chkPrvi.TabIndex = 4;
            this.chkPrvi.Text = "StartUp Vikend";
            this.chkPrvi.UseVisualStyleBackColor = true;
            // 
            // lblPotencialna
            // 
            this.lblPotencialna.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencialna.Location = new System.Drawing.Point(3, 5);
            this.lblPotencialna.Name = "lblPotencialna";
            this.lblPotencialna.Size = new System.Drawing.Size(129, 21);
            this.lblPotencialna.TabIndex = 3;
            this.lblPotencialna.Text = "Potencialna stranka";
            // 
            // btnPonastavi
            // 
            this.btnPonastavi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonastavi.Location = new System.Drawing.Point(207, 231);
            this.btnPonastavi.Name = "btnPonastavi";
            this.btnPonastavi.Size = new System.Drawing.Size(75, 30);
            this.btnPonastavi.TabIndex = 5;
            this.btnPonastavi.Text = "Ponastavi";
            this.btnPonastavi.UseVisualStyleBackColor = true;
            this.btnPonastavi.Click += new System.EventHandler(this.btnPonastavi_Click);
            // 
            // btnUstvari
            // 
            this.btnUstvari.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUstvari.Location = new System.Drawing.Point(126, 231);
            this.btnUstvari.Name = "btnUstvari";
            this.btnUstvari.Size = new System.Drawing.Size(75, 30);
            this.btnUstvari.TabIndex = 6;
            this.btnUstvari.Text = "Ustvari";
            this.btnUstvari.UseVisualStyleBackColor = true;
            this.btnUstvari.Click += new System.EventHandler(this.btnUstvari_Click);
            // 
            // NovaPotencialna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 273);
            this.Controls.Add(this.btnUstvari);
            this.Controls.Add(this.btnPonastavi);
            this.Controls.Add(this.pnlChkB);
            this.Controls.Add(this.pnlCBox);
            this.Controls.Add(this.pnlLabel);
            this.MaximumSize = new System.Drawing.Size(320, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "NovaPotencialna";
            this.Text = "Nova Potencialna";
            this.Shown += new System.EventHandler(this.NovaPotencialna_Shown);
            this.pnlLabel.ResumeLayout(false);
            this.pnlCBox.ResumeLayout(false);
            this.pnlChkB.ResumeLayout(false);
            this.pnlChkB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Panel pnlCBox;
        private System.Windows.Forms.Panel pnlChkB;
        private System.Windows.Forms.Button btnPonastavi;
        private System.Windows.Forms.Button btnUstvari;
        private System.Windows.Forms.Label lblStranka;
        private System.Windows.Forms.ComboBox cBoxStranke;
        private System.Windows.Forms.CheckBox chkTretji;
        private System.Windows.Forms.CheckBox chkDrugi;
        private System.Windows.Forms.CheckBox chkPrvi;
        private System.Windows.Forms.Label lblPotencialna;

    }
}