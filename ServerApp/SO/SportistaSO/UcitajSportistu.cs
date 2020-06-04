using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.SportistaSO
{
    class UcitajSportistu : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Sportista s = odo as Sportista;
            s.Mesto = Sesija.Broker.dajSesiju().vratiJedanZaID(s.Mesto) as Mesto;
            s.Klub = Sesija.Broker.dajSesiju().vratiJedanZaID(s.Klub) as Klub;
            return s;
        }
    }
}
