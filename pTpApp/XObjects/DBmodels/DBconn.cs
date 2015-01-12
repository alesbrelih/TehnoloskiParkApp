using pTpApp.XObjects.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pTpApp.XObjects.DBmodels
{
    /// <summary>
    /// SKRBI ZA DELO Z DATABASE
    /// </summary>
    public static class DBconn
    {
        #region connect
        //Povezava do baze
        public static SQLiteConnection Connect()
        {
            return new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;");
        }
        #endregion


        public static int PoisciNaslednjiIDPodjetja()
        {
            int cifra = 1;
            string sql = "SELECT max(podjetjeID) FROM podjetje;";
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {

                        while(beri.Read())
                        {
                            cifra = int.Parse(beri[0].ToString()) + 1;
                            
                        }
                    }
                }
                _conn.Close();
            }

            return cifra;
        }

        public static int PoisciNaslednjiIDOsebe()
        {
            int oseba=1;
            string sql = "SELECT max(osebaID) FROM oseba;";
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var result in beri)
                        {
                            //if (beri.Read())
                            oseba = int.Parse(beri[0].ToString()) + 1;
                            //else
                            //    oseba = 1;
                        }
                    }
                }
                _conn.Close();
                return oseba;
            }

            

        }

        /// <summary>
        /// Posce naslednji id stranke
        /// </summary>
        /// <returns></returns>
        public static int PoisciNaslednjiIDStranke()
        {
            int stranka;
            string sql = "SELECT max(strankaID) FROM stranka;";
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {

                        if (beri.Read())
                            stranka = int.Parse(beri[0].ToString()) + 1;
                        else
                            stranka = 1;
                    }
                }
                _conn.Close();
            }
            
            return stranka;

        }


        #region NoNQuery
        /// <summary>
        /// Executa NonQuery za seznam Objektov
        /// </summary>
        /// <param name="sezUkazov"></param>
        /// <returns></returns>
        public static void RunNonQuery(List<TModel> sezModel)
        {

            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();


                using (SQLiteTransaction tr = _conn.BeginTransaction())
                {
                    using (SQLiteCommand ukaz = _conn.CreateCommand())
                    {
                        ukaz.Transaction = tr;
                        foreach (var item in sezModel)
                        {
                            ukaz.CommandText = item.Action;
                            ukaz.ExecuteNonQuery();
                        }
                        tr.Commit();
                        MessageBox.Show("Done");
                    }
                }
                _conn.Close();
            }
        }

        /// <summary>
        /// execute NonQuery Za en Objekt
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool RunNonQuery(TModel model)
        {
            string _cmnd = model.Action;
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();

                using (SQLiteCommand _ukaz = new SQLiteCommand(_cmnd, _conn))
                {
                    _ukaz.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
                _conn.Close();
            }
            return true;
        }

        public static DataTable GetPodjetja()
        {
            DataTable podatkiPodjetje = new DataTable();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                
                podatkiPodjetje.Columns.Add("imePodjetje");
                podatkiPodjetje.Columns.Add("podjetjeID");
                string sql = "SELECT * FROM podjetje;";
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        podatkiPodjetje.Rows.Add("", "0");
                        while (beri.Read())
                        {
                            podatkiPodjetje.Rows.Add(beri["imePodjetja"].ToString(), beri["podjetjeID"]);
                        }
                    }
                }
                _conn.Close();
                podatkiPodjetje.Rows.Add("-------------", "none");
                podatkiPodjetje.Rows.Add("Novo Podjetje...", "new");
            }
            return podatkiPodjetje;
        }
        public static DataTable GetOsebe()
        {
            DataTable podatkiOseba = new DataTable();
            using (SQLiteConnection conn = Connect())
            {
                conn.Open();
                podatkiOseba.Columns.Add("ime");
                podatkiOseba.Columns.Add("osebaID");
                string sql = "SELECT * FROM oseba;";
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        podatkiOseba.Rows.Add("", "0");
                        while (beri.Read())
                        {

                            podatkiOseba.Rows.Add(beri["ime"] + " " + beri["priimek"], beri["osebaID"]);
                        }
                    }
                }
                conn.Close();
            }
            podatkiOseba.Rows.Add("-------------", "none");
            podatkiOseba.Rows.Add("Nova Oseba...", "new");
            return podatkiOseba;
        }
        #endregion

        #region GetQueries
        public static Oseba GetOseba(string id)
        {
            Oseba _oseba = null;
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                
                _conn.Open();
                string cmnd = "SELECT * FROM oseba WHERE osebaID = " + id + ";";

                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        while (beri.Read())
                        {
                            _oseba = new Oseba(beri["osebaID"].ToString(), beri["ime"].ToString(), beri["priimek"].ToString(), beri["telefon"].ToString(), beri["eMail"].ToString(), beri["tujec"].ToString());
                        }
                    }
                }
                _conn.Close(); 
            }
            return _oseba;
        }
        public static Podjetje GetPodjetje(string id)
        {
            Podjetje _podjetje = null;
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM podjetje WHERE podjetjeID="+id+";";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd,_conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {

                        while (beri.Read())
                        {
                            _podjetje = new Podjetje(beri["podjetjeID"].ToString(), beri["imePodjetja"].ToString(), beri["kontaktOseba"].ToString());
                        }
                    }
                    
                    
                }
                _conn.Close();
                
            }
            return _podjetje;
        }

        internal static Stranka GetStranka(string strankaID)
        {
            Stranka _stranka = null;
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM stranka WHERE strankaID=" + strankaID + ";";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        while (beri.Read())
                        {
                            if (beri.IsDBNull(2))
                            {
                                _stranka = new Stranka(beri["strankaID"].ToString(), beri["poslOseba"].ToString());
                            }
                            else
                            {
                                _stranka = new Stranka(beri["strankaID"].ToString(), beri["poslOseba"].ToString(), beri["podjetje"].ToString(), true);
                            }
                        }
                    }

                }
                _conn.Close();

            }
            return _stranka;
        }

        internal static TipStranke GetTipPotencialne(string tipStrankaID)
        {
            TipStranke _potStranka = null;
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM tipStranke WHERE tipStrankeID=" + tipStrankaID + ";";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var rez in beri)
                        {

                            _potStranka = new TipStranke(beri["tipStrankeID"].ToString(), beri["tipStra"].ToString());

                        }
                    }

                }
                _conn.Close();

            }
            return _potStranka;
        }

        /// <summary>
        /// Poisce vse potencialne tipe Strank za izbrano stranko
        /// </summary>
        /// <returns></returns>
        /// 
        internal static List<PotencialnaStranka> VrniPotencialne(string id)
        {
            List<PotencialnaStranka> _list = new List<PotencialnaStranka>();

            using(SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string _cmnd = "SELECT * FROM potStranka WHERE stranka=" + id + ";";
                using (SQLiteCommand _ukaz = new SQLiteCommand(_cmnd, _conn))
                {
                    using (SQLiteDataReader beri = _ukaz.ExecuteReader())
                    {
                        foreach (var rez in beri)
                        {

                            _list.Add(new PotencialnaStranka(beri["potStrankaID"].ToString(), beri["stranka"].ToString(), beri["tipStranka"].ToString()));

                        }
                    }
                }
                _conn.Close();
            }
            return _list;
        }
        #endregion

        internal static TipClan GetTipClana(string TipClanaID)
        {
            TipClan _tipClana=null;
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM tipClan WHERE tipClanID=" + TipClanaID + ";";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var rez in beri)
                        {

                            _tipClana = new TipClan(beri["tipClanID"].ToString(), beri["tipClana"].ToString());

                        }
                    }
                    
                    

                }
                _conn.Close();

            }
            return _tipClana;
        }



        internal static List<Tables.NajemModel> GetNajeme(string PodjetjeID)
        {
            List<NajemModel> _list = new List<NajemModel>();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM najem WHERE podjetje="+PodjetjeID + ";";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var rez in beri)
                        {

                            _list.Add(new NajemModel(beri["najemID"].ToString(), beri["podjetje"].ToString(), beri["datumZacNaj"].ToString(), beri["datumKonNaj"].ToString()));

                        }
                    }


                }
                _conn.Close();
                return _list;

            }
            
        }

        internal static List<ClanModel> GetClanstva(string PodjetjeID)
        {
            List<ClanModel> _list = new List<ClanModel>();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM clan WHERE podjetje=" + PodjetjeID + ";";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var res in beri)
                        {
                            _list.Add(new ClanModel(beri["clanID"].ToString(), beri["podjetje"].ToString(), beri["tipClan"].ToString(), beri["datumZacClan"].ToString(), beri["datumKoncClan"].ToString()));

                        }
                    }
                    //while (beri.Read())
                    //{
                    //}
                    



                }
                _conn.Close();
                return _list;

            }
        }

        internal static List<Tables.PartnerModel> GetPartnerstva(string PodjetjeID)
        {
            List<PartnerModel> _list = new List<PartnerModel>();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM partner WHERE podjetje=" + PodjetjeID + ";";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var rez in beri)
                        {

                            _list.Add(new PartnerModel(beri["partnerID"].ToString(), beri["podjetje"].ToString(), beri["opis"].ToString(), beri["datumZacPart"].ToString(), beri["datumKonPart"].ToString()));

                        }
                    }



                }
                _conn.Close();
                return _list;

            }
        }

        internal static DataTable GetVseTipeClanstva()
        {
            
            DataTable dT = new DataTable();
            dT.Columns.Add("tipClana");
            dT.Columns.Add("tipClanID");
            dT.Rows.Add("", "None");
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();
                string cmnd = "SELECT * FROM tipClan;";
                using (SQLiteCommand ukaz = new SQLiteCommand(cmnd, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var rez in beri)
                        {

                            dT.Rows.Add(beri["tipClana"].ToString(), beri["tipClanID"].ToString());

                        }
                    }


                }
                _conn.Close();
                return dT;

            }
           
        }

        internal static List<Podjetje> GetPodjetjaAsList()
        {
            List<Podjetje> podatkiPodjetje = new List<Podjetje>();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();

                string sql = "SELECT * FROM podjetje;";
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        foreach (var podj in beri)
                        {
                            podatkiPodjetje.Add(new Podjetje(beri["podjetjeID"].ToString(), beri["imePodjetja"].ToString(), beri["kontaktOseba"].ToString()));
                        }
                    }
                    
                }
                _conn.Close();
 
            }
            return podatkiPodjetje;
        }

        internal static List<Stranka> GetStrankeAsList(string searchTerm="")
        {
            List<Stranka> podatkiStranke = new List<Stranka>();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();

                string sql = "SELECT * FROM stranka;";
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        while (beri.Read())
                        {
                            if (beri.IsDBNull(2))
                            {
                                podatkiStranke.Add(new Stranka(beri["strankaID"].ToString(), beri["poslOseba"].ToString()));

                            }
                            else
                            {
                                podatkiStranke.Add(new Stranka(beri["strankaID"].ToString(), beri["poslOseba"].ToString(), beri["podjetje"].ToString(), true));

                            }

                        }
                    }

                }
                _conn.Close();

            }
            return podatkiStranke;
        }

        internal static List<Stranka> IzpisiPotencialne()
        {
            List<Stranka> podatkiStranke = new List<Stranka>();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();

                string sql = "SELECT * FROM stranka WHERE podjetje IS NULL;";
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        while (beri.Read())
                        {

                            podatkiStranke.Add(new Stranka(beri["strankaID"].ToString(), beri["poslOseba"].ToString()));



                        }
                    }

                }
                _conn.Close();

            }
            return podatkiStranke;
        }

        internal static List<Oseba> GetOsebeAsList()
        {
            List<Oseba> _osebe = new List<Oseba>();
            using (SQLiteConnection _conn = new SQLiteConnection(@"Data Source=pTpUpdate.sqlite;Version=3;"))
            {
                _conn.Open();

                string sql = "SELECT * FROM oseba;";
                using (SQLiteCommand ukaz = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader beri = ukaz.ExecuteReader())
                    {
                        while (beri.Read())
                        {

                            _osebe.Add(new Oseba(beri["osebaID"].ToString(), beri["ime"].ToString(), beri["priimek"].ToString(), beri["telefon"].ToString(), beri["eMail"].ToString(),beri["tujec"].ToString()));



                        }
                    }

                }
                _conn.Close();

            }
            return _osebe;
        }
    }
}
