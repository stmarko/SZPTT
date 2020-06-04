using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Sesija;

namespace ServerApp.SO.KlubSO
{
    public class ZapamtiKlub : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Sesija.Broker.dajSesiju().updateJedan(odo);
            return true;
        }
    }
}
