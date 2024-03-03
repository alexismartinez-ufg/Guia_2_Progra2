using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnVerNotas.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateUserData())
            {
                MessageBox.Show("Asegurar que todos los datos sean correctos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnVerNotas.Enabled = true;
            btnGuardar.Enabled = false;
            txbCarnet.Enabled = false;
            txbCorreo.Enabled = false;
            txbFechaNacimiento.Enabled = false;
            txbNombre.Enabled = false;
            txbResponsables.Enabled = false;
        }

        private void btnVerNotas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Form2
            Form2 form2 = new Form2();

            // Mostrar el Form2
            form2.ShowDialog(); 
        }


        private bool ValidateUserData()
        {
            var itsOk = true;
            errorProvider1.Clear();

            var carnet = txbCarnet.Text;
            Regex regexCarnet = new Regex(@"^[A-Z]{2}\d{6}$");
            if (string.IsNullOrEmpty(carnet))
            {
                itsOk = false;
                errorProvider1.SetError(txbCarnet, "Ingresar carnet");
            }
            else if (!regexCarnet.IsMatch(carnet))
            {
                itsOk = false;
                errorProvider1.SetError(txbCarnet, "El carnet no posee el formato adecuado (AA999999)");
            }

            var nombre = txbNombre.Text;    
            if (string.IsNullOrEmpty(nombre))
            {
                itsOk = false;
                errorProvider1.SetError(txbNombre, "Ingresar nombres");
            }

            var fecha = txbFechaNacimiento.Value;    
            if (fecha == null || fecha == DateTime.MinValue || fecha > DateTime.Now)
            {
                itsOk = false;
                errorProvider1.SetError(txbFechaNacimiento, "Ingresar fecha valida");
            }

            var correo = txbCorreo.Text;
            Regex regexCorreo = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (string.IsNullOrEmpty(correo))
            {
                itsOk = false;
                errorProvider1.SetError(txbCorreo, "Ingresar correo válido");
            }
            else if (!regexCorreo.IsMatch(correo))
            {
                itsOk = false;
                errorProvider1.SetError(txbCorreo, "El correo no posee el formato adecuado");
            }

            var responsables = txbResponsables.Text;
            if (string.IsNullOrEmpty(responsables))
            {
                itsOk = false;
                errorProvider1.SetError(txbResponsables, "Ingresar responsables");
            }

            return itsOk;
        }
    }
}
