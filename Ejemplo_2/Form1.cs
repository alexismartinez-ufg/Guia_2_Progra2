using System;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;
            if (txbNombre.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; //si está vacío validado es falso
                errorProvider1.SetError(txbNombre, "Ingresar nombre"); //por lo tanto manda a llamar a errorprovider
            //en los parámetros de setError se identifica a quién estoy validando y el mensaje que deseo mandar
            }
            //verifico la casilla de apellido
            if (txbApellido.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(txbApellido, "Ingrese apellido");
            }

            if(txbFecha.Value > DateTime.Now)
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(txbFecha, "Fecha invalida");
            }
            return validado;
        }

        private void BorrarMesaje()
        {
            //borra los mensajes para que no se muestren y pueda limpiar
            errorProvider1.SetError(txbNombre, "");
            errorProvider1.SetError(txbApellido, "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //limpia cualquier mensaje de error de alguna corrida previa
            BorrarMesaje();
            //llamamos al método para validar campos, el de nombre y apellido
            if (validarCampos())
            {
                MessageBox.Show("Los datos se ingresaron correctamente");
            }
            else
            {
                MessageBox.Show("Los datos no se ingresaron correctamente");
                return;
            }

            //verificamos la fecha de nacimiento que nos den
            //DateTimePicker se llama dtpFechaNacimiento
            DateTime fechaNacimiento = txbFecha.Value;
            //verificamos la fecha del sistema (solo calculamos con los años
            int anios = DateTime.Now.Year - fechaNacimiento.Year;
            /*verificamos aparte del año si ya pasamos la fecha de nacimiento de este año o nos
           faltan días*/
            if (DateTime.Now.Subtract(fechaNacimiento.AddYears(anios)).TotalDays < 0)
                //si nos faltan días para cumplir años al cálculo le resta uno
                txbEdad.Text = Convert.ToString(anios - 1);
            else
                //si ya pasó nuestra fecha de nacimiento manda el valor correspondiente
                txbEdad.Text = Convert.ToString(anios);

        }
    }
}
