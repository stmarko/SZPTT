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
    public partial class KreirajKlub : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public KreirajKlub()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (kki.zapamtiKlub(txtNazivKluba, txtSkraceniNaziv, txtBrojTerena, cmbMesto, txtAdresa, txtBrojTelefona)) this.Close();
        }

        private void btnKreirajKlub_Click(object sender, EventArgs e)
        {
            kki.kreirajKlub(txtIDKlub, cmbMesto, groupBox1, btnKreirajKlub);
        }

        private void KreirajKlub_Load(object sender, EventArgs e)
        {

        }
    }
}
