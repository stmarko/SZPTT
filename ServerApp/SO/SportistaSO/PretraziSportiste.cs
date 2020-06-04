using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SportistaSO
{
    class PretraziSportiste : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Sportista s = new Sportista();
            
            return Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(odo).OfType<Sportista>().ToList<Sportista>();
        }
    }
}
