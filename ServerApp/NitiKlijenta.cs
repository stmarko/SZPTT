using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domen;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using ServerApp.SO.KlubSO;
using ServerApp.SO;
using ServerApp.SO.SportistaSO;
using ServerApp.SO.TurnirSO;

namespace ServerApp
{
    class NitiKlijenta
    {
        private NetworkStream tok;
        BinaryFormatter formater;

        public NitiKlijenta(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart nitDelegat = obradiZahtev;
            new Thread(nitDelegat).Start();
        }

        void obradiZahtev()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;

                    switch (transfer.Operacija)
                    {
                        case Operacije.KreirajKlub:
                            KreirajKlub kk = new SO.KlubSO.KreirajKlub();
                            transfer.Rezultat = kk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSvaMesta:
                            VratiSvaMesta vsm = new VratiSvaMesta();
                            transfer.Rezultat = vsm.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiKlub:
                            ZapamtiKlub zk = new SO.KlubSO.ZapamtiKlub();
                            transfer.Rezultat = zk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveKlubove:
                            VratiSveKlubove vsk = new VratiSveKlubove();
                            transfer.Rezultat = vsk.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajSportistu:
                            KreirajSportistu ks = new SO.SportistaSO.KreirajSportistu();
                            transfer.Rezultat = ks.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiSportistu:
                            ZapamtiSportistu zs = new SO.SportistaSO.ZapamtiSportistu();
                            transfer.Rezultat = zs.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziSportiste:
                            PretraziSportiste ps = new PretraziSportiste();
                            transfer.Rezultat = ps.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajSportistu:
                            UcitajSportistu us = new UcitajSportistu();
                            transfer.Rezultat = us.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiSportistu:
                            ObrisiSportistu os = new ObrisiSportistu();
                            transfer.Rezultat = os.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.KreirajTurnir:
                            KreirajTurnir kt = new KreirajTurnir();
                            transfer.Rezultat = kt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.VratiSveSportiste:
                            VratiSveSportiste vss = new VratiSveSportiste();
                            transfer.Rezultat = vss.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ZapamtiTurnir:
                            ZapamtiTurnir zt = new ZapamtiTurnir();
                            transfer.Rezultat = zt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.PretraziTurnire:
                            PretraziTurnire pt = new PretraziTurnire();
                            transfer.Rezultat = pt.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.UcitajTurnir:
                            UcitajTurnir ut = new UcitajTurnir();
                            transfer.Rezultat = ut.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.ObrisiTurnir:
                            ObrisiTurnir ot = new ObrisiTurnir();
                            transfer.Rezultat = ot.IzvrsiSO(transfer.TransferObjekat as OpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;

                        case Operacije.Kraj:
                            operacija = 1;
                            Server.listaTokovaKlijenata.Remove(tok);
                            break;
                        default:
                            break;

                            
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    Server.listaTokovaKlijenata.Remove(tok);
                }
                catch (Exception)
                {

                   
                }
               
            }
        }
    }
}
