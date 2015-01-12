using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTpApp
{
    class Razredi
    {
    }
    public class Item
    {
        public string Ime;
        public int Indeks;
        public Item(string ime, int indeks)
        {
            Ime = ime;
            Indeks = indeks;
        }
    }
    public class ClanPodjetja
    {
        public bool Nov { get; set; }
        public string Izpis { get; set; }
        public string ClanID { get; set; }
        public string Podjetje { get; set; }
        public string TipClan { get; set; }
        public string DatumZacClan { get; set; }
        public string DatumKonClan { get; set; }
        public string Sql { get; set; }

        public ClanPodjetja(string izpis,string sql,string clanID,string podjetje,string tipClan,string datumZacClan,string datumKonClan,bool nov=false)
        {
            Izpis = izpis;
            ClanID = clanID;
            Podjetje = podjetje;
            TipClan = tipClan;
            DatumZacClan = datumZacClan;
            DatumKonClan = datumKonClan;
            Sql = sql;
            Nov = nov;
        }
    }
    public class PartnerPodjetja
    {
        public bool Nov { get; set; }
        public string Izpis { get; set; }
        public string PartnerID { get; set; }
        public string Podjetje { get; set; }
        public string Opis { get; set; }
        public string DatumZacClan { get; set; }
        public string DatumKonClan { get; set; }
        public string Sql { get; set; }

        public PartnerPodjetja(string izpis, string sql, string partnerID, string podjetje, string opis, string datumZacClan, string datumKonClan,bool nov=false)
        {
            Izpis = izpis;
            PartnerID = partnerID;
            Podjetje = podjetje;
            Opis = opis;
            DatumZacClan = datumZacClan;
            DatumKonClan = datumKonClan;
            Sql = sql;
            Nov = nov;
        }
    }
    public class NajemPodjetja
    {
        public bool Nov { get; set; }
        public string Izpis { get; set; }
        public string NajemID { get; set; }
        public string Podjetje { get; set; }
        public string DatumZacClan { get; set; }
        public string DatumKonClan { get; set; }
        public string Sql { get; set; }

        public NajemPodjetja(string izpis, string sql, string najemID, string podjetje, string datumZacClan, string datumKonClan,bool nov=false)
        {
            Izpis = izpis;
            NajemID = najemID;
            Podjetje = podjetje;
            DatumZacClan = datumZacClan;
            DatumKonClan = datumKonClan;
            Sql = sql;
            Nov = nov;
        }
    }

}
