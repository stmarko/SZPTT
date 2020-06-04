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
    public partial class KreirajTurnir : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public KreirajTurnir()
        {
            InitializeComponent();
        }

        private void btnKreirajSportistu_Click(object sender, EventArgs e)
        {
            kki.kreirajTurnir(txtIDTurnir, dataGridView1, groupBox1, btnDodaj);
                
        }

        private void KreirajTurnir_Load(object sender, EventArgs e)
        {
            
            kki.popuniPoljaZaTurnir(cmbKlub, cmbMesto,cmbUcesnici);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kki.dodajUcesce(cmbUcesnici, txtStatus);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.obrisiUcesce(dataGridView1);
        }

        private void btnZapamtiSportistu_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiTurnir(txtNazivTurnira, txtDatumOd, txtDatumDO,txtKonkurencija,cmbKlub,cmbMesto,cmbPobednik)) this.Close();
        }
    }
}
