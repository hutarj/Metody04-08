﻿using System;
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

        }

        private void buttonSoucetLich_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrvocislo_Click(object sender, EventArgs e)
        {

        }

        private void buttonSudPocet_Click(object sender, EventArgs e)
        {

        }
    }
}