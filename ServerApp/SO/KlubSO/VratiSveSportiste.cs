using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.KlubSO
{
    class VratiSveSportiste : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            return Sesija.Broker.dajSesiju().vratiSve(odo).OfType<Sportista>().ToList<Sportista>();
        }
    }
}
