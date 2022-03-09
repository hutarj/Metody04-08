using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMocnina_Click(object sender, EventArgs e)
        {
            int zaklad = int.Parse(mocninaZaklad.Text);
            int exponent = int.Parse(mocninaExponent.Text);
            double mocnina = CelaCisla.Mocnina(zaklad, exponent);
            MessageBox.Show("Mocnina je " + mocnina);
        }

        private void buttonFaktorial_Click(object sender, EventArgs e)
        {
            int parametr = int.Parse(faktorialParametr.Text);
            long faktorial = CelaCisla.Faktorial(parametr);

            MessageBox.Show("Faktorial je " + faktorial);
        }

        private void buttonSoucetLich_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBoxLich.Text);
            int cifSoucet = CelaCisla.CifLichSoucet(cislo);

            MessageBox.Show("Ciferný součet lichých cifer je " + cifSoucet);
        }

        private void buttonPrvocislo_Click(object sender, EventArgs e)
        {
            int cislo = int.Parse(textBoxPrvocislo.Text);
            bool jePrvocislo = CelaCisla.JePrvocislo(cislo);
            if (jePrvocislo) MessageBox.Show("Číslo " + cislo + " je prvočíslo");
            else MessageBox.Show("Číslo " + cislo + " není prvočíslo");
        }

        private void buttonSudPocet_Click(object sender, EventArgs e)
        {

        }
    }
}
