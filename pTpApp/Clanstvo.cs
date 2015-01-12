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
    public partial class Clanstvo : Form
    {

        #region pros
        public Podjetje Podjetje { get; set; }

        public List<ClanModel> VsaClanstva { get; set; }

        public string PodjetjeID { get; set; }

        public int TrenutniIndex { get; set; }
        #endregion

        /// <summary>
        /// Konstruktor clanstva
        /// </summary>
        public Clanstvo()
        {
            InitializeComponent();
        }


        //Klik na gumb potrdi
        private void btnPotrdi_Click(object sender, EventArgs e)
        {
            PosodobiSeznam();
            PrikaziClanstva();

            
        }


        /// <summary>
        /// Posodobi seznm clanstva
        /// </summary>
        private void PosodobiSeznam()
        {
            ClanModel _clan;
            if(cBoxClanstva.SelectedIndex != cBoxClanstva.Items.Count-1)
            {
                _clan = VsaClanstva[TrenutniIndex];
                _clan.DatumZacClan = DTZacetek.Value.ToShortDateString();
                _clan.DatumKoncClan = DTKonec.Value.ToShortDateString();
                _clan.TipClanaID = cBoxTip.SelectedValue.ToString();
                if (_clan.Action.StartsWith("INSERT INTO"))
                    _clan.Create();
                else
                    _clan.Update();
            }
            else
            {
                _clan = new ClanModel(PodjetjeID, cBoxTip.SelectedValue.ToString(), DTZacetek.Value.ToShortDateString(), DTKonec.Value.ToShortDateString());
                _clan.Create();
                VsaClanstva.Add(_clan);
            }

            //if (cBoxTip.SelectedValue != "None")
            //{
            //    ClanModel _clanstvo;
            //    if (Clanstvo == null)
            //    {
            //        _clanstvo = new ClanModel(PodjetjeID, cBoxTip.SelectedValue.ToString(), DTZacetek.Value.ToShortDateString(), DTKonec.Value.ToShortDateString());
            //        _clanstvo.Create();

            //    }
            //    else
            //    {
            //        _clanstvo = vsaClanstva[cBoxTip.SelectedIndex];
            //        _clanstvo.TipClanaID = cBoxTip.SelectedValue.ToString();
            //        _clanstvo.TipClana = DBconn.GetTipClana(_clanstvo.TipClanaID);
            //        _clanstvo.DatumZacClan = DTZacetek.Value.ToShortDateString();
            //        _clanstvo.DatumKoncClan = DTKonec.Value.ToShortDateString();
            //        if (_clanstvo.Action.StartsWith("INSERT"))
            //        {
            //            _clanstvo.Create();
            //        }
            //        else
            //        {
            //            _clanstvo.Update();
            //        }
            //    }
            //    PonastaviIzbranoClanstvo();
            //}
            
        }


        //Ko se clanstvo naloži
        private void Clanstvo_Shown(object sender, EventArgs e)
        {
            
            nastaviClanstvo();
            PrikaziClanstva();
            IzberiUstrezna();
          
        }
        
        // Glede na izbor clanstva spremenimo polja
        private void IzberiUstrezna()
        {
            int izbraniIndex = cBoxClanstva.SelectedIndex;

            ClanModel izbraniClan;
            if ((izbraniIndex != cBoxClanstva.Items.Count - 1))
            {
                izbraniClan = VsaClanstva[cBoxClanstva.SelectedIndex];
                cBoxTip.SelectedValue= izbraniClan.TipClanaID;
                string[] datumZac = izbraniClan.DatumZacClan.Split('.');
                string[] datumKon = izbraniClan.DatumKoncClan.Split('.');
                DTZacetek.Value = new DateTime(int.Parse(datumZac[2]), int.Parse(datumZac[1]), int.Parse(datumZac[0]));
                DTKonec.Value = new DateTime(int.Parse(datumKon[2]), int.Parse(datumKon[1]), int.Parse(datumKon[0]));
            }
        }


        //Prikaze vsa clanstva v cBox
        private void PrikaziClanstva()
        {
            cBoxClanstva.Items.Clear();
            foreach (ClanModel clanstvo in VsaClanstva)
                cBoxClanstva.Items.Add(clanstvo.Izpis());
            cBoxClanstva.Items.Add("NOVO");
            if (cBoxClanstva.Items.Count == 1)
                cBoxClanstva.SelectedIndex = 0;
            else
                cBoxClanstva.SelectedIndex = TrenutniIndex;

        }

        //Nastavi vsa možna članstva v cbox TipClan
        private void nastaviClanstvo()
        {
            DataTable dT = DBconn.GetVseTipeClanstva();
            cBoxTip.DataSource = dT;
            cBoxTip.ValueMember = "tipClanID";
            cBoxTip.DisplayMember = "tipClana";

        }


        //Shrani in Izhod iz clanstev
        private void btnPotrdiIzhod_Click(object sender, EventArgs e)
        {
            PosodobiSeznam();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        //Izhod iz clanstev
        private void btnIzhod_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Spremenimo izbor med ze obstoječimi članstvi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxClanstva_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBoxClanstva.SelectedIndex == cBoxClanstva.Items.Count - 1)
                PonastaviPolja();
            IzberiUstrezna();
        }

        /// <summary>
        /// Ko kliknemo na polje NOVO CLANSTVO moramo ponastaviti polja
        /// </summary>
        private void PonastaviPolja()
        {
            cBoxTip.SelectedIndex = 0;
            DTZacetek.Value = DateTime.Now;
            DTKonec.Value = DateTime.Now;
        }

        private void Clanstvo_Load(object sender, EventArgs e)
        {

        }
    }
}
