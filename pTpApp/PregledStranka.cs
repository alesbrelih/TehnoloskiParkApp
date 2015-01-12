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
using pTpApp.XObjects.OutLook;

namespace pTpApp
{
    public partial class PregledStranka : Form
    {

        public string StrankaID { get; set; }


        public PregledStranka()
        {
            InitializeComponent();
        }

        private void PregledStranka_Shown(object sender, EventArgs e)
        {
            IzpisiPodatke();
        }

        private void IzpisiPodatke()
        {
            Stranka _prikaz = DBconn.GetStranka(StrankaID);
            gBoxStranka.Text = _prikaz.PoslOseba.Ime+" "+_prikaz.PoslOseba.Ime;
            lblIme.Text = _prikaz.PoslOseba.Ime; ;
            lblPriimek.Text = _prikaz.PoslOseba.Priimek;
            lblEmail.Text = _prikaz.PoslOseba.Email;
            lblTelefon.Text = _prikaz.PoslOseba.Telefon;
            NastaviTujec(_prikaz.PoslOseba.Tujec);

            if(_prikaz.PotencialneStranke.Count!=0)
            {
                lblPodjetje.Text = "/";
                lblPodjetje.Font = new Font(lblPodjetje.Font, FontStyle.Italic);
            }
            else
            {
                NastaviPodjetje(_prikaz.Podjetje);
            }
            

            NastaviPotencialno(_prikaz.PotencialneStranke);


           
        }

        private void NastaviPodjetje(Podjetje podjetje)
        {

            lblPodjetje.Text = podjetje.ImePodjetja;
            lblPodjetje.Click += delegate { PreglejPodjetje(podjetje.PodjetjeID); };
            lblPodjetje.MouseHover += delegate { Cursor.Current = Cursors.Hand; };
            

        }
        private void PreglejPodjetje(string podjetjeId)
        {
            PregledPodjetje podjetje = new PregledPodjetje();
            podjetje.idPodjetja = podjetjeId;
            podjetje.Show();
        }
        private void NastaviPotencialno(List<PotencialnaStranka> list)
        {
            if (list.Count==0)
                lblPotencialna.Text = "/";
            else
            {
                lblPotencialna.Text="";
                foreach(var item in list)
                {
                    if (lblPotencialna.Text.Length == 0)
                    {
                        lblPotencialna.Text += item.TipStranka.TipStra;
                    }
                    else
                    {
                        lblPotencialna.Text += (", " + item.TipStranka.TipStra);
                    }
                }

            }
                
        }

        private void NastaviTujec(string p)
        {
            if (p == "0")
                lblTujec.Text = "NE";
            else
                lblTujec.Text = "DA";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Hover preko emaila
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
