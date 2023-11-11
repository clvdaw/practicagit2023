using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;
           
            textoTelegrama = txtTelegrama.Text;
            String[] palabras = textoTelegrama.Split(' ');
            numPalabras = palabras.Length;
            if (rbUrgente.Checked)
                tipoTelegrama = 'u';
           
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + (0.75 * (numPalabras - 10));
            else
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                coste = 2.5 + (0.5 * (numPalabras - 10));

            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void rbOrdinario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
