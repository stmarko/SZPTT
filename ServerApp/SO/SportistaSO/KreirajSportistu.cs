using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace ServerApp.SO.SportistaSO
{
    class KreirajSportistu : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Sportista s = new Sportista();
            s.SportistaID = Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(s);
            return s;
        }
    }
}
