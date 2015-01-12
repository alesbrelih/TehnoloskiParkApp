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
    public partial class Form1 : Form
    {

        #region props
        public List<Stranka> VseStranke { get; set; }
        public List<Stranka> VsePotencialne { get; set; }
        public List<Podjetje> VsaPodjetja { get; set; }
        public List<Oseba> VseOsebe { get; set; }
        #endregion


        public static SQLiteConnection conn;  ///TODO!
                                              ///

        public Form1()
        {
            InitializeComponent();
        }


        #region metodeZaIzpisPodatkov

        /// <summary>
        /// izbere željeni izpis
        /// </summary>
        /// <param name="indexTab"></param>
        private void izpisPodatkov(int indexTab=0, string searchNiz="")
        {
            if (indexTab==0)
            {
                izpisiStranke(searchNiz);
            }
            
            if (indexTab==1)
            {
                izpisiPodjetja(searchNiz);
            }

            if (indexTab==2)
            {
                izpisiPotencialne(searchNiz);
            }
            if (indexTab == 3)
                IzpisiOsebe(searchNiz);


        }

        private void IzpisiOsebe(string searchNiz="")
        {
            listViewOsebe.Items.Clear();
            foreach(var oseba in VseOsebe)
            {
                if (oseba.Ime.ToUpper().Contains(searchNiz.ToUpper()) || oseba.Priimek.ToUpper().Contains(searchNiz.ToUpper()) || oseba.Email.ToUpper().Contains(searchNiz.ToUpper()) || oseba.Telefon.Contains(searchNiz))
                {
                    ListViewItem nov = new ListViewItem(oseba.Ime);
                    nov.SubItems.Add(oseba.Priimek);
                    nov.SubItems.Add(oseba.Email);
                    nov.SubItems.Add(oseba.Telefon);
                    nov.SubItems.Add(IzpisiTujec(oseba.Tujec));
                    nov.Name = oseba.OsebaID;
                    listViewOsebe.Items.Add(nov);
                }
            }
        }

        private string IzpisiTujec(string tujec)
        {
            if (tujec == "0")
                return "NE";
            else
                return "DA";
        }

        /// <summary>
        /// Izpiše potencialne stranke
        /// </summary>
        private void izpisiPotencialne(string searchNiz = "")
        {
            listViewPotencial.Items.Clear();

            foreach(var stranka in VsePotencialne)
            {
                if (stranka.PoslOseba.Ime.ToUpper().Contains(searchNiz.ToUpper()) || stranka.PoslOseba.Priimek.ToUpper().Contains(searchNiz.ToUpper()) || stranka.PoslOseba.Email.ToUpper().Contains(searchNiz.ToUpper()) || stranka.PoslOseba.Telefon.Contains(searchNiz))
                {
                    ListViewItem nov = new ListViewItem(stranka.PoslOseba.Ime);
                    nov.SubItems.Add(stranka.PoslOseba.Priimek);
                    nov.SubItems.Add(stranka.PoslOseba.Email);
                    nov.SubItems.Add(stranka.PoslOseba.Telefon);
                    nov.Name = stranka.StrankaID;
                    listViewPotencial.Items.Add(nov);
                }
            }
        }


        /// <summary>
        /// Izpiše podjetja
        /// </summary>
        private void izpisiPodjetja(string searchNiz = "")
        {
            listViewPodjetja.Items.Clear();
            foreach (var podjetje in VsaPodjetja)
            {
                if (podjetje.ImePodjetja.ToUpper().Contains(searchNiz.ToUpper()) || podjetje.KontaktOseba.Ime.ToUpper().Contains(searchNiz.ToUpper()) || podjetje.KontaktOseba.Priimek.ToUpper().Contains(searchNiz))
                {
                    ListViewItem nov = new ListViewItem(podjetje.ImePodjetja);
                    try
                    {
                        nov.SubItems.Add(podjetje.KontaktOseba.Ime + " " + podjetje.KontaktOseba.Priimek);
                    }
                    catch
                    {
                        nov.SubItems.Add("Oseba ne obstaja več.");
                    }
                    nov.Name = podjetje.PodjetjeID;
                    listViewPodjetja.Items.Add(nov);
                }
            }
            
        }


        /// <summary>
        /// Izpiše vse stranke
        /// </summary>
        private void izpisiStranke(string searchNiz = "")
        {
            listViewStranke.Items.Clear();
            foreach (var stranka in VseStranke)
            {
                if (stranka.PoslOseba.Ime.ToUpper().Contains(searchNiz.ToUpper()) || stranka.PoslOseba.Priimek.ToUpper().Contains(searchNiz.ToUpper()))
                {
                    ListViewItem nov = new ListViewItem(stranka.PoslOseba.Ime);
                    nov.SubItems.Add(stranka.PoslOseba.Priimek);
                    if (stranka.Podjetje != null)
                    {
                        nov.SubItems.Add(stranka.Podjetje.ImePodjetja);
                        nov.SubItems.Add(stranka.Podjetje.KontaktOseba.Ime + " " + stranka.Podjetje.KontaktOseba.Priimek);
                    }
                    else
                    {
                        nov.SubItems.Add(stranka.IzpisPotencialnih());
                        nov.SubItems.Add("/");
                    }
                    nov.Name = stranka.StrankaID;
                    listViewStranke.Items.Add(nov);
                }
            }
        }


        #endregion


        /// <summary>
        /// povezava z bazo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            NastaviPodatke();
            izpisPodatkov();

        }

        private void NastaviPodatke(int? tabIndex = null)
        {
            if (tabIndex == null)
            {
                VseStranke = DBconn.GetStrankeAsList();
                VsePotencialne = DBconn.IzpisiPotencialne();
                VsaPodjetja = DBconn.GetPodjetjaAsList();
                VseOsebe = DBconn.GetOsebeAsList();
            }
            if(tabIndex==0)
            {
                VseStranke = DBconn.GetStrankeAsList();
            }
            if (tabIndex == 1)
                VsaPodjetja = DBconn.GetPodjetjaAsList();
            if (tabIndex == 2)
                VsePotencialne = DBconn.IzpisiPotencialne();
            if (tabIndex == 3)
                VseOsebe = DBconn.GetOsebeAsList();
        }


        /// <summary>
        /// Spreminjanje tabov
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tabControlPrim_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxSearch.Text = "";
            int stZavihka = tabControlPrim.SelectedIndex;
            izpisPodatkov(stZavihka,tBoxSearch.Text);
        }

        #region searchBar
        /// <summary>
        /// Klik gumb isci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIsci_Click(object sender, EventArgs e)
        {
            int stZavihka = tabControlPrim.SelectedIndex;
            izpisPodatkov(stZavihka, tBoxSearch.Text);
        }


        private void tBoxSearch_TextChanged(object sender, EventArgs e)
        {
            int tab = tabControlPrim.SelectedIndex;
            string searchNiz = tBoxSearch.Text.ToString();
            izpisPodatkov(tab, searchNiz);

        }
        #endregion

        #region NovVnos
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajVnos();
        }
        /// <summary>
        /// Klik na gumb dodaj
        /// </summary>
        private void DodajVnos()
        {
            int tab = tabControlPrim.SelectedIndex;

            if (tab == 0)
                DodajStranko();
            if (tab == 1)
                DodajPodjetje();
            if (tab == 2)
                DodajPotencialno();
            if (tab == 3)
                DodajOsebo();
        }

        private void DodajOsebo()
        {
            NovaOseba novaOseba = new NovaOseba();
            novaOseba.ShowDialog();
            if (novaOseba.DialogResult == DialogResult.OK)
            {
                NastaviPodatke();
                IzpisiOsebe();
            }
        }
        /// <summary>
        /// Dodajanje potencialne stranke
        /// </summary>
        private void DodajPotencialno()
        {
            NovaPotencialna novaPoten = new NovaPotencialna();
            novaPoten.ShowDialog();
            if (novaPoten.DialogResult == DialogResult.OK)
            {
                NastaviPodatke();
                izpisiPotencialne();
            }
        }
        /// <summary>
        /// Dodajanje podjetja
        /// </summary>
        private void DodajPodjetje()
        {
            NovoPodjetje novoPodjetje = new NovoPodjetje();
            novoPodjetje.ShowDialog();
            if (novoPodjetje.DialogResult == DialogResult.OK)
            {
                NastaviPodatke();
                izpisiPodjetja();
            }
        }
        /// <summary>
        /// Dodajanje Strank
        /// </summary>
        private void DodajStranko()
        {
            NovaStranka dodajStranko = new NovaStranka();
            dodajStranko.ShowDialog();
            if (dodajStranko.DialogResult == DialogResult.OK)
            {
                NastaviPodatke();
                izpisiStranke();
            }
                
        }
        #endregion

        #region IzbrisiVnos
        private void IzbrisiVnos()
        {
            int tab = tabControlPrim.SelectedIndex;

            if (tab == 0)
                IzbrisiStranko();
            if (tab == 1)
                IzbrisiPodjetje();
            if (tab == 2)
                IzbrisiPotencialno();
            if (tab == 3)
                IzbrisiOsebo();
        
        }

        private void IzbrisiOsebo()
        {
            
            //id izbrisane osebe
            string idOsebe = listViewOsebe.SelectedItems[0].Name;
            Oseba _osebaIzbris = DBconn.GetOseba(idOsebe); //Ustvari osebo in z .Delete() dobimo del sql stavek
            _osebaIzbris.Delete();
            try
            {
                DBconn.RunNonQuery(_osebaIzbris);
                NastaviPodatke();
                IzpisiOsebe(tBoxSearch.Text.ToString());
            }
            catch
            {
                throw new Exception("Something BAD WITH izbrisiOsebo QUERY");
            }

        }

        private void IzbrisiPotencialno()
        {

            string idStranke = listViewPotencial.FocusedItem.Name;

            Stranka _stranka = DBconn.GetStranka(idStranke);
            _stranka.Delete();
            _stranka.PotencialneStranke.ForEach(x => x.Delete());

            List<TModel> _list = new List<TModel>();
            _stranka.PotencialneStranke.ForEach(x => _list.Add(x));
            _list.Add(_stranka);

            try
            {
                DBconn.RunNonQuery(_list);
                NastaviPodatke();
                izpisiPotencialne(tBoxSearch.Text.ToString());
            }
            catch
            {
                throw new Exception("BAD STUFF Z DEL POTENCIALNO!");
                
            }

        }

        private void IzbrisiPodjetje()
        {
            Podjetje _podjetje = DBconn.GetPodjetje(listViewPodjetja.FocusedItem.Name);
            _podjetje.Delete();
            _podjetje.VsiNajemi.ForEach(x => x.Delete());
            _podjetje.VsaPartnerstva.ForEach(x => x.Delete());
            _podjetje.VsaClanstva.ForEach(x => x.Delete());

            List<TModel> _list = new List<TModel>();
            _podjetje.VsiNajemi.ForEach(x => _list.Add(x));
            _podjetje.VsaClanstva.ForEach(x => _list.Add(x));
            _podjetje.VsaPartnerstva.ForEach(x => _list.Add(x));
            _list.Add(_podjetje);

            try
            {
                DBconn.RunNonQuery(_list);
                NastaviPodatke(1);
                izpisiPodjetja();
            }
            catch
            {
                throw new Exception("BAD STUFF");
            }
        }

        private void IzbrisiStranko()
        {

            Stranka _stranka = DBconn.GetStranka(listViewStranke.FocusedItem.Name);
            List<TModel> _list = new List<TModel>();
            if(_stranka.Podjetje==null)
            {
                _stranka.PotencialneStranke.ForEach(x => x.Delete());
                _stranka.PotencialneStranke.ForEach(x => _list.Add(x));
                _stranka.Delete();
                _list.Add(_stranka);
            }
            else
            {
                _stranka.Delete();
                _list.Add(_stranka);
                
            
            }
            try
            {
                DBconn.RunNonQuery(_list);
                NastaviPodatke();
                izpisiStranke();
            }
            catch
            {
                throw new Exception("BAD STUFF");
            }
            //string idStranke = listViewStranke.FocusedItem.Name;
            //string[] sqlStavki = {"DELETE FROM stranka WHERE strankaID = " + idStranke+";","DELETE FROM potStranka WHERE stranka = " + idStranke + ";"};
            //SQLiteTransaction tr;
            //tr = conn.BeginTransaction();
            //SQLiteCommand ukaz = conn.CreateCommand();
            //ukaz.Connection = conn;
            //ukaz.Transaction = tr;
            //try
            //{
            //    foreach(string stavek in sqlStavki)
            //    {
            //        ukaz.CommandText = stavek;
            //        ukaz.ExecuteNonQuery();
            //    }
            //    tr.Commit();
            //}
            //catch
            //{
            //    tr.Rollback();
            //}
            //finally
            //{
            //    conn.Close();
            //    izpisiStranke();
            //}


 
            
             
        }
        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            IzbrisiVnos();
        }
        #endregion

        #region UrediVnos
        private void btnUredi_Click(object sender, EventArgs e)
        {
            UrediVnos();
        }

        private void UrediVnos()
        {
            int tab = tabControlPrim.SelectedIndex;

            if (tab == 0)
            {
                if (listViewStranke.SelectedItems.Count != 0)
                    UrediStranko();
                else
                    MessageBox.Show("Izberite stranko, ki jo želite urediti!");
            }
            if (tab == 1)
            {
                if (listViewPodjetja.SelectedItems.Count != 0)
                    UrediPodjetje();
                else
                    MessageBox.Show("Izberite podjetje, ki ga želite urediti!");
            }
            if (tab == 2)
            {
                if (listViewPotencial.SelectedItems.Count != 0)
                    UrediPotencialno();
                else
                    MessageBox.Show("Izberite stranko, ki jo želite urediti!");
            }
            if(tab == 3)
            {
                if (listViewOsebe.SelectedItems.Count != 0)
                    UrediIzbranoOsebo();
                else
                    MessageBox.Show("Izberite osebo, ki jo želite urediti");
            }
        }

        private void UrediIzbranoOsebo()
        {
            UrediOsebo urediOsebo = new UrediOsebo();
            urediOsebo.OsebaID = listViewOsebe.SelectedItems[0].Name;
            urediOsebo.ShowDialog();
            if(urediOsebo.DialogResult==DialogResult.OK)
            {
                NastaviPodatke();
                IzpisiOsebe();
            }
        }

        private void UrediPodjetje()
        {
            NovoPodjetje urediPodjetje = new NovoPodjetje();
            urediPodjetje.PodjetjeID = listViewPodjetja.SelectedItems[0].Name;
            urediPodjetje.ShowDialog();
            if (urediPodjetje.DialogResult == DialogResult.OK)
            {
                NastaviPodatke();
                izpisiPodjetja();
            }
        }

        private void UrediPotencialno()
        {
            UrediStranko urediStranko = new UrediStranko();
            urediStranko.StrankaID = listViewPotencial.SelectedItems[0].Name;
            urediStranko.ShowDialog();
            if (urediStranko.DialogResult == DialogResult.OK)
            {
                NastaviPodatke();
                izpisiStranke();
            }
        }

        private void UrediStranko()
        {
            UrediStranko urediStranko = new UrediStranko();
            urediStranko.StrankaID = listViewStranke.SelectedItems[0].Name;
            urediStranko.ShowDialog();
            if(urediStranko.DialogResult==DialogResult.OK)
            {
                NastaviPodatke();
                izpisiStranke();
            }
        }
        #endregion
        
        #region klikiNaListViewe

        private void podrobnostiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PregledStranka stranka = new PregledStranka();
            if (tabControlPrim.SelectedIndex == 0)
                stranka.StrankaID = listViewStranke.FocusedItem.Name;
            if (tabControlPrim.SelectedIndex == 2)
                stranka.StrankaID = listViewPotencial.FocusedItem.Name;
            stranka.Show();
        }

        private void listViewStranke_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if(listViewStranke.FocusedItem.Bounds.Contains(e.Location))
                {
                    cMsPodrobnostStranka.Show(Cursor.Position);
                }
            }
        }

        private void listViewPotencial_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if(listViewPotencial.FocusedItem.Bounds.Contains(e.Location))
                {
                    cMsPodrobnostStranka.Show(Cursor.Position);
                }
            }
        }

        private void podrobnostiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PregledPodjetje podjetje = new PregledPodjetje();
            podjetje.idPodjetja = listViewPodjetja.FocusedItem.Name;
            podjetje.Show();
        }

        private void listViewPodjetja_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                if (listViewPodjetja.FocusedItem.Bounds.Contains(e.Location))
                    cMsPodjetje.Show(Cursor.Position);
            }
        }

        private void listViewStranke_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PregledStranka stranka = new PregledStranka();
            stranka.StrankaID = listViewStranke.FocusedItem.Name;
            stranka.ShowDialog();

        }

        private void listViewPotencial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PregledStranka stranka = new PregledStranka();
            stranka.StrankaID = listViewPotencial.FocusedItem.Name;
            stranka.ShowDialog();
        }

        private void listViewPodjetja_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PregledPodjetje podjetje = new PregledPodjetje();
            podjetje.idPodjetja = listViewPodjetja.FocusedItem.Name;
            podjetje.ShowDialog();

        }
        private void listViewOsebe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PregledOseba oseba = new PregledOseba();
            oseba.OsebaID = listViewOsebe.SelectedItems[0].Name;
            oseba.ShowDialog();
        }



        private void podrobnostiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PregledOseba oseba = new PregledOseba();
            oseba.OsebaID = listViewOsebe.SelectedItems[0].Name;
            oseba.Show();
        }

        private void listViewOsebe_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listViewOsebe.FocusedItem.Bounds.Contains(e.Location))
                    cMsPodrobnostOseba.Show(Cursor.Position);
        }

        #endregion

        private void listViewStranke_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = listViewStranke.TabIndex;
            string kategorija = null;
            listViewStranke.Items.Clear();
            switch (tabIndex)
            {
                case 0:
                    kategorija = "Ime";
                    break;
                case 1:
                    kategorija = "Priimek";
                    break;
                case 2:
                    kategorija = "Status";
                    break;
                case 3:
                    kategorija = "Kontakt";
                    break;
                    


            }

        }


        



    }
}
