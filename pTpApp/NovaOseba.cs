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

namespace pTpApp
{
    public partial class NovaOseba : Form
    {
        public NovaOseba()
        {
            InitializeComponent();
        }


        //Ponastavi polja
        private void btnPonastavi_Click(object sender, EventArgs e)
        {
            Ponastavi();
        }

        /// <summary>
        /// Ponastavi vrednosti v formi
        /// </summary>
        private void Ponastavi()
        {
            tBoxIme.Clear();
            tBoxPriimek.Clear();
            tBoxMail.Clear();
            tBoxTelefon.Clear();
            chkTujec.Checked = false;
        }


        //Ustvari osebo
        private void btnUstvari_Click(object sender, EventArgs e)
        {

            Oseba _oseba = UstvariModel();
            DBconn.RunNonQuery(_oseba);

            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        /// <summary>
        /// Ustvari model z ustreznimi podatki za oseba
        /// </summary>
        /// <returns></returns>
        private Oseba UstvariModel()
        {
            string ime = tBoxIme.Text;
            string priimek = tBoxPriimek.Text;
            string email = tBoxMail.Text;
            string telefon = tBoxTelefon.Text;
            int tujec;
            if (chkTujec.Checked == true)
                tujec = 1;
            else
                tujec = 0;

            Oseba _oseba = new Oseba(ime,priimek,telefon,email,tujec.ToString());
            _oseba.Create();

            return _oseba;
        }

        //Load
        private void NovaOseba_Shown(object sender, EventArgs e)
        {

        }
    }
}
