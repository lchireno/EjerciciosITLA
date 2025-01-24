using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosITLA
{
    public partial class frmCalculadora : Form
    {
        int num1, num2;
        
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
            txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = (num1 - num2).ToString() : "";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
            txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = (num1 * num2).ToString() : "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
            txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = ((float)num1 / num2).ToString() : "";
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
            txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = Math.Pow(num1, num2).ToString() : "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
            txtResultado.Text = VerificarEntrada() == true? (num1+num2).ToString() : "";
        }

        
        // metodo o funcion para verificar que los campos que debe completar el usuario estan  completos y si son numeros
        public bool VerificarEntrada() // el metodo sera del tipo booleano para devolver verdadero si se cumple o falso si no
        {
            
            // evalua txtNum1, si no está vacio o si no es un nuero, si es un numero lo asigna a la variable num1
            if (txtNum1.Text == "" || !int.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Introduzca un valor válido.","Atención"); // muestra un mensaje,
                txtNum1.Select(); // selecciona el cuadro de texto 
                
                return false; //y retorna falso
            }

            if (txtNum2.Text == "" || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Introduzca un valor válido.", "Atención");
                txtNum2.Select();

                return false;
            }
            return true;
        }
    }
}
