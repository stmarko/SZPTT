using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Status { NijeMenjano, Dodato, Izmenjeno, Obrisano }
    [Serializable]
    public class Ucesce:OpstiDomenskiObjekat
    {
        int takmicarID;
        Turnir turnirID;
        Sportista sportista;
        string statusUZrebu;
        Status status;

        public override string ToString()
        {
            return sportista.Ime + " " + sportista.Prezime;
        }
        [Browsable(false)]
        public int TakmicarID
        {
            get
            {
                return takmicarID;
            }

            set
            {
                takmicarID = value;
            }
        }
        [Browsable(false)]
        public Turnir TurnirID
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

        public Sportista Sportista
        {
            get
            {
                return sportista;
            }

            set
            {
                sportista = value;
            }
        }

        public string StatusUZrebu
        {
            get
            {
                return statusUZrebu;
            }

            set
            {
                statusUZrebu = value;
            }
        }

        public Status Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        

        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Ucesce";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "TakmicarID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "TakmicarID=" + TakmicarID;
            }
        }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                return USLOV;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return " values("+TakmicarID+", "+turnirID.TurnirID+", "+sportista.SportistaID+",'"+StatusUZrebu+"')";
            }
        }
        [Browsable(false)]
        public string Update
        {
            get
            {
                return null;
            }
        }

       

        [Browsable(false)]
        public OpstiDomenskiObjekat procitajRed(DataRow red)
        {
            Ucesce u = new Ucesce();
            u.TakmicarID= Convert.ToInt32(red["TakmicarID"]);
            u.TurnirID = new Turnir();
            u.TurnirID.TurnirID = Convert.ToInt32(red["TurnirID"]);
            u.Sportista = new Sportista();
            u.Sportista.SportistaID = Convert.ToInt32(red["SportistaID"]);
            u.StatusUZrebu = red[("StatusUZrebu")].ToString();

            return u;
        }
        #endregion ODO
    }
}
