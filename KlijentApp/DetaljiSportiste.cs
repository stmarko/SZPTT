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
    public partial class DetaljiSportiste : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public DetaljiSportiste()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Da li ste sigurni da želite da obrišete sportistu?", "Upozorenje!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (kki.obrisiSportistu()) this.Close();
            }
            else if (dialog == DialogResult.No)
            {
                this.Close();
            }
        }

        private void DetaljiSportiste_Load(object sender, EventArgs e)
        {
            kki.popuniPolja(txtIme, txtPrezime, txtDatum, txtEmail, cmbKlub,cmbMesto);
        }

        private void btnZapamtiSportistu_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiSportistu(txtIme, txtPrezime, txtDatum, txtEmail, cmbMesto, cmbKlub)) this.Close();
        }
    }
}
