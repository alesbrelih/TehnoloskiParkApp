namespace pTpApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControlPrim = new System.Windows.Forms.TabControl();
            this.tabStranke = new System.Windows.Forms.TabPage();
            this.listViewStranke = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPodjetja = new System.Windows.Forms.TabPage();
            this.listViewPodjetja = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPotencialne = new System.Windows.Forms.TabPage();
            this.listViewPotencial = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabOsebe = new System.Windows.Forms.TabPage();
            this.listViewOsebe = new System.Windows.Forms.ListView();
            this.CHIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHPriimek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTujec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tBoxSearch = new System.Windows.Forms.TextBox();
            this.btnIsci = new System.Windows.Forms.Button();
            this.cMsPodrobnostStranka = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.podrobnostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMsPodjetje = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.podrobnostiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMsPodrobnostOseba = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.podrobnostiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlPrim.SuspendLayout();
            this.tabStranke.SuspendLayout();
            this.tabPodjetja.SuspendLayout();
            this.tabPotencialne.SuspendLayout();
            this.tabOsebe.SuspendLayout();
            this.cMsPodrobnostStranka.SuspendLayout();
            this.cMsPodjetje.SuspendLayout();
            this.cMsPodrobnostOseba.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrim
            // 
            this.tabControlPrim.Controls.Add(this.tabStranke);
            this.tabControlPrim.Controls.Add(this.tabPodjetja);
            this.tabControlPrim.Controls.Add(this.tabPotencialne);
            this.tabControlPrim.Controls.Add(this.tabOsebe);
            this.tabControlPrim.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPrim.Location = new System.Drawing.Point(12, 42);
            this.tabControlPrim.Name = "tabControlPrim";
            this.tabControlPrim.SelectedIndex = 0;
            this.tabControlPrim.Size = new System.Drawing.Size(459, 384);
            this.tabControlPrim.TabIndex = 0;
            this.tabControlPrim.SelectedIndexChanged += new System.EventHandler(this.tabControlPrim_SelectedIndexChanged);
            // 
            // tabStranke
            // 
            this.tabStranke.Controls.Add(this.listViewStranke);
            this.tabStranke.Location = new System.Drawing.Point(4, 25);
            this.tabStranke.Name = "tabStranke";
            this.tabStranke.Padding = new System.Windows.Forms.Padding(3);
            this.tabStranke.Size = new System.Drawing.Size(451, 355);
            this.tabStranke.TabIndex = 0;
            this.tabStranke.Text = "Vsi";
            this.tabStranke.UseVisualStyleBackColor = true;
            // 
            // listViewStranke
            // 
            this.listViewStranke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewStranke.FullRowSelect = true;
            this.listViewStranke.Location = new System.Drawing.Point(7, 6);
            this.listViewStranke.Name = "listViewStranke";
            this.listViewStranke.Size = new System.Drawing.Size(438, 343);
            this.listViewStranke.TabIndex = 0;
            this.listViewStranke.UseCompatibleStateImageBehavior = false;
            this.listViewStranke.View = System.Windows.Forms.View.Details;
            this.listViewStranke.SelectedIndexChanged += new System.EventHandler(this.listViewStranke_SelectedIndexChanged);
            this.listViewStranke.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewStranke_MouseClick);
            this.listViewStranke.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewStranke_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Priimek";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kontaktna Oseba";
            this.columnHeader4.Width = 147;
            // 
            // tabPodjetja
            // 
            this.tabPodjetja.Controls.Add(this.listViewPodjetja);
            this.tabPodjetja.Location = new System.Drawing.Point(4, 25);
            this.tabPodjetja.Name = "tabPodjetja";
            this.tabPodjetja.Padding = new System.Windows.Forms.Padding(3);
            this.tabPodjetja.Size = new System.Drawing.Size(451, 355);
            this.tabPodjetja.TabIndex = 1;
            this.tabPodjetja.Text = "Podjetja";
            this.tabPodjetja.UseVisualStyleBackColor = true;
            // 
            // listViewPodjetja
            // 
            this.listViewPodjetja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listViewPodjetja.FullRowSelect = true;
            this.listViewPodjetja.Location = new System.Drawing.Point(4, 4);
            this.listViewPodjetja.Name = "listViewPodjetja";
            this.listViewPodjetja.Size = new System.Drawing.Size(438, 343);
            this.listViewPodjetja.TabIndex = 0;
            this.listViewPodjetja.UseCompatibleStateImageBehavior = false;
            this.listViewPodjetja.View = System.Windows.Forms.View.Details;
            this.listViewPodjetja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPodjetja_MouseClick);
            this.listViewPodjetja.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPodjetja_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ime Podjetja";
            this.columnHeader6.Width = 202;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kontaktna Oseba";
            this.columnHeader7.Width = 211;
            // 
            // tabPotencialne
            // 
            this.tabPotencialne.Controls.Add(this.listViewPotencial);
            this.tabPotencialne.Location = new System.Drawing.Point(4, 25);
            this.tabPotencialne.Name = "tabPotencialne";
            this.tabPotencialne.Size = new System.Drawing.Size(451, 355);
            this.tabPotencialne.TabIndex = 2;
            this.tabPotencialne.Text = "Potencialne";
            this.tabPotencialne.UseVisualStyleBackColor = true;
            // 
            // listViewPotencial
            // 
            this.listViewPotencial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewPotencial.FullRowSelect = true;
            this.listViewPotencial.Location = new System.Drawing.Point(4, 4);
            this.listViewPotencial.Name = "listViewPotencial";
            this.listViewPotencial.Size = new System.Drawing.Size(438, 343);
            this.listViewPotencial.TabIndex = 0;
            this.listViewPotencial.UseCompatibleStateImageBehavior = false;
            this.listViewPotencial.View = System.Windows.Forms.View.Details;
            this.listViewPotencial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPotencial_MouseClick);
            this.listViewPotencial.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPotencial_MouseDoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ime";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Priimek";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "e-Mail";
            this.columnHeader11.Width = 153;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Telefonska";
            this.columnHeader12.Width = 102;
            // 
            // tabOsebe
            // 
            this.tabOsebe.Controls.Add(this.listViewOsebe);
            this.tabOsebe.Location = new System.Drawing.Point(4, 25);
            this.tabOsebe.Name = "tabOsebe";
            this.tabOsebe.Size = new System.Drawing.Size(451, 355);
            this.tabOsebe.TabIndex = 3;
            this.tabOsebe.Text = "Vse Osebe";
            this.tabOsebe.UseVisualStyleBackColor = true;
            // 
            // listViewOsebe
            // 
            this.listViewOsebe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHIme,
            this.CHPriimek,
            this.CHMail,
            this.CHTelefon,
            this.CHTujec});
            this.listViewOsebe.FullRowSelect = true;
            this.listViewOsebe.Location = new System.Drawing.Point(4, 4);
            this.listViewOsebe.Name = "listViewOsebe";
            this.listViewOsebe.Size = new System.Drawing.Size(438, 343);
            this.listViewOsebe.TabIndex = 0;
            this.listViewOsebe.UseCompatibleStateImageBehavior = false;
            this.listViewOsebe.View = System.Windows.Forms.View.Details;
            this.listViewOsebe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewOsebe_MouseClick);
            this.listViewOsebe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewOsebe_MouseDoubleClick);
            // 
            // CHIme
            // 
            this.CHIme.Text = "Ime";
            this.CHIme.Width = 80;
            // 
            // CHPriimek
            // 
            this.CHPriimek.Text = "Priimek";
            this.CHPriimek.Width = 101;
            // 
            // CHMail
            // 
            this.CHMail.Text = "eMail";
            this.CHMail.Width = 97;
            // 
            // CHTelefon
            // 
            this.CHTelefon.Text = "Telefon";
            this.CHTelefon.Width = 96;
            // 
            // CHTujec
            // 
            this.CHTujec.Text = "Tujec";
            this.CHTujec.Width = 49;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(489, 164);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(137, 38);
            this.btnIzbrisi.TabIndex = 3;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUredi.Location = new System.Drawing.Point(489, 111);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(137, 38);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(489, 67);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(137, 38);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(13, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 16);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Iskalni niz:";
            // 
            // tBoxSearch
            // 
            this.tBoxSearch.Location = new System.Drawing.Point(84, 12);
            this.tBoxSearch.Name = "tBoxSearch";
            this.tBoxSearch.Size = new System.Drawing.Size(189, 20);
            this.tBoxSearch.TabIndex = 2;
            this.tBoxSearch.TextChanged += new System.EventHandler(this.tBoxSearch_TextChanged);
            // 
            // btnIsci
            // 
            this.btnIsci.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsci.Location = new System.Drawing.Point(329, 13);
            this.btnIsci.Name = "btnIsci";
            this.btnIsci.Size = new System.Drawing.Size(142, 23);
            this.btnIsci.TabIndex = 6;
            this.btnIsci.Text = "Išči";
            this.btnIsci.UseVisualStyleBackColor = true;
            this.btnIsci.Click += new System.EventHandler(this.btnIsci_Click);
            // 
            // cMsPodrobnostStranka
            // 
            this.cMsPodrobnostStranka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podrobnostiToolStripMenuItem});
            this.cMsPodrobnostStranka.Name = "cMsPodrobnost";
            this.cMsPodrobnostStranka.Size = new System.Drawing.Size(132, 26);
            // 
            // podrobnostiToolStripMenuItem
            // 
            this.podrobnostiToolStripMenuItem.Name = "podrobnostiToolStripMenuItem";
            this.podrobnostiToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.podrobnostiToolStripMenuItem.Text = "Podrobnosti";
            this.podrobnostiToolStripMenuItem.Click += new System.EventHandler(this.podrobnostiToolStripMenuItem_Click);
            // 
            // cMsPodjetje
            // 
            this.cMsPodjetje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podrobnostiToolStripMenuItem1});
            this.cMsPodjetje.Name = "cMsPodjetje";
            this.cMsPodjetje.Size = new System.Drawing.Size(132, 26);
            // 
            // podrobnostiToolStripMenuItem1
            // 
            this.podrobnostiToolStripMenuItem1.Name = "podrobnostiToolStripMenuItem1";
            this.podrobnostiToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.podrobnostiToolStripMenuItem1.Text = "Podrobnosti";
            this.podrobnostiToolStripMenuItem1.Click += new System.EventHandler(this.podrobnostiToolStripMenuItem1_Click);
            // 
            // cMsPodrobnostOseba
            // 
            this.cMsPodrobnostOseba.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podrobnostiToolStripMenuItem2});
            this.cMsPodrobnostOseba.Name = "cMsPodrobnostOseba";
            this.cMsPodrobnostOseba.Size = new System.Drawing.Size(132, 26);
            // 
            // podrobnostiToolStripMenuItem2
            // 
            this.podrobnostiToolStripMenuItem2.Name = "podrobnostiToolStripMenuItem2";
            this.podrobnostiToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.podrobnostiToolStripMenuItem2.Text = "Podrobnosti";
            this.podrobnostiToolStripMenuItem2.Click += new System.EventHandler(this.podrobnostiToolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 438);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnIsci);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.tBoxSearch);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tabControlPrim);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(471, 465);
            this.Name = "Form1";
            this.Text = "PTP - App";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControlPrim.ResumeLayout(false);
            this.tabStranke.ResumeLayout(false);
            this.tabPodjetja.ResumeLayout(false);
            this.tabPotencialne.ResumeLayout(false);
            this.tabOsebe.ResumeLayout(false);
            this.cMsPodrobnostStranka.ResumeLayout(false);
            this.cMsPodjetje.ResumeLayout(false);
            this.cMsPodrobnostOseba.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrim;
        private System.Windows.Forms.TabPage tabStranke;
        private System.Windows.Forms.TabPage tabPodjetja;
        private System.Windows.Forms.TabPage tabPotencialne;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tBoxSearch;
        private System.Windows.Forms.Button btnIsci;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView listViewStranke;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewPodjetja;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listViewPotencial;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ContextMenuStrip cMsPodrobnostStranka;
        private System.Windows.Forms.ToolStripMenuItem podrobnostiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMsPodjetje;
        private System.Windows.Forms.ToolStripMenuItem podrobnostiToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabOsebe;
        private System.Windows.Forms.ListView listViewOsebe;
        private System.Windows.Forms.ColumnHeader CHIme;
        private System.Windows.Forms.ColumnHeader CHPriimek;
        private System.Windows.Forms.ColumnHeader CHMail;
        private System.Windows.Forms.ColumnHeader CHTelefon;
        private System.Windows.Forms.ColumnHeader CHTujec;
        private System.Windows.Forms.ContextMenuStrip cMsPodrobnostOseba;
        private System.Windows.Forms.ToolStripMenuItem podrobnostiToolStripMenuItem2;
    }
}

