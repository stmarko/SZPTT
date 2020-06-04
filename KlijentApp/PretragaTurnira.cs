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
    public partial class PretragaTurnira : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PretragaTurnira()
        {
            InitializeComponent();
        }

        private void PretragaTurnira_Load(object sender, EventArgs e)
        {
            kki.pretraziTurnire(txtFilter, dataGridView1);

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
            {
                kki.pretraziTurnire(txtFilter, dataGridView1);
            }
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            kki.pretraziTurnire(txtFilter, dataGridView1);
        }

       

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (kki.ucitajTurnir(dataGridView1)) new DetaljiTurnira().ShowDialog();
            txtFilter_TextChanged(sender, e);
        }
    }
}
