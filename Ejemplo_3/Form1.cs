using System;
using System.Windows.Forms;

namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //tratará de realizar la acción solicitada
            try
            {
                float numera = float.Parse(txbDividendo.Text);
                float denomina = float.Parse(txbDivisor.Text);
                float resultado = numera / denomina;
                txbResultado.Text = Convert.ToString(resultado);
            }
            //si no pudiera hacerlo entonces verificará cual es el error y nos los mostrará
            catch (Exception error)
            {
                MessageBox.Show("El problema es: " + error.Message);
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txbDividendo.Clear();
            txbDivisor.Clear();
            txbResultado.Focus();
        }
    }
}
