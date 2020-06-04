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
    public partial class PocetnaForma : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {
                
                this.Text = KontrolerKI.poveziSeNaServer();

            try
            {
                if (this.Text == "Klijent nije povezan na server!")
                {
                    MessageBox.Show("Nisi konektovan na server!");
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.kraj();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnKreirajSportistu.BackColor = Color.FromArgb(184, 119, 197);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new KreirajTurnir().ShowDialog();
        }

        private void btnKreirajSportistu_MouseLeave(object sender, EventArgs e)
        {
            btnKreirajSportistu.BackColor = Color.FromArgb(41,44,52);
        }

        private void btnPretragaSportiste_MouseHover(object sender, EventArgs e)
        {
            btnPretragaSportiste.BackColor = Color.FromArgb(184, 119, 197);

        }

        private void btnPretragaSportiste_MouseLeave(object sender, EventArgs e)
        {
            btnPretragaSportiste.BackColor = Color.FromArgb(41, 44, 52);
        }

        private void btnKreirajKlub_MouseHover(object sender, EventArgs e)
        {
            btnKreirajKlub.BackColor = Color.FromArgb(122, 255, 117);

        }

        private void btnKreirajKlub_MouseLeave(object sender, EventArgs e)
        {
            btnKreirajKlub.BackColor = Color.FromArgb(41, 44, 52);

        }

        private void btnPretraziKlub_MouseHover(object sender, EventArgs e)
        {
            //btnPretraziKlub.BackColor = Color.FromArgb(122, 255, 117);
        }

        private void btnPretraziKlub_MouseLeave(object sender, EventArgs e)
        {
           // btnPretraziKlub.BackColor = Color.FromArgb(41, 44, 52);
        }

        private void btnKreirajTurnir_MouseHover(object sender, EventArgs e)
        {
            btnKreirajTurnir.BackColor = Color.FromArgb(255, 82, 82);
        }

        private void btnKreirajTurnir_MouseLeave(object sender, EventArgs e)
        {
            btnKreirajTurnir.BackColor = Color.FromArgb(49, 51, 60);
        }

        private void btnPretraziTurnir_MouseHover(object sender, EventArgs e)
        {
            btnPretraziTurnir.BackColor = Color.FromArgb(255, 82, 82);
        }

        private void btnPretraziTurnir_MouseLeave(object sender, EventArgs e)
        {
            btnPretraziTurnir.BackColor = Color.FromArgb(49, 51, 60);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKreirajKlub_Click(object sender, EventArgs e)
        {
            new KreirajKlub().ShowDialog();
        }

        private void btnKreirajSportistu_Click(object sender, EventArgs e)
        {
            new KreirajSportistu().ShowDialog();
        }

        private void btnPretragaSportiste_Click(object sender, EventArgs e)
        {
            new PretragaSportiste().ShowDialog();
        }

        private void btnPretraziTurnir_Click(object sender, EventArgs e)
        {
            new PretragaTurnira().ShowDialog();
        }
    }
}
