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
    public class Turnir:OpstiDomenskiObjekat
    {

       

        public Turnir()
        {
            SpisakUcesca = new BindingList<Ucesce>();
        }

        int turnirID;
        string nazivTurnira;
        int konkurencija;
        DateTime datumOd;
        DateTime datumDo;
        string pobednik;
        Mesto mesto;
        Klub klub;
        BindingList<Ucesce> spisakUcesca;

        public int TurnirID
        {
            get
            {
                return turnirID;
            }

            set
            {
                turnirID = value;
            }
        }

        public string NazivTurnira
        {
            get
            {
                return nazivTurnira;
            }

            set
            {
                nazivTurnira = value;
            }
        }

        public int Konkurencija
        {
            get
            {
                return konkurencija;
            }

            set
            {
                konkurencija = value;
            }
        }

        public DateTime DatumOd
        {
            get
            {
                return datumOd;
            }

            set
            {
                datumOd = value;
            }
        }

        public DateTime DatumDo
        {
            get
            {
                return datumDo;
            }

            set
            {
                datumDo = value;
            }
        }

        public string Pobednik
        {
            get
            {
                return pobednik;
            }

            set
            {
                pobednik = value;
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
        [Browsable(false)]
        public BindingList<Ucesce> SpisakUcesca
        {
            get
            {
                return spisakUcesca;
            }

            set
            {
                spisakUcesca = value;
            }
        }

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Turnir";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "TurnirID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "TurnirID=" + TurnirID;
            }
        }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                if (USLOV == null) return "Naziv like '" + NazivTurnira + "%'";
                
                else return USLOV;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return " (TurnirID) values (" + TurnirID + ")";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return " Naziv='" + NazivTurnira + "',Konkurencija="+Konkurencija+", DatumOd='" + DatumOd+ "', DatumDo='" + DatumDo + "',Pobednik='" + Pobednik+ "', Mesto=" + Mesto.MestoID+ ", Klub=" + Klub.KlubID+ "";

            }
        }

        

        [Browsable(false)]
        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Turnir t = new Turnir();
            t.TurnirID = Convert.ToInt32(red["TurnirID"]);
            t.NazivTurnira = red["Naziv"].ToString();
            t.Konkurencija = Convert.ToInt32(red["Konkurencija"]);
            t.DatumOd= Convert.ToDateTime(red["DatumOd"]);
            t.DatumDo = Convert.ToDateTime(red["DatumDo"]);
            t.Pobednik = red["Pobednik"].ToString();
            t.Mesto = new Mesto();
            t.Mesto.MestoID = Convert.ToInt32(red["Mesto"]);
            t.Klub = new Klub();
            t.Klub.KlubID = Convert.ToInt32(red["Klub"]);
            return t;

            
        }
        #endregion ODO
    }
}
