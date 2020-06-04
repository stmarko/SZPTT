using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije { Kraj=1,
        KreirajKlub = 2,
        VratiSvaMesta = 3,
        ZapamtiKlub = 4,
        KreirajSportistu = 5,
        VratiSveKlubove = 6,
        ZapamtiSportistu = 7,
        PretraziSportiste = 8,
        UcitajSportistu = 9,
        ObrisiSportistu = 10,
        KreirajTurnir = 11,
        VratiSveSportiste = 12,
        ZapamtiTurnir = 13,
        PretraziTurnire=14,
        UcitajTurnir=15,
        ObrisiTurnir = 16,
    }
    [Serializable]
    public class TransferKlasa
    {
        public Operacije Operacija;
        public Object TransferObjekat;
        public Object Rezultat;
    }
}
