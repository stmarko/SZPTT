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

namespace KlijentApp
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool poveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 10000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
        }


        public void kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Object pretraziTurnire(Turnir turnir)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziTurnire;
            transfer.TransferObjekat = turnir;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object kreirajTurnir()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajTurnir;
            transfer.TransferObjekat = new Turnir();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object obrisiTurnir(Turnir turnir)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiTurnir;
            transfer.TransferObjekat = turnir;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ucitajTurnir(Turnir turnir)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajTurnir;
            transfer.TransferObjekat = turnir;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object kreirajSportistu()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajSportistu;
            transfer.TransferObjekat = new Sportista();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object vratiSveSportiste()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveSportiste;
            transfer.TransferObjekat = new Sportista();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object kreirajKlub()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajKlub;
            transfer.TransferObjekat = new Klub();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object obrisiSportistu(Sportista sportista)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiSportistu;
            transfer.TransferObjekat = sportista;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ucitajSportistu(Sportista sportista)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajSportistu;
            transfer.TransferObjekat = sportista;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object zapamtiUcesca(Turnir turnir)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiTurnir;
            transfer.TransferObjekat = turnir;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object pretraziSportiste(Sportista s)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziSportiste;
            transfer.TransferObjekat = s;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
        public Object vratiSveKlubove()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveKlubove;
            transfer.TransferObjekat = new Klub();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object vratiSvaMesta()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSvaMesta;
            transfer.TransferObjekat = new Mesto();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        internal Object zapamtiKlub(Klub k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiKlub;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        internal Object zapamtiSportistu(Sportista sportista)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiSportistu;
            transfer.TransferObjekat = sportista;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
    }
}
