using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Klub:OpstiDomenskiObjekat
    {
        int klubID;
        string nazivKluba;
        string skraceniNaziv;
        string adresa;
        string telefon;
        int brojTerena;
        Mesto mesto;


        public override string ToString()
        {
            return nazivKluba;
        }

        public int KlubID
        {
            get
            {
                return klubID;
            }

            set
            {
                klubID = value;
            }
        }

        public string NazivKluba
        {
            get
            {
                return nazivKluba;
            }

            set
            {
                nazivKluba = value;
            }
        }

        public string SkraceniNaziv
        {
            get
            {
                return skraceniNaziv;
            }

            set
            {
                skraceniNaziv = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string Telefon
        {
            get
            {
                return telefon;
            }

            set
            {
                telefon = value;
            }
        }

        public int BrojTerena
        {
            get
            {
                return brojTerena;
            }

            set
            {
                brojTerena = value;
            }
        }

        public Mesto Mesto
        {
            get
            {
                return mesto;
            }

            set
            {
                mesto = value;
            }
        }
        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Klub";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "KlubID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "KlubID=" + KlubID;
            }
        }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                if (USLOV == null) return "NazivKluba like '" + NazivKluba + "%'";
                //return " NazivKluba like '" + NazivKluba + "%' or SkraceniNaziv like '" + SkraceniNaziv+ "%' or MestoID like '" + Mesto.MestoID+ "'";
                else return USLOV;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return " (KlubID) values (" + KlubID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                 return " NazivKluba='" + NazivKluba+ "', SkraceniNaziv='" + SkraceniNaziv+ "', Adresa='" + Adresa+ "',BrojTelefona='" + Telefon+ "', BrojTerena=" + BrojTerena + ", MestoID="+Mesto.MestoID+"";
                
            }
        }


        [Browsable(false)]
        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Klub k = new Klub();
            k.KlubID = Convert.ToInt32(red["KlubID"]);
            k.NazivKluba = red["NazivKluba"].ToString();
            k.SkraceniNaziv = red["SkraceniNaziv"].ToString();
            k.Adresa = red["Adresa"].ToString();
            k.Telefon = red["BrojTelefona"].ToString();
            k.BrojTerena = Convert.ToInt32(red["BrojTerena"]);
            k.Mesto = new Mesto();
            k.Mesto.MestoID = Convert.ToInt32(red["MestoID"]);

            return k;
        }
        #endregion ODO
    }
}
