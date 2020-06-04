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
    public class Sportista:OpstiDomenskiObjekat
    {
        int sportistaID;
        string ime;
        string prezime;
        DateTime datumRodjenja;
        string email;
        Mesto mesto;
        Klub klub;

        public override string ToString()
        {
            return ime + " " + prezime;
        }

        [Browsable(false)]
        public int SportistaID
        {
            get
            {
                return sportistaID;
            }

            set
            {
                sportistaID = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                datumRodjenja = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        [Browsable(false)]
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
        [Browsable(false)]
        public Klub Klub
        {
            get
            {
                return klub;
            }

            set
            {
                klub = value;
            }
        }

        #region ODO
        [Browsable (false)]
        public string Tabela
        {
            get
            {
                return "Sportista";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "SportistaID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "SportistaID=" + SportistaID;
            }
        }

        public string USLOV;
        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                if (USLOV == null) return "Ime like '" + Ime + "%' or Prezime like '" + Prezime+ "%'";
                //return " NazivKluba like '" + NazivKluba + "%' or SkraceniNaziv like '" + SkraceniNaziv+ "%' or MestoID like '" + Mesto.MestoID+ "'";
                else return USLOV;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return " (SportistaID) values (" + SportistaID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return "Ime='" + Ime + "', Prezime='" + Prezime + "',DatumRodjenja='" + DatumRodjenja.ToString() + "',Email='" + Email+ "', MestoID=" + Mesto.MestoID+ ", KlubId=" + Klub.KlubID + "";
            }
        }

        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Sportista s = new Sportista();
            s.SportistaID = Convert.ToInt32(red["SportistaID"]);
            s.Ime = red["Ime"].ToString();
            s.Prezime = red["Prezime"].ToString();
            s.DatumRodjenja = Convert.ToDateTime(red["DatumRodjenja"]);
            s.Email = red["Email"].ToString();
            s.Mesto = new Mesto();
            s.Mesto.MestoID = Convert.ToInt32(red["MestoID"]);
            s.Klub = new Klub();
            s.Klub.KlubID = Convert.ToInt32(red["KlubID"]);

            return s;
        }
        #endregion
    }
}
