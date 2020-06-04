using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.TurnirSO
{
    class PretraziTurnire : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Turnir t = new Turnir();

            return Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(odo).OfType<Turnir>().ToList<Turnir>();
        }
    }
}
