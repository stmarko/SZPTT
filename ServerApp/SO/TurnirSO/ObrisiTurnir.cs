using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.TurnirSO
{
    public class ObrisiTurnir : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Sesija.Broker.dajSesiju().deleteJedan(odo);
            return true;
        }
    }
}
