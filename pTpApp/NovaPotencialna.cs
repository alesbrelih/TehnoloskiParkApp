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
    public partial class NovaPotencialna : Form
    {

        //Konstruktor
        public NovaPotencialna()
        {
            InitializeComponent();
        }


        //Klik na ponastavi
        private void btnPonastavi_Click(object sender, EventArgs e)
        {
            cBoxStranke.SelectedIndex = 0;
            chkPrvi.Checked = false;
            chkDrugi.Checked = false;
            chkTretji.Checked = false;
        }


        //Ko se okno prikaže
        private void NovaPotencialna_Shown(object sender, EventArgs e)
        {

            PrikaziOsebe();
        }


        /// <summary>
        /// Prikaze osebe v cBox
        /// </summary>
        private void PrikaziOsebe()
        {
            DataTable dT = DBconn.GetOsebe();
            cBoxStranke.DataSource = dT;
            cBoxStranke.DisplayMember = "ime";
            cBoxStranke.ValueMember = "osebaID";
        }


        /// <summary>
        /// Ustvari potencialno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUstvari_Click(object sender, EventArgs e)
        {
            Stranka _novaPotencialna = new Stranka(cBoxStranke.SelectedValue.ToString());
            _novaPotencialna.CreatePotencialno();

            int strankaID = DBconn.PoisciNaslednjiIDStranke();

            if (chkPrvi.Checked)
                _novaPotencialna.PotrdiTipPotencialne(1, strankaID);
            if (chkDrugi.Checked)
                _novaPotencialna.PotrdiTipPotencialne(2, strankaID);
            if (chkTretji.Checked)
                _novaPotencialna.PotrdiTipPotencialne(3, strankaID);

            //TODO IMPLEMENTING LIST DISPOSE
            List<TModel> _list = new List<TModel>();
            _list.Add(_novaPotencialna);
            _novaPotencialna.PotencialneStranke.ForEach(x => _list.Add(x));
            try
            {
                DBconn.RunNonQuery(_list);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                throw new Exception("BAD STUFF WITH POTENCIALNE STRANKE");
            }

        }

        
        /// <summary>
        /// Sprememba cbox oseb na stranki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxStranke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cBoxStranke.SelectedValue.ToString()=="new")
            {
                NovaOseba novaOseba = new NovaOseba();
                novaOseba.ShowDialog();
                if (novaOseba.DialogResult == DialogResult.OK)
                {
                    PrikaziOsebe();

                }
            }
        }
    }
}
