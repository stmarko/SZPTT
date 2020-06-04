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
    public partial class KreirajSportistu : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public KreirajSportistu()
        {
            InitializeComponent();
        }

      

        private void btnKreirajKlub_Click(object sender, EventArgs e)
        {
            kki.kreirajSportistu(txtIDSportista, cmbMesto,cmbKlub, groupBox1, btnKreirajSportistu);
        }

        private void btnZapamtiSportistu_Click(object sender, EventArgs e)
        {
            if (kki.zapamtiSportistu(txtIme,txtPrezime,txtDatum,txtEmail,cmbMesto,cmbKlub)) this.Close();
        }

        private void KreirajSportistu_Load(object sender, EventArgs e)
        {

        }
    }
}
