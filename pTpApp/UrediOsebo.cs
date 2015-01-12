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
using pTpApp.XObjects.Tables;
using pTpApp.XObjects.DBmodels;

namespace pTpApp
{
    public partial class UrediOsebo : Form
    {
        public string OsebaID { get; set; }
        internal Oseba Oseba = null;
        public UrediOsebo()
        {
            InitializeComponent();
        }

        private void UrediOsebo_Load(object sender, EventArgs e)
        {
            

            
        }

        private Oseba NastaviOsebo(string osebaID)
        {
            Oseba = DBconn.GetOseba(osebaID);
            tBoxIme.Text = Oseba.Ime;
            tBoxPriimek.Text = Oseba.Priimek;
            tBoxTelefon.Text = Oseba.Telefon;
            tBoxMail.Text = Oseba.Email;
            chkTujec.Checked = (Oseba.Tujec == "0") ? false : true;
            return DBconn.GetOseba(osebaID);
            
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            PosodobiPolja(Oseba);
            Oseba.Update();
            try
            {
                DBconn.RunNonQuery(Oseba);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                throw new Exception("BAD STUFF OSEBA UPDATE");
            }
   
        }

        private void PosodobiPolja(XObjects.Tables.Oseba Oseba)
        {
            Oseba.Ime = tBoxIme.Text;
            Oseba.Priimek = tBoxPriimek.Text;
            Oseba.Email = tBoxMail.Text;
            Oseba.Telefon = tBoxTelefon.Text;
            Oseba.Tujec = UgotoviChecked();
            
        }

        private string UgotoviChecked()
        {
            if (chkTujec.Checked == true)
                return "1";
            return "0";
        }

        private void btnPreklici_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void UrediOsebo_Shown(object sender, EventArgs e)
        {
            
            NastaviOsebo(OsebaID);
        }
    }
}
