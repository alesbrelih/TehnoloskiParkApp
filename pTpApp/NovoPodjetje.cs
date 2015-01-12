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
    public partial class NovoPodjetje : Form
    {
        public string PodjetjeID {get;set;}

        public Podjetje PodjetjeModel { get; set; }
        public int OsebaID { get; set; }

        #region sqlStavki
        /// <summary>
        /// Poisce max id v podjetju
        /// </summary>
        /// <returns></returns>
        private int PoisciMaxIDPodjetje()
        {
            return 1;
            //int podjetje;
            //conn.Open();
            //string sql = "SELECT max(podjetjeID) FROM podjetje;";
            //SQLiteCommand ukaz = new SQLiteCommand(sql, conn);
            //using (SQLiteDataReader beri = ukaz.ExecuteReader())
            //{
            //    if (beri.Read())
            //        podjetje = int.Parse(beri[0].ToString()) + 1;
            //    else
            //        podjetje = 1;
            //}
            //conn.Close();
            //SQLiteConnection.ClearAllPools();
            //return podjetje;
        }
        


        #endregion
        public NovoPodjetje()
        {
            InitializeComponent();
        }

        #region delo z statusom





        #endregion

        private void btnPonastavi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ponastavi
        /// </summary>
        private void Ponastavi()
        {
            tBoxImeP.Clear();
            NastaviOsebe();
        }


        private void NovoPodjetje_Shown(object sender, EventArgs e)
        {

            NastaviPodjetje();
            NastaviOsebe();
            NastaviPolja();
            izpisiClanstvo();
            izpisiNajem();
            izpisiPartnerstvo();

        }

        /// <summary>
        /// id podjetja!=none ? PodjetjeModel = Obstojece podjetje : PM = Prazno podjetje
        /// </summary>
        private void NastaviPodjetje()
        {
            if (PodjetjeID != null)
            {
                PodjetjeModel = DBconn.GetPodjetje(PodjetjeID);
            }
            else
                PodjetjeModel = new Podjetje();
        }


        /// <summary>
        /// Doda osebe v comboBox
        /// </summary>
        private void NastaviOsebe()
        {

            DataTable dT = DBconn.GetOsebe();
            cBoxOsebe.DataSource = dT;
            cBoxOsebe.DisplayMember = "ime";
            cBoxOsebe.ValueMember = "osebaID";

        }

        /// <summary>
        /// Nastavi ime podjetja in izbere ustrezno osebo
        /// </summary>
        private void NastaviPolja()
        {
            tBoxImeP.Text = PodjetjeModel.ImePodjetja;
            cBoxOsebe.SelectedValue = (PodjetjeModel.KontaktOsebaID == null ? "0" : PodjetjeModel.KontaktOsebaID);
            

        }

        /// <summary>
        /// Izpise vsa partnerstva
        /// </summary>
        private void izpisiPartnerstvo()
        {
            DataTable partnerstva = new DataTable();
            partnerstva.Columns.Add("izpis");
            partnerstva.Columns.Add("partnerID");
            if (PodjetjeModel.VsaPartnerstva.Count == 0)
            {
                partnerstva.Rows.Add("", "None");
            }
            else
            {
                foreach (PartnerModel partner in PodjetjeModel.VsaPartnerstva)
                {
                    partnerstva.Rows.Add(partner.Izpis(), partner.PartnerID);
                }
            }
            partnerstva.Rows.Add("Dodaj partnerstvo", "New");
            cBoxPartner.DataSource = partnerstva;
            cBoxPartner.DisplayMember = "izpis";
            cBoxPartner.ValueMember = "partnerID";

        }


        /// <summary>
        /// Izpise vse najeme
        /// </summary>
        private void izpisiNajem()
        {
            DataTable najemi = new DataTable();
            najemi.Columns.Add("izpis");
            najemi.Columns.Add("najemID");
            if (PodjetjeModel.VsiNajemi.Count == 0)
            {
                najemi.Rows.Add("", "None");
            }
            else
            {
                foreach (NajemModel najem in PodjetjeModel.VsiNajemi)
                {
                    najemi.Rows.Add(najem.Izpis(), najem.NajemID);
                }
            }
            najemi.Rows.Add("Dodaj najem", "New");
            cBoxNajem.DataSource = najemi;
            cBoxNajem.ValueMember = "najemID";
            cBoxNajem.DisplayMember = "izpis";
        }


        /// <summary>
        /// Izpiše vsa članstva
        /// </summary>
        private void izpisiClanstvo()
        {
            DataTable clanstva = new DataTable();
            clanstva.Columns.Add("izpis");
            clanstva.Columns.Add("clanID");
            if (PodjetjeModel.VsaClanstva.Count == 0)
            {
                clanstva.Rows.Add("", "None");
            }
            else
            {
                foreach (ClanModel clanstvo in PodjetjeModel.VsaClanstva)
                {
                    clanstva.Rows.Add(clanstvo.Izpis(), clanstvo.ClanID);
                }
            }
            clanstva.Rows.Add("Dodaj članstvo", "New");
            cBoxClanstvo.DataSource = clanstva;
            cBoxClanstvo.DisplayMember = "izpis";
            cBoxClanstvo.ValueMember = "clanID";
        }



        private void cBoxOsebe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBoxOsebe.SelectedValue.ToString() == "new")
                DodajOsebo();
        }

        /// <summary>
        /// Dodajanje nove osebe
        /// </summary>
        private void DodajOsebo()
        {
            NovaOseba novaOseba = new NovaOseba();
            novaOseba.ShowDialog();
            OsebaID = DBconn.PoisciNaslednjiIDOsebe();//Ko dodamo osebo jo želimo izbrano
            if (novaOseba.DialogResult == DialogResult.OK)
            {
                NastaviOsebe();
                IzberiOsebe();
                
                
            }
        }

        /// <summary>
        /// Dodamo osebo
        /// </summary>
        private void IzberiOsebe()
        {
            cBoxOsebe.SelectedValue = PodjetjeModel.KontaktOsebaID;
        }


        private void btnPotrdi_Click(object sender, EventArgs e)
        {
            PodjetjeModel.ImePodjetja = tBoxImeP.Text;
            PodjetjeModel.KontaktOsebaID = cBoxOsebe.SelectedValue.ToString();
            List<TModel> _list = new List<TModel>();
            if (PodjetjeID == null)
                PodjetjeModel.Create();
            else
                PodjetjeModel.Update();

            _list.Add(PodjetjeModel);
            PodjetjeModel.VsaClanstva.ForEach(x => _list.Add(x));
            PodjetjeModel.VsiNajemi.ForEach(x => _list.Add(x));
            PodjetjeModel.VsaPartnerstva.ForEach(x => _list.Add(x));
            try
            {
                DBconn.RunNonQuery(_list);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                throw new Exception("BAD STUFF");
            }
            //bool preveri = PreveriVnos();
            //List<string> sqlStavki = new List<string>();
            //if(preveri)
            //{
            //    conn.Open();
            //    foreach (ClanPodjetja clan in vsaClanstva)
            //    {
            //        sqlStavki.Add(clan.Sql);
            //    }
            //    foreach (PartnerPodjetja partner in vsoPartnerstvo)
            //    {
            //        sqlStavki.Add(partner.Sql);
            //    }
            //    foreach (NajemPodjetja najemnik in vsiNajemi)
            //    {
            //        sqlStavki.Add(najemnik.Sql);
            //    }
            //    if(podjetjeID==null)
            //    {
            //        sqlStavki.Add("INSERT INTO podjetje VALUES(NULL,\"" + tBoxImeP.Text + "\"," + cBoxOsebe.SelectedValue + ");");
            //    }
            //    else
            //        sqlStavki.Add("UPDATE podjetje SET imePodjetja=\""+tBoxImeP.Text+"\",kontaktOseba="+cBoxOsebe.SelectedValue+" WHERE podjetjeID="+podjetjeID+";");

            //    SQLiteCommand ukaz = conn.CreateCommand();
            //    SQLiteTransaction tr = conn.BeginTransaction();
            //    ukaz.Connection = conn;
            //    ukaz.Transaction = tr;

            //    try
            //    {
            //        foreach(string stavek in sqlStavki)
            //        {
            //            ukaz.CommandText = stavek;
            //            ukaz.ExecuteNonQuery();
            //        }
            //        tr.Commit();
            //        this.DialogResult = DialogResult.OK;
            //    }
            //    catch
            //    {
            //        tr.Rollback();
            //    }
            //    finally
            //    {
            //        conn.Close();
            //        this.Close();
            //    }
                
            //}
            

        }


        /// <summary>
        /// Preveri ali smo vnesli vse podatke
        /// </summary>
        private bool PreveriVnos()
        {
            if (tBoxImeP.Text.Trim().Count() == 0)
                return false;
            return true;
        }
        
        

        private void NovoPodjetje_Load(object sender, EventArgs e)
        {
            cBoxOsebe.Enabled = true;
            if(PodjetjeID!=null)
                this.Text = "Uredi Podjetje";
        }


        private void btnClan_Click(object sender, EventArgs e)
        {
            Clanstvo dodajClanstvo = new Clanstvo();
            dodajClanstvo.VsaClanstva = PodjetjeModel.VsaClanstva;
            dodajClanstvo.TrenutniIndex = cBoxClanstvo.SelectedIndex;
            dodajClanstvo.PodjetjeID = PodjetjeID==null ? DBconn.PoisciNaslednjiIDPodjetja().ToString() : PodjetjeID;
            dodajClanstvo.ShowDialog();
            if (dodajClanstvo.DialogResult == DialogResult.OK)
            {
                PodjetjeModel.VsaClanstva = dodajClanstvo.VsaClanstva;
                izpisiClanstvo();
            }
        }


        private void cBoxClanstvo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cBoxClanstvo.SelectedValue.ToString() =="New")
            //{
            //    Clanstvo dodajClanstvo = new Clanstvo();
            //    dodajClanstvo.vsaClanstva = vsaClanstva;
            //    dodajClanstvo.index = cBoxClanstvo.SelectedIndex;
            //    dodajClanstvo.podjetjeID = NastaviIDPodjetja();
            //    dodajClanstvo.ShowDialog();
            //    if(dodajClanstvo.DialogResult==DialogResult.OK)
            //    {
                    
            //        vsaClanstva = dodajClanstvo.vsaClanstva;
            //        izpisiClanstvo();
            //    }
            //}
        }


        private void cBoxPartner_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cBoxPartner.SelectedIndex != cBoxPartner.Items.Count - 1)
            {
                Partner urediPartner = new Partner();
                //urediPartner.vsiPartnerji = PodjetjeModel.VsaPartnerstva;
                //urediPartner.podjetjeID = podjetjeID;
                //urediPartner.index = cBoxPartner.SelectedIndex;
                //urediPartner.podjetjeID = NastaviIDPodjetja();
                //urediPartner.ShowDialog();
                //if (urediPartner.DialogResult == DialogResult.OK)
                //{
                //    vsoPartnerstvo = urediPartner.vsiPartnerji;
                //    izpisiPartnerstvo();

                //}
            }
        }

        private void cBoxNajem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cBoxNajem.SelectedIndex!=cBoxNajem.Items.Count-1)
            //{
            //    Najem urediNajem = new Najem();
            //    urediNajem.vsiNajemi = vsiNajemi;
            //    urediNajem.podjetjeID = podjetjeID;
            //    urediNajem.index = cBoxNajem.SelectedIndex;
            //    urediNajem.podjetjeID = NastaviIDPodjetja();
            //    urediNajem.ShowDialog();

            //    if (urediNajem.DialogResult == DialogResult.OK)
            //    {
            //        vsiNajemi = urediNajem.vsiNajemi;
            //        izpisiNajem();

            //    }

            //}
        }

        private void btnNajem_Click(object sender, EventArgs e)
        {
            
            Najem urediNajem = new Najem();
            urediNajem.VsiNajemi = PodjetjeModel.VsiNajemi;
            urediNajem.TrenutniIndex = cBoxNajem.SelectedIndex;
            urediNajem.PodjetjeID = PodjetjeID == null ? DBconn.PoisciNaslednjiIDPodjetja().ToString() : PodjetjeID;
            urediNajem.ShowDialog();

            if (urediNajem.DialogResult == DialogResult.OK)
            {
                PodjetjeModel.VsiNajemi = urediNajem.VsiNajemi;
                izpisiNajem();

            }

        }

        private void btnPartner_Click(object sender, EventArgs e)
        {
            Partner urediPartner = new Partner();
            urediPartner.VsaPartnerstva = PodjetjeModel.VsaPartnerstva;
            urediPartner.PodjetjeID = PodjetjeID==null ? DBconn.PoisciNaslednjiIDPodjetja().ToString() : PodjetjeID;
            urediPartner.TrenutniIndex = cBoxPartner.SelectedIndex;
            urediPartner.ShowDialog();
            if (urediPartner.DialogResult == DialogResult.OK)
            {
                PodjetjeModel.VsaPartnerstva = urediPartner.VsaPartnerstva;
                izpisiPartnerstvo();

            }
        }

        private void lblPodrobnosti_Click(object sender, EventArgs e)
        {
            UrediOsebo izbranaOseba = new UrediOsebo();
            izbranaOseba.OsebaID = cBoxOsebe.SelectedValue.ToString(); ;
            
            izbranaOseba.ShowDialog();
            if (izbranaOseba.DialogResult==DialogResult.OK)
            {

            }
        }




    }
}
