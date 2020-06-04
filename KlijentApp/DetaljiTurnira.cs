using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentApp
{
    public partial class DetaljiTurnira : Form
    {
        KontrolerKI kki = new KontrolerKI();
        Timer t;
        public DetaljiTurnira()
        {
            InitializeComponent();
        }

        private void dgvIzmenaUcesnika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DetaljiTurnira_Load(object sender, EventArgs e)
        {
            kki.popuniPoljaTurnira(txtNazivTurnira, txtDatumOd,txtDatumDO,txtKonkurencija, cmbKlub, cmbMesto, cmbUcesnici,dgvIzmenaUcesnika,cmbPobednik, btnDodajUcesnika,btnObrisiUcesnika);
            //t = new Timer();
            //t.Interval = 1000;
            //t.Tick += osvezi;
            //t.Start();

        }

        private void btnObrisiUcesnika_Click(object sender, EventArgs e)
        {
            kki.obrisiUcesce(dgvIzmenaUcesnika);
        }

        private void btnDodajUcesnika_Click(object sender, EventArgs e)
        {
            kki.dodajUcesce(cmbUcesnici, txtStatus);
        }

        private void osvezi(object sender, EventArgs e)
        {
          
        }

        private void btnZapamtiSportistu_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiTurnir(txtNazivTurnira, txtDatumOd, txtDatumDO, txtKonkurencija, cmbKlub, cmbMesto, cmbPobednik)) {
               
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Da li ste sigurni da želite da obrišete turnir?", "Upozorenje!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (kki.obrisiTurnir()) {
                    
                    this.Close(); }
            }
            else if (dialog == DialogResult.No)
            {
                this.Close();
            }
        }

        private void DetaljiTurnira_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
