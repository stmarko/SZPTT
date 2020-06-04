using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentApp
{
    public class KontrolerKI
    {
        static Komunikacija komunikacija;
        static Klub klub;
        static Sportista sportista;
        static Turnir turnir;

        public static string poveziSeNaServer()
        {
            komunikacija = new Komunikacija();
            if( komunikacija.poveziSeNaServer())
            {
                return "Klijent je povezan na server!";
            }
            else
            {
                
                return "Klijent nije povezan na server!";
            }
        }

        internal void popuniPoljaTurnira(TextBox txtNazivTurnira, TextBox txtDatumOd, TextBox txtDatumDO, TextBox txtKonkurencija, ComboBox cmbKlub, ComboBox cmbMesto, ComboBox cmbUcesnici, DataGridView dgvIzmenaUcesnika, ComboBox cmbPobednik, Button btnDodajUcesnika, Button btnObrisiUcesnika)
        {
            cmbKlub.DataSource = komunikacija.vratiSveKlubove();
            cmbMesto.DataSource = komunikacija.vratiSvaMesta();
            cmbUcesnici.DataSource = komunikacija.vratiSveSportiste();
            cmbKlub.Text = turnir.Klub.ToString();
            cmbMesto.Text = turnir.Mesto.ToString();
            txtNazivTurnira.Text = turnir.NazivTurnira;
            txtDatumOd.Text = turnir.DatumOd.ToString("dd.MM.yyyy");
            txtDatumDO.Text = turnir.DatumDo.ToString("dd.MM.yyyy");
            txtKonkurencija.Text = turnir.Konkurencija.ToString();
            cmbPobednik.Text = turnir.Pobednik;
           // List<Ucesce> lista = new List<Ucesce>();
            //foreach (Ucesce u in turnir.SpisakUcesca) lista.Add(u);
            dgvIzmenaUcesnika.DataSource = turnir.SpisakUcesca;
            if (DateTime.Now < turnir.DatumOd)
            {
                btnDodajUcesnika.Enabled = true;
                btnObrisiUcesnika.Enabled = true;
            }
            if (DateTime.Now > turnir.DatumDo && cmbPobednik.Text=="")
            {
                cmbPobednik.Enabled = true;
                cmbPobednik.DataSource = turnir.SpisakUcesca;
            }
        }

        internal bool obrisiTurnir()
        {
            Object rez = komunikacija.obrisiTurnir(turnir);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obriše turnir!", "Greška!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao turnir!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        internal void pretraziTurnire(TextBox txtFilter, DataGridView dataGridView1)
        {
            turnir = new Turnir();
            turnir.NazivTurnira= txtFilter.Text;

            List<Turnir> lista = komunikacija.pretraziTurnire(turnir) as List<Turnir>;
            dataGridView1.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronađe turnir!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne može da pronađe turnir/e za zadati  kriterijum!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (txtFilter.Text != "")
            {
                MessageBox.Show("Sistem je pronašao turnire po zadatom kriterijumu!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sistem je pronašao turnire!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        internal bool ucitajTurnir(DataGridView dataGridView1)
        {
            try
            {
                turnir = dataGridView1.CurrentRow.DataBoundItem as Turnir;
                turnir = komunikacija.ucitajTurnir(turnir) as Turnir;

                if (turnir == null)
                {
                    MessageBox.Show("Sistem ne moze da učita turnir!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je učitao turnir!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        internal void kreirajTurnir(TextBox txtIDTurnir, DataGridView dataGridView1, GroupBox groupBox1, Button btnDodaj)
        {
            turnir = komunikacija.kreirajTurnir() as Turnir;

            if (turnir == null)
            {
                MessageBox.Show("Sistem ne može da kreira turnir!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sistem je kreirao turnir!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtIDTurnir.Text = turnir.TurnirID.ToString();           
               groupBox1.Enabled = true;
               dataGridView1.DataSource = turnir.SpisakUcesca;
                btnDodaj.Enabled = true;
            }
        }

        internal bool zapamtiTurnir(TextBox txtNazivTurnira, TextBox txtDatumOd, TextBox txtDatumDO, TextBox txtKonkurencija, ComboBox cmbKlub, ComboBox cmbMesto, ComboBox cmbPobednik)
        {

            if (turnir == null)
            {
                MessageBox.Show("Morate prvo kreirati turnir!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            turnir.NazivTurnira= txtNazivTurnira.Text;
            if (turnir.NazivTurnira == "")
            {
                MessageBox.Show("Unesite ispravan naziv turnira!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNazivTurnira.Focus();
                return false;
            }
            try
            {
                turnir.DatumOd = DateTime.ParseExact(txtDatumOd.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite ispravan datum. Format mora biti:dd.MM.yyyy", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDatumOd.Focus();
                return false;
            }
            try
            {
                turnir.DatumDo = DateTime.ParseExact(txtDatumDO.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite ispravan datum. Format mora biti:dd.MM.yyyy", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDatumDO.Focus();
                return false;
            }
            if (turnir.DatumOd > turnir.DatumDo)
            {
                MessageBox.Show("Datum nije ispravan! Datum početka ne može biti nakon datuma završetka turnira!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                turnir.Konkurencija = Convert.ToInt32(txtKonkurencija.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Konkurencija nije ispravno uneta!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKonkurencija.Focus();
                return false;
            }
            turnir.Klub = cmbKlub.SelectedItem as Klub;
            if (turnir.Klub == null)
            {
                MessageBox.Show("Izaberite klub!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKlub.Focus();
                return false;
            }
            turnir.Mesto = cmbMesto.SelectedItem as Mesto;
            if (turnir.Mesto == null)
            {
                MessageBox.Show("Izaberite mesto!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMesto.Focus();
                return false;
            }

            if (cmbPobednik.Enabled=true && cmbPobednik != null) 
            {
                turnir.Pobednik = cmbPobednik.Text.ToString();
                cmbPobednik.Enabled = false;
            }


            Object rez = komunikacija.zapamtiUcesca(turnir);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti turnir!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio turnir!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        internal void obrisiUcesce(DataGridView dataGridView1)
        {
            try
            {
                Ucesce u = dataGridView1.CurrentRow.DataBoundItem as Ucesce;
                if (u.Status == Status.Dodato) turnir.SpisakUcesca.Remove(u);
                else u.Status = Status.Obrisano;
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali učesnika.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal bool dodajUcesce(ComboBox cmbUcesnici, TextBox txtStatus)
        {
           Ucesce u = new Ucesce();
            u.Status = Status.Dodato;
            u.Sportista = cmbUcesnici.SelectedItem as Sportista;
            u.TurnirID= turnir;
            u.StatusUZrebu = txtStatus.Text;

            if(!(u.StatusUZrebu=="QA" || u.StatusUZrebu=="DA" || u.StatusUZrebu == "WC" ||
                u.StatusUZrebu == "qa" || u.StatusUZrebu == "da" || u.StatusUZrebu == "wc"))
            {
                MessageBox.Show("Status nije ispravno unet!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach(Ucesce uces in turnir.SpisakUcesca)
            {
                if (uces.Sportista.SportistaID == u.Sportista.SportistaID)
                {
                    MessageBox.Show("Ne možete dva puta uneti istog igrača.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

           turnir.SpisakUcesca.Add(u);
           return true;
        }

        internal void popuniPoljaZaTurnir(ComboBox cmbKlub, ComboBox cmbMesto, ComboBox cmbUcesnici)
        {
            cmbUcesnici.DataSource = komunikacija.vratiSveSportiste();
            cmbKlub.DataSource = komunikacija.vratiSveKlubove();
            cmbMesto.DataSource = komunikacija.vratiSvaMesta();
            
        }

        internal void kreirajSportistu(TextBox txtIDSportista, ComboBox cmbMesto, ComboBox cmbKlub, GroupBox groupBox1, Button btnKreirajSportistu)
        {
            sportista = komunikacija.kreirajSportistu() as Sportista;
            if (sportista == null)
            {
                MessageBox.Show("Sistem ne može da kreira sportistu.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Sistem je kreirao sportistu.", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDSportista.Text = sportista.SportistaID.ToString();
                cmbMesto.DataSource = komunikacija.vratiSvaMesta();
                cmbKlub.DataSource = komunikacija.vratiSveKlubove();
                //cmbMesto.Text = "Izaberite: ";
                btnKreirajSportistu.Enabled = false;
            }
        }

       

        internal void popuniPolja(TextBox txtIme, TextBox txtPrezime, TextBox txtDatum, TextBox txtEmail, ComboBox cmbKlub, ComboBox cmbMesto)
        {
            cmbKlub.DataSource = komunikacija.vratiSveKlubove();
            cmbMesto.DataSource = komunikacija.vratiSvaMesta();

            txtIme.Text = sportista.Ime;
            txtPrezime.Text = sportista.Prezime;
            txtDatum.Text = sportista.DatumRodjenja.ToString("dd.MM.yyyy");
            txtEmail.Text = sportista.Email;
            cmbKlub.Text = sportista.Klub.ToString();
            cmbMesto.Text = sportista.Mesto.ToString();
        }

        internal bool ucitajSportistu(DataGridView dataGridView1)
        {
            try
            {
                sportista = dataGridView1.CurrentRow.DataBoundItem as Sportista;
                sportista = komunikacija.ucitajSportistu(sportista) as Sportista;

                if (sportista == null)
                {
                    MessageBox.Show("Sistem ne moze da učita podatke o sportisti!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je učitao podatke o sportisti!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Niste odabrali!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        internal void pretraziSportiste(TextBox txtFilter, DataGridView dataGridView1)
        {
           sportista = new Sportista();
           sportista.Ime = txtFilter.Text;
           sportista.Prezime = txtFilter.Text;

            List<Sportista> lista = komunikacija.pretraziSportiste(sportista) as List<Sportista>;
            dataGridView1.DataSource = lista;
            if (lista == null)
            {
                MessageBox.Show("Sistem ne može da pronadje sportiste!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (lista.Count == 0)
            {
                MessageBox.Show("Sistem ne može da pronađe sportistu/e za zadati  kriterijum!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (txtFilter.Text != "")
            {
                MessageBox.Show("Sistem je pronašao sportiste po zadatom kriterijumu!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Sistem je pronašao sportiste!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        internal bool zapamtiSportistu(TextBox txtIme, TextBox txtPrezime, TextBox txtDatum, TextBox txtEmail, ComboBox cmbMesto, ComboBox cmbKlub)
        {
            if (sportista == null)
            {
                MessageBox.Show("Morate prvo kreirati sportistu!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            sportista.Ime = txtIme.Text;
            if (sportista.Ime == "")
            {
                MessageBox.Show("Unesite ime!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIme.Focus();
                return false;
            }

            sportista.Prezime = txtPrezime.Text;
            if (sportista.Prezime == "")
            {
                MessageBox.Show("Unesite Prezime!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrezime.Focus();
                return false;
            }

            try
            {
                sportista.DatumRodjenja = DateTime.ParseExact(txtDatum.Text, "dd.MM.yyyy", null);
            }
            catch (Exception)
            {
                MessageBox.Show("Neispravan datum. Datum treba uneti u formatu dd.MM.yyyy", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDatum.Focus();
                return false;
            }

            sportista.Email = txtEmail.Text;
            if (sportista.Email == "")
            {
                MessageBox.Show("Unesite Email!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!sportista.Email.Contains('@'))
            {
                MessageBox.Show("Neispravan mail!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (sportista.Email != "" &&  (sportista.Email[0] == '@' || sportista.Email[sportista.Email.Length - 1] == '@'))
            {
                MessageBox.Show("Ne sme '@' na početku ili na kraju!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            sportista.Mesto = cmbMesto.SelectedItem as Mesto;
            if (sportista.Mesto == null)
            {
                MessageBox.Show("Izaberite mesto!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMesto.Focus();
                return false;
            }
            sportista.Klub = cmbKlub.SelectedItem as Klub;
            if (sportista.Klub == null)
            {
                MessageBox.Show("Izaberite klub!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbKlub.Focus();
                return false;
            }
            Object rez = komunikacija.zapamtiSportistu(sportista);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti sportistu!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio sportistu!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }
        internal bool obrisiSportistu()
        {
            Object rez = komunikacija.obrisiSportistu(sportista);

            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da obriše sportistu!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao sportistu!", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }


        internal void kreirajKlub(TextBox txtIDKlub, ComboBox cmbMesto, GroupBox groupBox1, Button btnKreirajKlub)
        {
            klub = komunikacija.kreirajKlub() as Klub;
            if (klub == null)
            {
                MessageBox.Show("Sistem ne može da kreira klub.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Sistem je kreirao klub.", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDKlub.Text = klub.KlubID.ToString();
                cmbMesto.DataSource = komunikacija.vratiSvaMesta();
                //cmbMesto.Text = "Izaberite: ";
                btnKreirajKlub.Enabled = false;
            }
        }

        internal bool zapamtiKlub(TextBox txtNazivKluba, TextBox txtSkraceniNaziv, TextBox txtBrojTerena, ComboBox cmbMesto, TextBox txtAdresa, TextBox txtBrojTelefona)
        {
            if (klub == null) {
                MessageBox.Show("Morate prvo kreirati klub!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
              }
            
            klub.NazivKluba = txtNazivKluba.Text;
            if (klub.NazivKluba == "")
            {
                MessageBox.Show("Unesite ispravan naziv kluba!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNazivKluba.Focus();
                return false;
            }

            klub.SkraceniNaziv = txtSkraceniNaziv.Text;
            if (klub.SkraceniNaziv == "")
            {
                MessageBox.Show("Unesite ispravnu skracenicu!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSkraceniNaziv.Focus();
                return false;
            }

            try
            {
                klub.BrojTerena = Convert.ToInt32(txtBrojTerena.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Unesite ispravan broj!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrojTerena.Focus();
                return false;
            }

            klub.Mesto = cmbMesto.SelectedItem as Mesto;
            if (klub.Mesto == null)
            {
                MessageBox.Show("Izaberite mesto!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMesto.Focus();
                return false;
            }

            klub.Adresa = txtAdresa.Text;
            if (klub.Adresa == "")
            {
                MessageBox.Show("Unesite ispravnu adresu!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdresa.Focus();
                return false;
            }

            klub.Telefon = txtBrojTelefona.Text;
            if (klub.Telefon == "")
            {
                MessageBox.Show("Unesite ispravan broj telefona!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrojTelefona.Focus();
                return false;
            }

            Object rez = komunikacija.zapamtiKlub(klub);
            if (rez == null)
            {
                MessageBox.Show("Sistem ne može da zapamti klub.", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio klub.", "Potvrda!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        public static void kraj()
        {
            try
            {
                komunikacija.kraj();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
        }

    }
}
