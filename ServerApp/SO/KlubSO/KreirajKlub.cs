using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace ServerApp.SO.KlubSO
{
    public class KreirajKlub : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Klub k = new Klub();
            k.KlubID = Broker.dajSesiju().vratiSifru(odo);
            Sesija.Broker.dajSesiju().insert(k);
            return k;
        }
    }
}
