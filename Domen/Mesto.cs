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
    public class Mesto:OpstiDomenskiObjekat
    {
        int mestoID;
        string naziv;

        public override string ToString()
        {
            return naziv;
        }

        public int MestoID
        {
            get
            {
                return mestoID;
            }

            set
            {
                mestoID = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }
        #region ODO
        [Browsable(false)]
        public string Tabela
        {
            get
            {
                return "Mesto";
            }
        }
        [Browsable(false)]
        public string ID
        {
            get
            {
                return "MestoID";
            }
        }
        [Browsable(false)]
        public string UslovID
        {
            get
            {
                return "MestoID=" + MestoID;
            }
        }
        [Browsable(false)]
        public string USLOV;
        [Browsable(false)]
        public string UslovOpsti
        {
            get
            {
                if (USLOV == null) return " Mesto like '" + Naziv + "%' or MestoID like '" + MestoID + "%'";
                else return USLOV;
            }
        }
        [Browsable(false)]
        public string Insert
        {
            get
            {
                return null;
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
            Mesto m = new Mesto();
            m.MestoID = Convert.ToInt32(red["MestoID"]);
            m.Naziv = red["Naziv"].ToString();

            return m;
        }
        #endregion ODO

    }
}
