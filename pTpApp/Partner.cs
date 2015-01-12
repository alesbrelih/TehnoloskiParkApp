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
    public partial class Partner : Form
    {

        #region props

        public int TrenutniIndex { get; set; }
        public List<PartnerModel> VsaPartnerstva { get; set; }
        public string PodjetjeID { get; set; }
        #endregion

        public Partner()
        {
            InitializeComponent();
        }


        /// <summary>
        /// klik na gumb Izhod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzhod_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Prikaz polja partnerstvo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Partner_Shown(object sender, EventArgs e)
        {
            PrikaziPartnerstva();
            NastaviPolja();
        }


        /// <summary>
        /// Nastavi polja glede na izbrano partnerstvo
        /// </summary>
        /// 
        private void NastaviPolja()
        {
            int izbranIndex = cBoxPartnerstva.SelectedIndex;
            if (izbranIndex != cBoxPartnerstva.Items.Count - 1)
            {
                PartnerModel izbranoPartnerstvo = VsaPartnerstva[cBoxPartnerstva.SelectedIndex];

                string[] datumZac = izbranoPartnerstvo.DatumZacPart.Trim().Split('.');
                string[] datumKon = izbranoPartnerstvo.DatumKonPart.Trim().Split('.');
                RTBopis.Text = izbranoPartnerstvo.Opis;

                DTZacetek.Value = new DateTime(int.Parse(datumZac[2]), int.Parse(datumZac[1]), int.Parse(datumZac[0]));
                DTKonec.Value = new DateTime(int.Parse(datumKon[2]), int.Parse(datumKon[1]), int.Parse(datumKon[0]));
            }

        }

        /// <summary>
        /// prikaže partnerstva v comboboxu
        /// </summary>
        private void PrikaziPartnerstva()
        {
            cBoxPartnerstva.Items.Clear();
            foreach (PartnerModel partnertvo in VsaPartnerstva)
            {
                cBoxPartnerstva.Items.Add(partnertvo.Izpis());

            }
            cBoxPartnerstva.Items.Add("NOVO");
            if (cBoxPartnerstva.Items.Count == 1)
                cBoxPartnerstva.SelectedIndex = 0;
            else
                cBoxPartnerstva.SelectedIndex = TrenutniIndex;
            
        }


        /// <summary>
        /// Posodobi partnerstva v oknu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private void btnPotrdi_Click(object sender, EventArgs e)
        {
            PosodobiSeznam();
            PrikaziPartnerstva();
        }


        /// <summary>
        /// Shrani seznam
        /// </summary>

        private void PosodobiSeznam()
        {
            PartnerModel _partner;
            if (cBoxPartnerstva.SelectedIndex == cBoxPartnerstva.Items.Count - 1)
            {
                _partner = new PartnerModel(PodjetjeID,RTBopis.Text, DTZacetek.Value.ToShortDateString(), DTKonec.Value.ToShortDateString());
                _partner.Create();
                VsaPartnerstva.Add(_partner);
            }
            else
            {
                _partner = VsaPartnerstva[cBoxPartnerstva.SelectedIndex];
                _partner.DatumZacPart = DTZacetek.Value.ToShortDateString();
                _partner.DatumKonPart = DTKonec.Value.ToShortDateString();
                if (_partner.Action.StartsWith("INSERT"))
                    _partner.Create();

                else
                {
                    _partner.Update();
                }
            }
            
        }


        /// <summary>
        /// potrdi in izhod
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotrdiIzhod_Click(object sender, EventArgs e)
        {
            PosodobiSeznam();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /// <summary>
        ///spreminjanje cboxPartner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cBoxPartnerstva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxPartnerstva.SelectedIndex == cBoxPartnerstva.Items.Count - 1)
                PonastaviPolja();
            else
                NastaviPolja();
                
        }


        /// <summary>
        /// Ponastavi vsa polja
        /// </summary>
        /// 
        private void PonastaviPolja()
        {
            DTKonec.Value = DateTime.Now;
            DTZacetek.Value = DateTime.Now;
            RTBopis.Text = "";
        }
    }
}
