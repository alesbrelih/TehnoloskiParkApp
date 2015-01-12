using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using pTpApp.XObjects.DBmodels;
using pTpApp.XObjects.Tables;
using Outlook = Microsoft.Office.Interop.Outlook;
using pTpApp.XObjects.OutLook;

namespace pTpApp
{
    public partial class PregledOseba : Form
    {

        public string OsebaID { get; set; }
        public PregledOseba()
        {
            InitializeComponent();
        }

        private void PregledOseba_Shown(object sender, EventArgs e)
        {
            
            PrikaziPodatke();
        }

        private void PrikaziPodatke()
        {
            Oseba _prikaz = DBconn.GetOseba(OsebaID);


            lblIme.Text = _prikaz.Ime;
            lblPriimek.Text = _prikaz.Priimek;
            lblMail.Text = _prikaz.Email;
            lblTelefon.Text = _prikaz.Telefon;
            lblTujec.Text = IzpisiTujec(_prikaz.Tujec);

        }

        private string IzpisiTujec(string tujec)
        {
            if (tujec == "0")
                return "NE";
            return "DA";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMail_Click(object sender, EventArgs e)
        {
            Mail.Open(this.Text);
        }


        private void lblMail_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        
    }
}
