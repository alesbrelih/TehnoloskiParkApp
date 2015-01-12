namespace pTpApp
{
    partial class Partner
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
            this.lblPartnerstva = new System.Windows.Forms.Label();
            this.cBoxPartnerstva = new System.Windows.Forms.ComboBox();
            this.gBoxPartnerstvo = new System.Windows.Forms.GroupBox();
            this.btnPotrdi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTKonec = new System.Windows.Forms.DateTimePicker();
            this.DTZacetek = new System.Windows.Forms.DateTimePicker();
            this.RTBopis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPotrdiIzhod = new System.Windows.Forms.Button();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.gBoxPartnerstvo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPartnerstva
            // 
            this.lblPartnerstva.AutoSize = true;
            this.lblPartnerstva.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartnerstva.Location = new System.Drawing.Point(13, 13);
            this.lblPartnerstva.Name = "lblPartnerstva";
            this.lblPartnerstva.Size = new System.Drawing.Size(68, 16);
            this.lblPartnerstva.TabIndex = 0;
            this.lblPartnerstva.Text = "Partnerstva";
            // 
            // cBoxPartnerstva
            // 
            this.cBoxPartnerstva.FormattingEnabled = true;
            this.cBoxPartnerstva.Location = new System.Drawing.Point(106, 13);
            this.cBoxPartnerstva.Name = "cBoxPartnerstva";
            this.cBoxPartnerstva.Size = new System.Drawing.Size(271, 21);
            this.cBoxPartnerstva.TabIndex = 1;
            this.cBoxPartnerstva.SelectedIndexChanged += new System.EventHandler(this.cBoxPartnerstva_SelectedIndexChanged);
            // 
            // gBoxPartnerstvo
            // 
            this.gBoxPartnerstvo.Controls.Add(this.btnPotrdi);
            this.gBoxPartnerstvo.Controls.Add(this.label3);
            this.gBoxPartnerstvo.Controls.Add(this.label2);
            this.gBoxPartnerstvo.Controls.Add(this.DTKonec);
            this.gBoxPartnerstvo.Controls.Add(this.DTZacetek);
            this.gBoxPartnerstvo.Controls.Add(this.RTBopis);
            this.gBoxPartnerstvo.Controls.Add(this.label1);
            this.gBoxPartnerstvo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxPartnerstvo.Location = new System.Drawing.Point(16, 54);
            this.gBoxPartnerstvo.Name = "gBoxPartnerstvo";
            this.gBoxPartnerstvo.Size = new System.Drawing.Size(367, 282);
            this.gBoxPartnerstvo.TabIndex = 2;
            this.gBoxPartnerstvo.TabStop = false;
            this.gBoxPartnerstvo.Text = "Partnerstvo";
            // 
            // btnPotrdi
            // 
            this.btnPotrdi.Location = new System.Drawing.Point(10, 253);
            this.btnPotrdi.Name = "btnPotrdi";
            this.btnPotrdi.Size = new System.Drawing.Size(146, 23);
            this.btnPotrdi.TabIndex = 6;
            this.btnPotrdi.Text = "Potrdi spremembe";
            this.btnPotrdi.UseVisualStyleBackColor = true;
            this.btnPotrdi.Click += new System.EventHandler(this.btnPotrdi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Konec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Začetek";
            // 
            // DTKonec
            // 
            this.DTKonec.Location = new System.Drawing.Point(58, 196);
            this.DTKonec.Name = "DTKonec";
            this.DTKonec.Size = new System.Drawing.Size(303, 22);
            this.DTKonec.TabIndex = 3;
            // 
            // DTZacetek
            // 
            this.DTZacetek.Location = new System.Drawing.Point(58, 141);
            this.DTZacetek.Name = "DTZacetek";
            this.DTZacetek.Size = new System.Drawing.Size(303, 22);
            this.DTZacetek.TabIndex = 2;
            // 
            // RTBopis
            // 
            this.RTBopis.Location = new System.Drawing.Point(10, 40);
            this.RTBopis.Name = "RTBopis";
            this.RTBopis.Size = new System.Drawing.Size(351, 58);
            this.RTBopis.TabIndex = 1;
            this.RTBopis.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis";
            // 
            // btnPotrdiIzhod
            // 
            this.btnPotrdiIzhod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotrdiIzhod.Location = new System.Drawing.Point(26, 364);
            this.btnPotrdiIzhod.Name = "btnPotrdiIzhod";
            this.btnPotrdiIzhod.Size = new System.Drawing.Size(146, 23);
            this.btnPotrdiIzhod.TabIndex = 8;
            this.btnPotrdiIzhod.Text = "Potrdi in izhod";
            this.btnPotrdiIzhod.UseVisualStyleBackColor = true;
            this.btnPotrdiIzhod.Click += new System.EventHandler(this.btnPotrdiIzhod_Click);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzhod.Location = new System.Drawing.Point(231, 364);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(146, 23);
            this.btnIzhod.TabIndex = 9;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnIzhod_Click);
            // 
            // Partner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 399);
            this.Controls.Add(this.btnIzhod);
            this.Controls.Add(this.btnPotrdiIzhod);
            this.Controls.Add(this.gBoxPartnerstvo);
            this.Controls.Add(this.cBoxPartnerstva);
            this.Controls.Add(this.lblPartnerstva);
            this.MaximumSize = new System.Drawing.Size(403, 426);
            this.MinimumSize = new System.Drawing.Size(403, 426);
            this.Name = "Partner";
            this.Text = "Partner";
            this.Shown += new System.EventHandler(this.Partner_Shown);
            this.gBoxPartnerstvo.ResumeLayout(false);
            this.gBoxPartnerstvo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartnerstva;
        private System.Windows.Forms.ComboBox cBoxPartnerstva;
        private System.Windows.Forms.GroupBox gBoxPartnerstvo;
        private System.Windows.Forms.RichTextBox RTBopis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTKonec;
        private System.Windows.Forms.DateTimePicker DTZacetek;
        private System.Windows.Forms.Button btnPotrdi;
        private System.Windows.Forms.Button btnPotrdiIzhod;
        private System.Windows.Forms.Button btnIzhod;
    }
}