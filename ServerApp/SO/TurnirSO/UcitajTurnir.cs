using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;

namespace ServerApp.SO.TurnirSO
{
    class UcitajTurnir : OpstaSO
    {
        public override object Izvrsi(OpstiDomenskiObjekat odo)
        {
            Turnir t = odo as Turnir;
            
            t.Mesto = Sesija.Broker.dajSesiju().vratiJedanZaID(t.Mesto) as Mesto;
            t.Klub = Sesija.Broker.dajSesiju().vratiJedanZaID(t.Klub) as Klub;
           
            Ucesce uc = new Ucesce();
            uc.USLOV = " TurnirID=" + t.TurnirID;
            List<Ucesce> lista = Sesija.Broker.dajSesiju().vratiSveZaUslovOpsti(uc).OfType<Ucesce>().ToList<Ucesce>();

            foreach (Ucesce u in lista)
            {

                u.Sportista = Sesija.Broker.dajSesiju().vratiJedanZaID(u.Sportista) as Sportista;
                u.TurnirID = Sesija.Broker.dajSesiju().vratiJedanZaID(u.TurnirID) as Turnir;
                t.SpisakUcesca.Add(u);
            }
            return t;
        }
    }
}
