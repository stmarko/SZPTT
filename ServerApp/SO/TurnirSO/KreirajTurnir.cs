using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.TurnirSO
{
    class KreirajTurnir : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Turnir t = new Turnir();
            t.TurnirID = Sesija.Broker.dajSesiju().vratiSifru(t);
            Sesija.Broker.dajSesiju().insert(t);
            return t;
        }
    }
}
