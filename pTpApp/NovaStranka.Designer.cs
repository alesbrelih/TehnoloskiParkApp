namespace pTpApp
{
    partial class NovaStranka
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
            this.pnlStrankaLabel = new System.Windows.Forms.Panel();
            this.lblPotencialna = new System.Windows.Forms.Label();
            this.lblPodjetje = new System.Windows.Forms.Label();
            this.lblStranka = new System.Windows.Forms.Label();
            this.pnlStrankaInput = new System.Windows.Forms.Panel();
            this.chkBoxPotencialna = new System.Windows.Forms.CheckBox();
            this.cBoxPodjetje = new System.Windows.Forms.ComboBox();
            this.cBoxStranka = new System.Windows.Forms.ComboBox();
            this.btnUstvariStr = new System.Windows.Forms.Button();
            this.btnPonastaviStr = new System.Windows.Forms.Button();
            this.pnlPotencial = new System.Windows.Forms.Panel();
            this.chkTretji = new System.Windows.Forms.CheckBox();
            this.chkDrugi = new System.Windows.Forms.CheckBox();
            this.chkPrvi = new System.Windows.Forms.CheckBox();
            this.pnlStrankaLabel.SuspendLayout();
            this.pnlStrankaInput.SuspendLayout();
            this.pnlPotencial.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStrankaLabel
            // 
            this.pnlStrankaLabel.Controls.Add(this.lblPotencialna);
            this.pnlStrankaLabel.Controls.Add(this.lblPodjetje);
            this.pnlStrankaLabel.Controls.Add(this.lblStranka);
            this.pnlStrankaLabel.Location = new System.Drawing.Point(12, 12);
            this.pnlStrankaLabel.Name = "pnlStrankaLabel";
            this.pnlStrankaLabel.Size = new System.Drawing.Size(160, 116);
            this.pnlStrankaLabel.TabIndex = 0;
            // 
            // lblPotencialna
            // 
            this.lblPotencialna.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotencialna.Location = new System.Drawing.Point(3, 95);
            this.lblPotencialna.Name = "lblPotencialna";
            this.lblPotencialna.Size = new System.Drawing.Size(154, 21);
            this.lblPotencialna.TabIndex = 2;
            this.lblPotencialna.Text = "Potencialna stranka";
            // 
            // lblPodjetje
            // 
            this.lblPodjetje.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodjetje.Location = new System.Drawing.Point(3, 64);
            this.lblPodjetje.Name = "lblPodjetje";
            this.lblPodjetje.Size = new System.Drawing.Size(154, 21);
            this.lblPodjetje.TabIndex = 1;
            this.lblPodjetje.Text = "Podjetje";
            // 
            // lblStranka
            // 
            this.lblStranka.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStranka.Location = new System.Drawing.Point(3, 32);
            this.lblStranka.Name = "lblStranka";
            this.lblStranka.Size = new System.Drawing.Size(154, 21);
            this.lblStranka.TabIndex = 0;
            this.lblStranka.Text = "Stranka";
            // 
            // pnlStrankaInput
            // 
            this.pnlStrankaInput.Controls.Add(this.chkBoxPotencialna);
            this.pnlStrankaInput.Controls.Add(this.cBoxPodjetje);
            this.pnlStrankaInput.Controls.Add(this.cBoxStranka);
            this.pnlStrankaInput.Location = new System.Drawing.Point(189, 12);
            this.pnlStrankaInput.Name = "pnlStrankaInput";
            this.pnlStrankaInput.Size = new System.Drawing.Size(157, 116);
            this.pnlStrankaInput.TabIndex = 1;
            // 
            // chkBoxPotencialna
            // 
            this.chkBoxPotencialna.AutoSize = true;
            this.chkBoxPotencialna.Location = new System.Drawing.Point(19, 98);
            this.chkBoxPotencialna.Name = "chkBoxPotencialna";
            this.chkBoxPotencialna.Size = new System.Drawing.Size(15, 14);
            this.chkBoxPotencialna.TabIndex = 2;
            this.chkBoxPotencialna.UseVisualStyleBackColor = true;
            this.chkBoxPotencialna.CheckedChanged += new System.EventHandler(this.chkBoxPotencialna_CheckedChanged);
            // 
            // cBoxPodjetje
            // 
            this.cBoxPodjetje.FormattingEnabled = true;
            this.cBoxPodjetje.Location = new System.Drawing.Point(19, 64);
            this.cBoxPodjetje.Name = "cBoxPodjetje";
            this.cBoxPodjetje.Size = new System.Drawing.Size(121, 21);
            this.cBoxPodjetje.TabIndex = 1;
            this.cBoxPodjetje.SelectionChangeCommitted += new System.EventHandler(this.cBoxPodjetje_SelectionChangeCommitted);
            // 
            // cBoxStranka
            // 
            this.cBoxStranka.FormattingEnabled = true;
            this.cBoxStranka.Location = new System.Drawing.Point(19, 32);
            this.cBoxStranka.Name = "cBoxStranka";
            this.cBoxStranka.Size = new System.Drawing.Size(121, 21);
            this.cBoxStranka.TabIndex = 0;
            this.cBoxStranka.SelectionChangeCommitted += new System.EventHandler(this.cBoxStranka_SelectionChangeCommitted);
            this.cBoxStranka.TabIndexChanged += new System.EventHandler(this.cBoxStranka_TabIndexChanged);
            // 
            // btnUstvariStr
            // 
            this.btnUstvariStr.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUstvariStr.Location = new System.Drawing.Point(180, 269);
            this.btnUstvariStr.Name = "btnUstvariStr";
            this.btnUstvariStr.Size = new System.Drawing.Size(75, 30);
            this.btnUstvariStr.TabIndex = 2;
            this.btnUstvariStr.Text = "Ustvari";
            this.btnUstvariStr.UseVisualStyleBackColor = true;
            this.btnUstvariStr.Click += new System.EventHandler(this.btnUstvariStr_Click);
            // 
            // btnPonastaviStr
            // 
            this.btnPonastaviStr.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonastaviStr.Location = new System.Drawing.Point(268, 269);
            this.btnPonastaviStr.Name = "btnPonastaviStr";
            this.btnPonastaviStr.Size = new System.Drawing.Size(75, 30);
            this.btnPonastaviStr.TabIndex = 3;
            this.btnPonastaviStr.Text = "Ponastavi";
            this.btnPonastaviStr.UseVisualStyleBackColor = true;
            this.btnPonastaviStr.Click += new System.EventHandler(this.btnPonastaviStr_Click);
            // 
            // pnlPotencial
            // 
            this.pnlPotencial.Controls.Add(this.chkTretji);
            this.pnlPotencial.Controls.Add(this.chkDrugi);
            this.pnlPotencial.Controls.Add(this.chkPrvi);
            this.pnlPotencial.Location = new System.Drawing.Point(13, 135);
            this.pnlPotencial.Name = "pnlPotencial";
            this.pnlPotencial.Size = new System.Drawing.Size(333, 104);
            this.pnlPotencial.TabIndex = 4;
            this.pnlPotencial.Visible = false;
            // 
            // chkTretji
            // 
            this.chkTretji.AutoSize = true;
            this.chkTretji.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTretji.Location = new System.Drawing.Point(195, 68);
            this.chkTretji.Name = "chkTretji";
            this.chkTretji.Size = new System.Drawing.Size(53, 20);
            this.chkTretji.TabIndex = 2;
            this.chkTretji.Text = "Tretji";
            this.chkTretji.UseVisualStyleBackColor = true;
            // 
            // chkDrugi
            // 
            this.chkDrugi.AutoSize = true;
            this.chkDrugi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDrugi.Location = new System.Drawing.Point(195, 42);
            this.chkDrugi.Name = "chkDrugi";
            this.chkDrugi.Size = new System.Drawing.Size(56, 20);
            this.chkDrugi.TabIndex = 1;
            this.chkDrugi.Text = "Drugi";
            this.chkDrugi.UseVisualStyleBackColor = true;
            // 
            // chkPrvi
            // 
            this.chkPrvi.AutoSize = true;
            this.chkPrvi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrvi.Location = new System.Drawing.Point(195, 16);
            this.chkPrvi.Name = "chkPrvi";
            this.chkPrvi.Size = new System.Drawing.Size(47, 20);
            this.chkPrvi.TabIndex = 0;
            this.chkPrvi.Text = "Prvi";
            this.chkPrvi.UseVisualStyleBackColor = true;
            // 
            // NovaStranka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 305);
            this.Controls.Add(this.pnlPotencial);
            this.Controls.Add(this.btnPonastaviStr);
            this.Controls.Add(this.btnUstvariStr);
            this.Controls.Add(this.pnlStrankaInput);
            this.Controls.Add(this.pnlStrankaLabel);
            this.MaximumSize = new System.Drawing.Size(366, 332);
            this.MinimumSize = new System.Drawing.Size(366, 332);
            this.Name = "NovaStranka";
            this.Text = "Nova Stranka";
            this.Load += new System.EventHandler(this.NovaStranka_Load);
            this.Shown += new System.EventHandler(this.NovaStranka_Shown);
            this.pnlStrankaLabel.ResumeLayout(false);
            this.pnlStrankaInput.ResumeLayout(false);
            this.pnlStrankaInput.PerformLayout();
            this.pnlPotencial.ResumeLayout(false);
            this.pnlPotencial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStrankaLabel;
        private System.Windows.Forms.Label lblPotencialna;
        private System.Windows.Forms.Label lblPodjetje;
        private System.Windows.Forms.Label lblStranka;
        private System.Windows.Forms.Panel pnlStrankaInput;
        private System.Windows.Forms.CheckBox chkBoxPotencialna;
        private System.Windows.Forms.ComboBox cBoxPodjetje;
        private System.Windows.Forms.ComboBox cBoxStranka;
        private System.Windows.Forms.Button btnUstvariStr;
        private System.Windows.Forms.Button btnPonastaviStr;
        private System.Windows.Forms.Panel pnlPotencial;
        private System.Windows.Forms.CheckBox chkTretji;
        private System.Windows.Forms.CheckBox chkDrugi;
        private System.Windows.Forms.CheckBox chkPrvi;
    }
}