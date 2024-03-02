using Ejemplo_4.Models;
using System;
using System.Windows.Forms;

namespace Ejemplo_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, System.EventArgs e)
        {
            Empleado miEmpleado = new Empleado();
            try
            {
                miEmpleado.Carnet = int.Parse(txbCarnet.Text);
                miEmpleado.Nombre = txbNombre.Text;
                miEmpleado.Edad = int.Parse(txbEdad.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txbCarnet.Text = "";
                txbNombre.Text = "";
                txbEdad.Text = "";
                txbCarnet.Focus();
                return;
            }
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
