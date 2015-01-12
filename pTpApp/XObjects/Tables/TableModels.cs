using pTpApp.XObjects.DBmodels;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpApp.XObjects.Tables
{
    class TableModels
    {
    }

    /// <summary>
    /// navidezni razred iz katerega bodo dedovali vsi razredi, ki bodo predstavljali tabele v bazi
    /// </summary>
    public class TModel : IDisposable
    {

        #region props
        public string Action { get; set; }

        #endregion

        #region constr
        public TModel()
        {
            Action = "";
        }
        #endregion

        #region Dispose

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                Action = null;
            }
            disposed = true;

        }
        #endregion
    }

	
    public class Oseba : TModel
    {
        #region props
        public string OsebaID { get; set; }

        public string Ime { get; set; }

        public string Priimek { get; set; }

        public string Email { get; set; }

        public string Telefon { get; set; }

        public string Tujec { get; set; }
        #endregion

        #region contructors
        public Oseba() : base() { }

        /// <summary>
        /// constr.
        /// </summary>
        /// <param name="ime"></param>
        /// <param name="priimek"></param>
        /// <param name="eMail"></param>
        /// <param name="tujec"></param>
        public Oseba(string ime, string priimek, string telefon, string eMail, string tujec)
        {
            Ime = ime;
            Priimek = priimek;
            Email = eMail;
            Tujec = tujec;
            Telefon = telefon;
        }

        public Oseba(string id, string ime, string priimek, string telefon, string eMail, string tujec)
        {
            OsebaID = id;
            Ime = ime;
            Priimek = priimek;
            Email = eMail;
            Tujec = tujec;
            Telefon = telefon;
        }
        #endregion

        #region SQLmethods
        public void Create()
        {
            Action = "INSERT INTO oseba VALUES (NULL, \"" + Ime + "\", \"" + Priimek + "\", \"" + Email + "\", \"" + Telefon + "\", \"" + Tujec + "\");";
        }
        internal void Update()
        {
            Action = "UPDATE oseba SET ime=\"" + Ime + "\", priimek=\"" + Priimek + "\", eMail=\"" + Email + "\", telefon=\"" + Telefon + "\", tujec=\"" + Tujec + "\" WHERE osebaID=" + OsebaID + ";";
        }
        internal void Delete()
        {
            Action = "DELETE FROM oseba WHERE osebaID=" + OsebaID + ";";
        }
        #endregion

        #region dispose
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        #endregion
    }

    /// <summary>
    /// Stranka razred
    /// </summary>
    public class Stranka : TModel
    {
        #region props

        public string StrankaID { get; set; }

        public Oseba PoslOseba { get; set; }
        public string PoslOsebaID { get; set; }


        public Podjetje Podjetje { get; set; }
        public string PodjetjeID { get; set; }

        public List<PotencialnaStranka> PotencialneStranke = new List<PotencialnaStranka>();

        #endregion

        #region constr
        public Stranka() : base() {}


        //Create POTENCIALNA CONSTR
        public Stranka(string poslOsebaID):this()
        {
            StrankaID = null;
            PoslOsebaID = poslOsebaID;
        }
        //Post POTENCIALNA CONSTR
        public Stranka(string strankaID, string poslOsebaID):this(poslOsebaID)
        {
            StrankaID = strankaID;
            PoslOseba = DBconn.GetOseba(PoslOsebaID);
            NastaviPotencialne();
        }

        //View STRANKA S PODJETJEM
        public Stranka(string poslOsebaID,string podjetjeID,bool podjetje):this()
        {
            if(podjetje)
            {
            StrankaID=null;
            PoslOsebaID=poslOsebaID;
            PodjetjeID=podjetjeID;
            }
        }
        //POST PODJETJE
        public Stranka(string strankaID, string poslOsebaID, string podjetjeID, bool podjetje)
            :this(poslOsebaID,podjetjeID,podjetje)
        {
            StrankaID = strankaID;
            PoslOseba = DBconn.GetOseba(poslOsebaID);
            Podjetje = DBconn.GetPodjetje(podjetjeID);
        }


        private void NastaviPotencialne()
        {
            DBconn.VrniPotencialne(this.StrankaID).ForEach(x => PotencialneStranke.Add(x));
        }
        #endregion

        #region SQLstavki
        public void CreatePodjetje()
        {
            Action = "INSERT INTO stranka (strankaID,poslOseba,podjetje) VALUES (NULL," + PoslOsebaID + ", " + PodjetjeID + ");";

        }
        public void CreatePotencialno()
        {
            Action = "INSERT INTO stranka(strankaID,poslOseba,podjetje) VALUES (NULL," + PoslOsebaID + ",NULL);";
        }

        internal void Update()
        {
            if (PodjetjeID == null)
            {
                Action = "UPDATE stranka SET poslOseba=" + PoslOsebaID + ", podjetje = NULL WHERE strankaID=" + StrankaID + ";";
            }
            else
            {
                Action = "UPDATE stranka SET poslOseba=" + PoslOsebaID + ", podjetje = "+PodjetjeID+" WHERE strankaID=" + StrankaID + ";";

            }
        }

        internal void Delete()
        {
            Action = "DELETE FROM stranka WHERE strankaID=" + StrankaID + ";";
        }
        /// <summary>
        /// Poišče med list PotencialneStranke če obstaja kakšen model ki ima določen tip
        /// </summary>
        /// <param name="tip"></param>
        /// <param name="stStranke"></param>
        internal void PotrdiTipPotencialne(int tip, int? stStranke=null)
        {
            PotencialnaStranka _potencialnaStranka;
            ///Ustvarjamo Novo Stranko
            if (stStranke != null)
            {
                _potencialnaStranka = new PotencialnaStranka(stStranke.ToString(), tip.ToString());
                _potencialnaStranka.Create();
                PotencialneStranke.Add(_potencialnaStranka);
            }


            //Posodabljamo strano

            else
            {
                _potencialnaStranka = PotencialneStranke.Find(x => x.TipStrankaID == tip.ToString());
                if (_potencialnaStranka == null)
                {
                    _potencialnaStranka = new PotencialnaStranka(StrankaID , tip.ToString());
                    _potencialnaStranka.Create();
                    PotencialneStranke.Add(_potencialnaStranka);
                }
            }
            
        }

        internal void OdstraniTipPotencialne(int tip, int? stStranke=null)
        {
            PotencialnaStranka _stranka = PotencialneStranke.Find(x => x.TipStrankaID == tip.ToString());
            if (_stranka != null)
            {
                if (_stranka.Action.StartsWith("INSERT"))
                    PotencialneStranke.Remove(_stranka);
                if (_stranka.Action == "")
                    _stranka.Delete();
            }
        }
        #endregion

        #region dispose
        protected override void Dispose(bool disposing)
        {
            if (PoslOseba != null)
            {
                PoslOseba.Dispose();
                PoslOseba = null;
            }
            if (Podjetje != null)
            {
                Podjetje.Dispose();
                Podjetje = null;
            }
            base.Dispose(disposing);
        }

        #endregion



        internal void OdstraniTipPotencialne(bool p)
        {
            if(p)
            {
                for(int i = 1;i<=3;i++)
                {
                    OdstraniTipPotencialne(i);
                }
            }

        }

        internal string IzpisPotencialnih()
        {
            string izpis = "";
            foreach(var tipPot in PotencialneStranke)
            {
                if (izpis.Count() == 0)
                    izpis += tipPot.TipStranka.TipStra;
                else
                    izpis += ", " + tipPot.TipStranka.TipStra;
            }
            return izpis;
        }
    }


    public class Podjetje : TModel
    {

        #region props
        public string PodjetjeID { get; set; }

        public string ImePodjetja { get; set; }

        public string KontaktOsebaID { get; set; }

        public Oseba KontaktOseba { get; set; }

        public List<ClanModel> VsaClanstva { get; set; }

        public List<NajemModel> VsiNajemi { get; set; }

        public List<PartnerModel> VsaPartnerstva { get; set; }
        #endregion

        #region constr
        public Podjetje():base()
        {
            VsaClanstva = new List<ClanModel>();
            VsiNajemi = new List<NajemModel>();
            VsaPartnerstva = new List<PartnerModel>();
        }

        public Podjetje(string imePodjetja, string kontaktOsebaID)
            : this()
        {
            ImePodjetja = imePodjetja;
            KontaktOsebaID = kontaktOsebaID;
            
        }
        public Podjetje(string podjetjeID, string imePodjetja, string kontaktOsebaID)
            :this(imePodjetja,kontaktOsebaID)
        {
            PodjetjeID = podjetjeID;
            KontaktOseba = DBconn.GetOseba(kontaktOsebaID);
            NastaviPartnerstva();
            NastaviNajeme();
            NastaviClanstva();
        }

        private void NastaviClanstva()
        {
            VsaClanstva = DBconn.GetClanstva(PodjetjeID);
        }

        private void NastaviNajeme()
        {
            VsiNajemi = DBconn.GetNajeme(PodjetjeID);
        }

        private void NastaviPartnerstva()
        {
            VsaPartnerstva = DBconn.GetPartnerstva(PodjetjeID);
        }

        #endregion

        #region SQL
        internal void Create()
        {
            Action = "INSERT INTO podjetje (podjetjeID,imePodjetja,kontaktOseba) VALUES (NULL, \"" + ImePodjetja + "\", " + KontaktOsebaID + ");";
        }

        internal void Update()
        {
            if (PodjetjeID != null)
            {
                Action = "UPDATE podjetje SET imePodjetja=\"" + ImePodjetja + "\", kontaktOseba=" + KontaktOsebaID + " WHERE podjetjeID=" + PodjetjeID + ";";
            }
            else
                throw new Exception("Bad podjetjeID");
        }

        internal void Delete()
        {
            if (PodjetjeID != null)
            {
                Action = "DELETE FROm podjetje WHERE podjetjeID=" + PodjetjeID + ";";
            }
            else
                throw new Exception("Bad podjetjeID");
        }
        #endregion

        #region dispose
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion
    }


    public class PotencialnaStranka : TModel
    {
        #region props
        public string PotStrankaID { get; set; }

        public Stranka Stranka { get; set; }
        public string StrankaID { get; set; }

        public TipStranke TipStranka { get; set; }
        public string TipStrankaID { get; set; }

        #endregion

        #region constr
        public PotencialnaStranka():base(){}

        //Create
        public PotencialnaStranka(string strankaID,string tipStrankaID)
        {
            PotStrankaID = null;
            StrankaID = strankaID;
            TipStrankaID = tipStrankaID;

        }

        //Stuff
        public PotencialnaStranka(string id, string strankaID, string tipStrankaID)
            :this(strankaID,tipStrankaID)
        {
            
            PotStrankaID=id;
            TipStranka = DBconn.GetTipPotencialne(tipStrankaID);
            

        


        }
        #endregion

        #region SQLstavki
        internal void Create()
        {
            Action = "INSERT INTO potStranka (potStrankaID,stranka,tipStranka) VALUES (NULL, " + StrankaID + ", " + TipStrankaID + ");";
        }

        //Trenutno Update() ne potrebujem, saj ne moremo urejati pot strank le brišemo/dodajamo ?? MYBE LATER

        internal void Delete()
        {
            if (PotStrankaID != null)
            {
                Action = "DELETE FROM potStranka WHERE potStrankaID=" + PotStrankaID + ";";
            }
            else
                throw new Exception("No matching potStrankaID");
        }
        #endregion

        #region dispose
        protected override void Dispose(bool disposing)
        {
            if(Stranka!=null)
            {
                Stranka.Dispose();
                Stranka = null;
            }
            if(TipStranka!=null)
            {
                TipStranka.Dispose();
                TipStranka = null;
            }
            base.Dispose(disposing);
        }
        #endregion
    }

    
    public class TipStranke:TModel
    {
        
        public string TipStrankeID { get; set; }

        public string TipStra { get; set; }

        public TipStranke() : base() { }

        public TipStranke(string tipStrankeID, string tipStra)
        {
            TipStrankeID = tipStrankeID;
            TipStra = tipStra;
        }

    }


    public class ClanModel:TModel
    {
        #region props
        public string ClanID { get; set; }

        public Podjetje Podjetje { get; set; }
        public string PodjetjeID { get; set; }

        public TipClan TipClana { get; set; }
        public string TipClanaID { get; set; }

        
        //MOGOČE DATETIME ?? TEST..
        public string DatumZacClan { get; set; }

        public string DatumKoncClan { get; set; }

        internal string Izpis()
        {
            return String.Format("{0} : {1} - {2}", TipClana.TipClana, DatumZacClan, DatumKoncClan);
        }
        #endregion

        #region constr
        public ClanModel() : base() { }


        public ClanModel(string podjetjeID, string tipClanaID, string datumZac, string datumKon)
            :this()
        {
            ClanID = null;
            PodjetjeID = podjetjeID;
            TipClanaID = tipClanaID;
            TipClana = DBconn.GetTipClana(TipClanaID);
            DatumZacClan = datumZac;
            DatumKoncClan = datumKon;

        }

        public ClanModel(string id, string podjetjeID, string tipClanaID, string datumZac, string datumKon)
            :this(podjetjeID,tipClanaID,datumZac,datumKon)
        {
            ClanID = id;
            //Podjetje = DBconn.GetPodjetje(PodjetjeID);
            TipClana = DBconn.GetTipClana(TipClanaID);
        }
        #endregion

        #region SQLstavki

        internal void Create()
        {
            Action = "INSERT INTO clan VALUES (NULL, " + PodjetjeID + ", " + TipClanaID + ", \"" + DatumZacClan + "\", \"" + DatumKoncClan + "\");";
        }

        internal void Delete()
        {
            Action = "DELETE FROM clan WHERE clanID=" + ClanID + ";";
        }

        internal void Update()
        {
            Action = "UPDATE clan SET podjetje=" + PodjetjeID + ", tipClan=" + TipClanaID + ", datumZacClan=\"" + DatumZacClan + "\", datumKoncClan=\"" + DatumKoncClan + "\" WHERE clanID=" + ClanID + ";";
        }
        #endregion

        #region dispose
        protected override void Dispose(bool disposing)
        {
            if(Podjetje!=null)
            {
                Podjetje.Dispose();
                Podjetje = null;
            }
            if(TipClana!=null)
            {
                TipClana.Dispose();
                TipClana = null;
            }
            base.Dispose(disposing);
        }
        #endregion


        
    }


    public class TipClan:TModel
    {
        public string TipClanID { get; set; }

        public string TipClana { get; set; }

        public TipClan():base(){}

        public TipClan(string tipClanID, string tipClana)
            :this()
        {
            // TODO: Complete member initialization
            TipClanID = tipClanID;
            TipClana = tipClana;
        }
    }

    public class PartnerModel:TModel
    {

        #region props
        public string PartnerID { get; set; }

        public Podjetje Podjetje { get; set; }
        public string PodjetjeID { get; set; }

        public string Opis { get; set; }

        public string DatumZacPart { get; set; }
        public string DatumKonPart { get; set; }

        internal string Izpis()
        {
            return String.Format("{0} <- {1} - {2}", Opis, DatumZacPart, DatumKonPart);
        }
        #endregion

        #region constr
        public PartnerModel() : base() { }

        public PartnerModel(string podjetjeID, string opis, string datumZacPart, string datumKonPart, bool zeObstaja=false)
            :this()
        {
            PodjetjeID = podjetjeID;
            Opis = opis;
            DatumZacPart = datumZacPart;
            DatumKonPart = datumKonPart;

            if(zeObstaja)
            {
                Podjetje = DBconn.GetPodjetje(PodjetjeID);
            }
        }

        public PartnerModel(string partnerID, string podjetjeID, string opis, string datumZacPart, string datumKonPart, bool zeObstaja=false)
            :this(podjetjeID,opis,datumZacPart,datumKonPart,zeObstaja)
        {
            PartnerID = partnerID;
        }
        #endregion

        #region SQLstavki
        internal void Create()
        {
            Action = "INSERT INTO partner VALUES(NULL, " + PodjetjeID + ", \"" + Opis + "\", \"" + DatumZacPart + "\", \"" + DatumKonPart + "\");";
        }

        internal  void Update()
        {
            Action = "UPDATE partner SET podjetje=" + PodjetjeID + ", opis=\"" + Opis + "\", datumZacPart=\"" + DatumZacPart + "\", datumKonPart=\"" + DatumKonPart + "\" WHERE partnerID=" + PartnerID + ";";
        }
        internal void Delete()
        {
            Action = "DELETE FROM partner WHERE partnerID=" + PartnerID + ";";
        }
        #endregion

        #region dispose
        protected override void Dispose(bool disposing)
        {
            if(Podjetje!=null)
            {
                Podjetje.Dispose();
                Podjetje = null;
            }
            base.Dispose(disposing);
        }

        #endregion
    }

    public class NajemModel:TModel
    {
        #region props
        public string NajemID { get; set; }

        public Podjetje Podjetje { get; set; }
        public string PodjetjeID { get; set; }

        public string DatumZacNaj { get; set; }
        public string DatumKonNaj { get; set; }

        internal string Izpis()
        {
            return String.Format("{0} - {1}", DatumZacNaj, DatumKonNaj);
        }
        #endregion

        #region constr
        public NajemModel() : base() { }
        public NajemModel(string podjetjeID, string datumZac, string datumKon)
            :this()
        {
            NajemID=null;
            PodjetjeID = podjetjeID;
            DatumZacNaj = datumZac;
            DatumKonNaj = datumKon;

            
        }
        public NajemModel(string najemID, string podjetjeID, string datumZac, string datumKon)
            :this(podjetjeID,datumZac,datumKon)
        {
            
            NajemID = najemID;
        }

        #endregion

        #region SQLstavki

        internal void Create()
        {
            Action = "INSERT INTO najem VALUES (NULL, " + PodjetjeID + ", \"" + DatumZacNaj + "\", \"" + DatumKonNaj + "\");";
        }

        internal void Update()
        {
            Action = "UPDATE najem SET podjetje=" + PodjetjeID + ", datumZacNaj=\"" + DatumZacNaj + "\", datumKonNaj=\"" + DatumKonNaj + "\" WHERE najemID=" + NajemID + ";";
        }

        internal void Delete()
        {
            Action = "DELETE FROM najem WHERE najemID=" + NajemID + ";";
        }
        #endregion

        #region dispose

        protected override void Dispose(bool disposing)
        {
            if(Podjetje!=null)
            {
                Podjetje.Dispose();
                Podjetje = null;
            }
            base.Dispose(disposing);
        }

        #endregion
    }
}
