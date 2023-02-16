using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlquilerV
{
    public partial class Principal : Form
    {
        //Ocultamiento: se declara la Variable Placa como privada para que no se pueda consultar fuera de esta Clase.
        //Encapsulamiento: con el atributo Placa el cual se accede a el desdel metodos dentro de la misma Clase.
        //polimorfismo: la clase Auto hereda de la clase abstracta Vehiculo y sobrescribe el método Precio, lo que permite que se utilice la instancia de la clase Auto como un objeto de la clase Vehiculo.
        //Heriencia: Las Clases Auto, Camion, Furgoneta y Microbus, heredan de la Clase Vehiculo sus atributos.
        //Abstracción: se definen clases abstractas Vehiculo y se extienden a través de las clases derivadas como Auto, Microbus, Furgoneta y Camion.
        //Modularidad: Se realiza el calculo dentro de cada Clase y es impreso en el metodo de cada boton el cual utiliza la respectiva Clase
        //Manejo de errores: se realizan dostipos de manejo de errores en los TexBox matricula se utiliza un Try/Catch y en el TexBox Dia se maneja errorProvider en el codigo se encuentra desde la linea 42 hasta la 80
        private string Placa;
        public Principal()
        {
            InitializeComponent();
        }

        
        private void Principal_Load(object sender, EventArgs e)
        {
            btncoche.Enabled = false;
            btnmicrobuses.Enabled = false;
            btnfurgonetas.Enabled = false;
            btncamiones.Enabled = false;
            Resultado.Visible = false;
            matricula1.Visible = false;
        }

        
        private void controlbotones()
        {
            try
            {
                string placa = matricula.Text;
                if (string.IsNullOrWhiteSpace(placa))
                {
                    throw new Exception("La placa está vacía o solo contiene espacios en blanco.");
                }
                placa = placa.ToUpper(); 
                if (placa.Length > 6)
                {
                    throw new Exception("La placa debe tener un máximo de 6 caracteres.");
                }
                matricula.Text = placa; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int dia;
            if (Int32.TryParse(Dias.Text.Trim(), out dia) && Dias.Text.Trim() != string.Empty)
            {
                btncoche.Enabled = true;
                btnmicrobuses.Enabled = true;
                btnfurgonetas.Enabled = true;
                btncamiones.Enabled = true;
                Resultado.Visible = false;
                matricula1.Visible = false;
                errorProvider1.SetError(Dias, "");
            }
            else
            {
                if(!(Dias.Text.All(char.IsDigit)))
                {
                    errorProvider1.SetError(Dias, "Solo se aceptan valores numerico y sin espacios.");
                }
                else
                {
                    errorProvider1.SetError(Dias, "Favor ingresar los Dias a Cotizar.");
                }
                btncoche.Enabled = false;
                btnmicrobuses.Enabled = false;
                btnfurgonetas.Enabled = false;
                btncamiones.Enabled = false;
                Resultado.Visible = false;
                               
            }

            

        }


        private void Dias_TextChanged(object sender, EventArgs e)
        {
            controlbotones();
        }

        public void btncoche_Click(object sender, EventArgs e)
        {
            Placa = (matricula.Text);
            Auto _Auto = new Auto();
            decimal precio = _Auto.Precio(int.Parse(Dias.Text));
            Resultado.Text = ("El valor a pagar por el alquiler de Coche es: " + precio.ToString("N2") + " COP.");
            Resultado.Visible = true;
            matricula1.Text = "Matricula: " + Placa;
            matricula1.Visible = true;
        }

        private void btnmicrobuses_Click(object sender, EventArgs e)
        {
            Placa = (matricula.Text);
            Microbus _Microbus = new Microbus();
            decimal precio = _Microbus.Precio(int.Parse(Dias.Text));
            Resultado.Text = ("El valor a pagar por el alquiler de MicroBus es: " + precio.ToString("N2") + " COP.");
            Resultado.Visible = true;
            matricula1.Text = "Matricula: " + Placa;
            matricula1.Visible = true;
        }

        private void btnfurgonetas_Click(object sender, EventArgs e)
        {
            Placa = (matricula.Text);
            Furgoneta _Furgoneta = new Furgoneta();
            decimal precio = _Furgoneta.Precio(int.Parse(Dias.Text));
            Resultado.Text = ("El valor a pagar por el alquiler de Furgoneta es: " + precio.ToString("N2") + " COP.");
            Resultado.Visible = true;
            matricula1.Text = "Matricula: " + Placa;
            matricula1.Visible = true;

        }

    

        private void btncamiones_Click(object sender, EventArgs e)
        {
            Placa = (matricula.Text);
            Camion _Camion = new Camion();
            decimal precio = _Camion.Precio(int.Parse(Dias.Text));
            Resultado.Text = ("El valor a pagar por el alquiler de Camion es: " + precio.ToString("N2") + " COP.");
            Resultado.Visible = true;
            matricula1.Text = "Matricula: " + Placa;
            matricula1.Visible = true;
        }


        private void btnvolver_Click(object sender, EventArgs e)
        {             
            Application.Restart();
        }

        private void matricula_TextChanged(object sender, EventArgs e)
        {
            controlbotones();
        }
    }
}
