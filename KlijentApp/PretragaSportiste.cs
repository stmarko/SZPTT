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
    public partial class PretragaSportiste : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PretragaSportiste()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PretragaSportiste_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void PretragaSportiste_Load(object sender, EventArgs e)
        {
            kki.pretraziSportiste(txtFilter, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text=="")
            {
                kki.pretraziSportiste(txtFilter, dataGridView1);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.ucitajSportistu(dataGridView1)) new DetaljiSportiste().ShowDialog();
            textBox1_TextChanged(sender, e);
            txtFilter.Clear();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            kki.pretraziSportiste(txtFilter, dataGridView1);
        }

        private void txtFilter_CursorChanged(object sender, EventArgs e)
        {
            
        }
    }
}
