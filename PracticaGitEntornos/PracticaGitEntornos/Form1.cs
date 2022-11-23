using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGitEntornos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numpalabras = 0;
            double coste;

            // Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // Telegrama urgente
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            if (cbOrdinario.Checked)
                tipoTelegrama = 'o';
            // Obtengo el numero de palabras  que forma el telegrama
            numpalabras = textoTelegrama.Length;
            // Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
                if (numpalabras <= 10)
                    coste = 2.5;
                else
                    coste = 0.5 * numpalabras;
            else
                // Si el telegrama es urgente
                if (tipoTelegrama == 'u')
                if (numpalabras <= 10)
                    coste = 5;
                else

                    coste = 5 + 0.75 * (numpalabras - 10);
            else
                coste = 0;
            textPrecio.Text = coste.ToString() + " euros";
        }
    }
}
