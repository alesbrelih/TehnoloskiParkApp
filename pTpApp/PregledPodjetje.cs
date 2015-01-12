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
using pTpApp.XObjects.OutLook;

namespace pTpApp
{
    public partial class PregledPodjetje : Form
    {
        private SQLiteConnection conn;
        public string idPodjetja = null;
        public PregledPodjetje()
        {
            InitializeComponent();
        }

        private void PregledPodjetje_Shown(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection("Data Source=pTpUpdate.sqlite;Version=3;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            IzpisiPodatke();
        }

        private void IzpisiPodatke()
        {
            conn.Open();
            string sql = "SELECT * FROM podjetje JOIN oseba ON (podjetje.kontaktOseba=oseba.osebaID) WHERE podjetjeID=" + idPodjetja + ";";
            using (SQLiteCommand ukaz = new SQLiteCommand(sql,conn))
            {
                SQLiteDataReader beri = ukaz.ExecuteReader();
                while (beri.Read())
                {
                    gBoxPodjetje.Text = "PODJETJE - " + beri["imePodjetja"];
                    lblImePodjetja.Text = beri["imePodjetja"].ToString();
                    lblImeOsebe.Text = beri["ime"].ToString();
                    lblPriimek.Text = beri["priimek"].ToString();
                    lblEmail.Text = beri["eMail"].ToString();
                    lblTelefon.Text = beri["telefon"].ToString();
                    NastaviTujec(beri["tujec"].ToString());
                }
            }
            conn.Close();
            NastaviClanstva();
            NastaviNajeme();
            NastaviPartnerje();
        }

        private void NastaviPartnerje()
        {
            string sql = "SELECT * FROM partner WHERE podjetje=" + idPodjetja + ";";
            conn.Open();
            using(SQLiteCommand ukaz = new SQLiteCommand(sql,conn))
            {
                SQLiteDataReader beri = ukaz.ExecuteReader();
                while (beri.Read())
                {
                    ListViewItem nov = new ListViewItem(beri["opis"].ToString());
                    nov.SubItems.Add(beri["datumZacPart"].ToString());
                    nov.SubItems.Add(beri["datumKonPart"].ToString());
                    lViewPartner.Items.Add(nov);
                }
            }
            conn.Close();
        }

        private void NastaviNajeme()
        {
            string sql = "SELECT * FROM najem WHERE podjetje=" + idPodjetja + ";";
            conn.Open();
            using(SQLiteCommand ukaz = new SQLiteCommand(sql,conn))
            {
                SQLiteDataReader beri = ukaz.ExecuteReader();
                while (beri.Read())
                {
                    ListViewItem nov = new ListViewItem(beri["datumZacNaj"].ToString());
                    nov.SubItems.Add(beri["datumKonNaj"].ToString());
                    lViewNajem.Items.Add(nov);
                }
            }
            conn.Close();
        }

        private void NastaviClanstva()
        {
            string sql = "SELECT * FROM clan JOIN tipClan ON (clan.tipClan=tipClan.tipClanID) WHERE podjetje =" + idPodjetja + ";";
            conn.Open();
            using (SQLiteCommand ukaz = new SQLiteCommand(sql,conn))
            {
                SQLiteDataReader beri = ukaz.ExecuteReader();
                while (beri.Read())
                {
                    ListViewItem nov = new ListViewItem(beri["tipClana"].ToString());
                    nov.SubItems.Add(beri["datumZacClan"].ToString());
                    nov.SubItems.Add(beri["datumKoncClan"].ToString());
                    lViewClan.Items.Add(nov);
                }
            }
            conn.Close();
        }

        private void NastaviTujec(string p)
        {
            if (p == "0")
                lblTujec.Text = "NE";
            if (p == "1")
                lblTujec.Text = "DA";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblEmail_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            Mail.Open(this.Text);
        }

    }
}
