using pTpApp.XObjects.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTpApp
{
    public partial class Najem : Form
    {
        #region props
        public List<NajemModel> VsiNajemi { get; set; }
        public string PodjetjeID { get; set; }
        public int TrenutniIndex { get; set; }
        #endregion


        public Najem()
        {
            InitializeComponent();
        }

        //FOrm SHow
        private void Najem_Shown(object sender, EventArgs e)
        {
            PrikaziNajeme();
            IzberiUstrezna();
        }

        /// <summary>
        /// Izbere ostala polja glede na izbrani Index
        /// </summary>

        private void IzberiUstrezna()
        {
            int izbranIndex = cBoxNajemi.SelectedIndex;
            if (izbranIndex != cBoxNajemi.Items.Count - 1)
            {
                NajemModel izbranNajem = VsiNajemi[TrenutniIndex];

                string[] datumZac = izbranNajem.DatumZacNaj.Trim().Split('.');
                string[] datumKon = izbranNajem.DatumKonNaj.Trim().Split('.');

                DTZacetek.Value = new DateTime(int.Parse(datumZac[2]), int.Parse(datumZac[1]), int.Parse(datumZac[0]));
                DTKonec.Value = new DateTime(int.Parse(datumKon[2]), int.Parse(datumKon[1]), int.Parse(datumKon[0]));
            }
        }

        /// <summary>
        /// Izpise najeme in si shrani izbrani ID iz forme NOvoPodjetje
        /// </summary>

        private void PrikaziNajeme()
        {
            cBoxNajemi.Items.Clear();
            foreach (NajemModel najem in VsiNajemi)
            {
                cBoxNajemi.Items.Add(najem.Izpis());
            }
            cBoxNajemi.Items.Add("NOV");
            if (cBoxNajemi.Items.Count == 1)
                cBoxNajemi.SelectedIndex = 0;
            else
                cBoxNajemi.SelectedIndex = TrenutniIndex;
        }

        private void btnPotrdi_Click(object sender, EventArgs e)
        {
            PosodobiSeznam();
            PrikaziNajeme();
        }

        /// <summary>
        /// Posodobi seznam najemov
        /// </summary>
        private void PosodobiSeznam()
        {
            NajemModel _najem;
            if(cBoxNajemi.SelectedIndex==cBoxNajemi.Items.Count-1)
            {
                _najem = new NajemModel(PodjetjeID, DTZacetek.Value.ToShortDateString(), DTKonec.Value.ToShortDateString());
                _najem.Create();
                VsiNajemi.Add(_najem);
            }
            else
            {
                _najem = VsiNajemi[cBoxNajemi.SelectedIndex];
                _najem.DatumZacNaj = DTZacetek.Value.ToShortDateString();
                _najem.DatumKonNaj = DTKonec.Value.ToShortDateString();
                if (_najem.Action.StartsWith("INSERT"))
                    _najem.Create();

                else
                {
                    _najem.Update();
                }
            }
            //int izbraniIndex = cBoxNajemi.SelectedIndex;
            //NajemModel izbraniNajem;
            //string datumZac = DTZacetek.Value.ToShortDateString();
            //string datumKon = DTKonec.Value.ToShortDateString();
            //if (izbraniIndex != cBoxNajemi.Items.Count - 1)
            //{
            //    izbraniNajem = VsiNajemi[izbraniIndex];
            //    izbraniNajem.DatumZacNaj = datumZac;
            //    izbraniNajem.DatumKonNaj = datumKon;
            //    izbraniNajem.Izpis = datumZac + " - " + datumKon;
            //    if (!izbraniNajem.Nov)
            //    {
            //        izbraniNajem.Sql = "UPDATE najem SET datumZacNaj=\"" + izbraniNajem.DatumZacClan + "\",datumKonNaj=\"" + izbraniNajem.DatumKonClan + "\" WHERE najemID=" + izbraniNajem.NajemID + ";";
            //    }
            //    else
            //        izbraniNajem.Sql = "INSERT INTO najem VALUES (NULL," + izbraniNajem.Podjetje + ",\"" + izbraniNajem.DatumZacClan + "\",\"" + izbraniNajem.DatumKonClan + "\");";
            //}
            //else
            //{
                
            //    string sql = "INSERT INTO najem VALUES (NULL," + podjetjeID + ",\"" + datumZac + "\",\"" + datumKon + "\");";
            //    string izpis = datumZac + " - " + datumKon;
            //    izbraniNajem = new NajemPodjetja(izpis, sql, null, podjetjeID, datumZac, datumKon, true);
            //    VsiNajemi.Add(izbraniNajem);
            //}
        }

        /// <summary>
        /// Klik na gumb potrdi in izhod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotrdiIzhod_Click(object sender, EventArgs e)
        {
            PosodobiSeznam();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        //Izhod iz najemov
        private void btnIzhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Spreminjanje izbranega najema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxNajemi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        /// Ponastavi polja
        /// </summary>
        private void PonastaviPolja()
        {
            DTZacetek.Value = DateTime.Now;
            DTKonec.Value = DateTime.Now;
        }


        /// <summary>
        /// Spreminjanje izbranega najema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBoxNajemi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBoxNajemi.SelectedIndex == cBoxNajemi.Items.Count-1)
                PonastaviPolja();
            IzberiUstrezna();
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Najem_Load(object sender, EventArgs e)
        {

        }
    }
}
