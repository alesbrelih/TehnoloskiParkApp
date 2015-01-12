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
using NetOffice;

namespace pTpApp
{
    public partial class UrediStranko : Form
    {
       
        public string StrankaID { get; set; }
        private Stranka StrankaModel;

        public UrediStranko()
        {
            InitializeComponent();
            
        }

        private void UrediStranko_Load(object sender, EventArgs e)
        {
            
        }

        private void UrediStranko_Shown(object sender, EventArgs e)
        {
            
            PokaziOsebe();
            PokaziPodjetja();
            NastaviStranko();

        }


        /// <summary>
        /// izbere ustrezne iteme v comboboxih glede na izbiro, ki jo želimo
        /// </summary>
        private void NastaviStranko()
        {
            StrankaModel = DBconn.GetStranka(StrankaID);
            
            NastaviPolja(StrankaModel);
        }

        //NastaviTxtBoxe in stuff
        private void NastaviPolja(XObjects.Tables.Stranka Stranka)
        {
            PonastaviVse();
            cBoxImePriimek.SelectedValue = Stranka.PoslOsebaID;
            
            //NRDI DA NE MORE BIT POTENCIALNA BREZ TIPA POTENCIALNCE USAJ ENGA?! TODOTODO
            if(Stranka.PotencialneStranke.Count==0)
            {
                NastaviIzpisPodjetje(Stranka);
            }
            else
            {
                NastaviIzpisPotencialna();
                
            }
        }

        private void PonastaviVse()
        {
            chkPrvi.Checked = false;
            chkDrugi.Checked = false;
            chkTretji.Checked = false;
        }

        private void NastaviIzpisPodjetje(Stranka _stranka)
        {
            cBoxPodjetje.Enabled = true;
            chkPotencialna.Checked = false;
            cBoxPodjetje.SelectedValue = _stranka.PodjetjeID;
            gBoxTip.Enabled = false;
            
        }
        private void NastaviIzpisPotencialna()
        {
            
            cBoxPodjetje.Enabled = false;
            chkPotencialna.Checked = true;
            IzberiPotencialne();
        }

        private void IzberiPotencialne()
        {
            foreach(var potStr in StrankaModel.PotencialneStranke)
            {
                if (potStr.TipStrankaID == "1")
                    chkPrvi.Checked = true;
                if (potStr.TipStrankaID == "2")
                    chkDrugi.Checked = true;
                if (potStr.TipStrankaID == "3")
                    chkTretji.Checked = true;
            }

        }

        #region showStuff
        private void PokaziPodjetja()
        {
            DataTable dT = DBconn.GetPodjetja();
            cBoxPodjetje.DataSource = dT;
            cBoxPodjetje.DisplayMember = "imePodjetje";
            cBoxPodjetje.ValueMember = "podjetjeID";
        }

        private void PokaziOsebe()
        {

            DataTable dT = DBconn.GetOsebe();
            cBoxImePriimek.DataSource = dT;
            cBoxImePriimek.DisplayMember = "ime";
            cBoxImePriimek.ValueMember = "osebaID";
        }
        #endregion

        #region podrobnosti
        private void podrobnostOseba_Click(object sender, EventArgs e)
        {
            UrediOsebo urediOsebo = new UrediOsebo();
            urediOsebo.OsebaID = cBoxImePriimek.SelectedValue.ToString();
            urediOsebo.ShowDialog();
            if (urediOsebo.DialogResult==DialogResult.OK)
            {
                PokaziOsebe();
                cBoxImePriimek.SelectedValue = StrankaModel.PoslOsebaID;
            }
        }

        private void podrobnostPodjetje_Click(object sender, EventArgs e)
        {
            NovoPodjetje urediPodjetje = new NovoPodjetje();
            urediPodjetje.PodjetjeID = cBoxPodjetje.SelectedValue.ToString();
            urediPodjetje.ShowDialog();
            if (urediPodjetje.DialogResult==DialogResult.OK)
            {
                PokaziPodjetja();
                cBoxPodjetje.SelectedValue = StrankaModel.PodjetjeID;
            }
        }

        #endregion

        /// <summary>
        /// gumb nastavi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PreveriPolja();
            PosodobiStranko(StrankaModel);
            List<TModel> _list = new List<TModel>();
            _list.Add(StrankaModel);
            StrankaModel.PotencialneStranke.ForEach(x => _list.Add(x));

                DBconn.RunNonQuery(_list);
                this.DialogResult = DialogResult.OK;
                this.Close();


            //catch
            //{
            //    throw new Exception("BAD STUFF WITH STRANKA UPDATE");
            //}
            
        }

        private void PosodobiStranko(XObjects.Tables.Stranka Stranka)
        {
            StrankaModel.PoslOsebaID = cBoxImePriimek.SelectedValue.ToString();

            //Imamo Podjetje
            if(chkPotencialna.Checked==false)
            {
                StrankaModel.PodjetjeID = cBoxPodjetje.SelectedValue.ToString();
                StrankaModel.OdstraniTipPotencialne(true);
            }
            else
            {
                StrankaModel.PodjetjeID = null;
                if (chkPrvi.Checked)
                    StrankaModel.PotrdiTipPotencialne(1);
                if (chkDrugi.Checked)
                    StrankaModel.PotrdiTipPotencialne(2);
                if (chkTretji.Checked)
                    StrankaModel.PotrdiTipPotencialne(3);
            }
            StrankaModel.Update();


        }

        private bool PreveriPolja()
        {
            bool preveri=true;
            if(chkPotencialna.Checked)
            {
                if (!(chkPrvi.Checked || chkDrugi.Checked || chkTretji.Checked))
                {
                    preveri = false;
                }
                
            }
            return preveri;
            
        }


        private void btnPreklici_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBoxImePriimek_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StrankaModel.PoslOsebaID = cBoxImePriimek.SelectedValue.ToString();
        }

        private void cBoxPodjetje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            StrankaModel.PodjetjeID = cBoxPodjetje.SelectedValue.ToString();
        }

        private void chkPotencialna_Click(object sender, EventArgs e)
        {
            if (chkPotencialna.Checked)
            {
                cBoxPodjetje.Enabled = false;
                gBoxTip.Enabled = true;
                if (StrankaModel.PotencialneStranke.Exists(x => x.TipStrankaID == "1"))
                    chkPrvi.Checked = true;
                if (StrankaModel.PotencialneStranke.Exists(x => x.TipStrankaID == "2"))
                    chkDrugi.Checked = true;
                if (StrankaModel.PotencialneStranke.Exists(x => x.TipStrankaID == "3"))
                    chkTretji.Checked = true;

            }
            else
            {
                gBoxTip.Enabled=false;
                cBoxPodjetje.Enabled = true;

                cBoxPodjetje.SelectedValue = (StrankaModel.PodjetjeID==null)?"0":StrankaModel.PodjetjeID;
            }
        }


        private void chkPrvi_Click(object sender, EventArgs e)
        {
            if (chkPrvi.Checked)
                StrankaModel.PotrdiTipPotencialne(1);
            else
                StrankaModel.OdstraniTipPotencialne(1);
        }

        private void chkDrugi_Click(object sender, EventArgs e)
        {
            if (chkDrugi.Checked)

                StrankaModel.PotrdiTipPotencialne(2);
            else
                StrankaModel.OdstraniTipPotencialne(2);
        }

        private void chkTretji_Click(object sender, EventArgs e)
        {
            if (chkTretji.Checked)
                StrankaModel.PotrdiTipPotencialne(3);
            else
                StrankaModel.OdstraniTipPotencialne(3);
        }


    }
}
