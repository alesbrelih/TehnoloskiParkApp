using pTpApp.XObjects.DBmodels;
using pTpApp.XObjects.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pTpApp
{
    public partial class NovaStranka : Form
    {

        /// <summary>
        /// Konstruktor
        /// </summary>
        public NovaStranka()
        {
            InitializeComponent();
        }



        /// <summary>
        /// prikazi form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NovaStranka_Shown(object sender, EventArgs e)
        {
            
            PrikaziPodatke();
        }


        /// <summary>
        /// prikaže podatke v comboBoxih
        /// </summary>
        private void PrikaziPodatke()
        {

            PrikaziOsebe();
            PrikaziPodjetja();

        }


        /// <summary>
        /// Prikaze stranke v comboBoxu
        /// </summary>
        private void PrikaziPodjetja()
        {

            cBoxPodjetje.DataSource = DBconn.GetPodjetja();
            cBoxPodjetje.DisplayMember = "imePodjetje";
            cBoxPodjetje.ValueMember = "podjetjeID";
            
            
        }


        /// <summary>
        /// prikaze podjetja v comboBoxu
        /// </summary>
        private void PrikaziOsebe()
        {
            
            cBoxStranka.DataSource = DBconn.GetOsebe();
            cBoxStranka.DisplayMember = "ime";
            cBoxStranka.ValueMember = "osebaID";
            
        }

        private void NovaStranka_Load(object sender, EventArgs e)
        {

        }


        //Klik na chkBox potencialna - ali je opravek z potencialno ali podjetjem
        private void chkBoxPotencialna_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxPotencialna.Checked == true)
            {
                pnlPotencial.Visible = true;
                cBoxPodjetje.Enabled = false;
            }
                
            else
            {
                pnlPotencial.Visible = false;
                cBoxPodjetje.Enabled = true;

            }
                
        }


        /// <summary>
        /// Ponastavi vse podatke - klik na gumb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPonastaviStr_Click(object sender, EventArgs e)
        {
            chkBoxPotencialna.Checked = false;
            cBoxStranka.SelectedIndex = 0;
            cBoxPodjetje.SelectedIndex = 0;
        }


        //Dodajanje nove osebe preko okna stranke


        private void cBoxStranka_TabIndexChanged(object sender, EventArgs e)
        {
            if (cBoxStranka.SelectedText == "Nova Oseba...")
                DodajOsebo();
        }

        /// <summary>
        /// Doda novo osebo
        /// </summary>
        private void DodajOsebo()
        {
            NovaOseba novaOseba = new NovaOseba();
            novaOseba.ShowDialog();
            if (novaOseba.DialogResult == DialogResult.OK)
            {
                PrikaziOsebe();
            }
        }


        /// <summary>
        /// Dodajanje novo osebe preko stranke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxStranka_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBoxStranka.SelectedIndex==cBoxStranka.Items.Count-1)
                DodajOsebo();

        }

        //
        private void cBoxPodjetje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBoxPodjetje.SelectedIndex == cBoxPodjetje.Items.Count - 1)
                DodajPodjetje();
        }
        /// <summary>
        /// Doda novo podjetje
        /// </summary>
        private void DodajPodjetje()
        {
            NovoPodjetje novoPodjetje = new NovoPodjetje();
            novoPodjetje.ShowDialog();
            if (novoPodjetje.DialogResult == DialogResult.OK)
            {
                PrikaziPodjetja();
            }
        }

        private void btnUstvariStr_Click(object sender, EventArgs e)
        {



            if (!chkBoxPotencialna.Checked)
            {
                using (Stranka _novaStranka = new Stranka(cBoxStranka.SelectedValue.ToString(), cBoxPodjetje.SelectedValue.ToString(),true))
                {
                    _novaStranka.CreatePodjetje();

                    DBconn.RunNonQuery(_novaStranka);
                }

            }

            else
            {
                using (Stranka _novaStranka = new Stranka(cBoxStranka.SelectedValue.ToString()))
                {
                    int stStranke = DBconn.PoisciNaslednjiIDStranke();
                    _novaStranka.CreatePotencialno();

                    if (chkPrvi.Checked)
                    {
                        _novaStranka.PotrdiTipPotencialne(1,stStranke);
                    }
                    if (chkDrugi.Checked)
                    {
                        _novaStranka.PotrdiTipPotencialne(2,stStranke);
                    }
                    if (chkTretji.Checked)
                    {
                        _novaStranka.PotrdiTipPotencialne(3,stStranke);
                    }
                    List<TModel> _list = new List<TModel>();
                    _list.Add(_novaStranka);
                    _novaStranka.PotencialneStranke.ForEach(x => _list.Add(x));
                    DBconn.RunNonQuery(_list);
                }

                
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
