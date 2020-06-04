using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.TurnirSO
{
    class ZapamtiTurnir : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Turnir t = odo as Turnir;

            Sesija.Broker.dajSesiju().updateJedan(t);

            foreach (Ucesce uc in t.SpisakUcesca)
            {
                switch (uc.Status)
                {

                    case Status.Dodato:
                        uc.TakmicarID= Sesija.Broker.dajSesiju().vratiSifru(uc);
                        Sesija.Broker.dajSesiju().insert(uc);
                        break;
                    case Status.Izmenjeno:
                        Sesija.Broker.dajSesiju().updateJedan(uc);
                        break;
                    case Status.Obrisano:
                        Sesija.Broker.dajSesiju().deleteJedan(uc);

                        break;
                    default:
                        break;
                }
            }

            return true;
        }
    }
}
