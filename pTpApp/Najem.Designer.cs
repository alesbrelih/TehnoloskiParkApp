namespace pTpApp
{
    partial class Najem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxNajemi = new System.Windows.Forms.ComboBox();
            this.gBoxNajemi = new System.Windows.Forms.GroupBox();
            this.btnPotrdi = new System.Windows.Forms.Button();
            this.DTKonec = new System.Windows.Forms.DateTimePicker();
            this.DTZacetek = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPotrdiIzhod = new System.Windows.Forms.Button();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.gBoxNajemi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Najemi";
            // 
            // cBoxNajemi
            // 
            this.cBoxNajemi.FormattingEnabled = true;
            this.cBoxNajemi.Location = new System.Drawing.Point(75, 12);
            this.cBoxNajemi.Name = "cBoxNajemi";
            this.cBoxNajemi.Size = new System.Drawing.Size(265, 21);
            this.cBoxNajemi.TabIndex = 1;
            this.cBoxNajemi.SelectedIndexChanged += new System.EventHandler(this.cBoxNajemi_SelectedIndexChanged);
            this.cBoxNajemi.SelectionChangeCommitted += new System.EventHandler(this.cBoxNajemi_SelectionChangeCommitted);
            // 
            // gBoxNajemi
            // 
            this.gBoxNajemi.Controls.Add(this.btnPotrdi);
            this.gBoxNajemi.Controls.Add(this.DTKonec);
            this.gBoxNajemi.Controls.Add(this.DTZacetek);
            this.gBoxNajemi.Controls.Add(this.label3);
            this.gBoxNajemi.Controls.Add(this.label2);
            this.gBoxNajemi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxNajemi.Location = new System.Drawing.Point(16, 49);
            this.gBoxNajemi.Name = "gBoxNajemi";
            this.gBoxNajemi.Size = new System.Drawing.Size(330, 152);
            this.gBoxNajemi.TabIndex = 2;
            this.gBoxNajemi.TabStop = false;
            this.gBoxNajemi.Text = "Najem";
            // 
            // btnPotrdi
            // 
            this.btnPotrdi.Location = new System.Drawing.Point(9, 123);
            this.btnPotrdi.Name = "btnPotrdi";
            this.btnPotrdi.Size = new System.Drawing.Size(122, 23);
            this.btnPotrdi.TabIndex = 4;
            this.btnPotrdi.Text = "Potrdi spremembe";
            this.btnPotrdi.UseVisualStyleBackColor = true;
            this.btnPotrdi.Click += new System.EventHandler(this.btnPotrdi_Click);
            // 
            // DTKonec
            // 
            this.DTKonec.Location = new System.Drawing.Point(59, 69);
            this.DTKonec.Name = "DTKonec";
            this.DTKonec.Size = new System.Drawing.Size(265, 22);
            this.DTKonec.TabIndex = 3;
            // 
            // DTZacetek
            // 
            this.DTZacetek.Location = new System.Drawing.Point(59, 30);
            this.DTZacetek.Name = "DTZacetek";
            this.DTZacetek.Size = new System.Drawing.Size(265, 22);
            this.DTZacetek.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Konec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Začetek";
            // 
            // btnPotrdiIzhod
            // 
            this.btnPotrdiIzhod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotrdiIzhod.Location = new System.Drawing.Point(25, 238);
            this.btnPotrdiIzhod.Name = "btnPotrdiIzhod";
            this.btnPotrdiIzhod.Size = new System.Drawing.Size(122, 23);
            this.btnPotrdiIzhod.TabIndex = 5;
            this.btnPotrdiIzhod.Text = "Potrdi in izhod";
            this.btnPotrdiIzhod.UseVisualStyleBackColor = true;
            this.btnPotrdiIzhod.Click += new System.EventHandler(this.btnPotrdiIzhod_Click);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzhod.Location = new System.Drawing.Point(218, 238);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(122, 23);
            this.btnIzhod.TabIndex = 6;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnIzhod_Click);
            // 
            // Najem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 299);
            this.Controls.Add(this.btnIzhod);
            this.Controls.Add(this.btnPotrdiIzhod);
            this.Controls.Add(this.gBoxNajemi);
            this.Controls.Add(this.cBoxNajemi);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(366, 326);
            this.MinimumSize = new System.Drawing.Size(366, 326);
            this.Name = "Najem";
            this.Text = "Najem";
            this.Load += new System.EventHandler(this.Najem_Load);
            this.Shown += new System.EventHandler(this.Najem_Shown);
            this.gBoxNajemi.ResumeLayout(false);
            this.gBoxNajemi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxNajemi;
        private System.Windows.Forms.GroupBox gBoxNajemi;
        private System.Windows.Forms.Button btnPotrdi;
        private System.Windows.Forms.DateTimePicker DTKonec;
        private System.Windows.Forms.DateTimePicker DTZacetek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPotrdiIzhod;
        private System.Windows.Forms.Button btnIzhod;
    }
}