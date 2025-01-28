using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicador
{
    public partial class frmMultiplicador : Form
    {

        public frmMultiplicador()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Multiplicar();
        }

        public string Multiplicar() // el metodo de tipo strin, que devolera el producto de la multiplicacion con formato de miles y hasta 3 decimales.
        {
            // declaracion de variables 
            int num1, num2, resultado = 0;

            // evalua txtNum1, si no está vacio o si no es un nuero, si es un numero lo asigna a la variable num1
            if (txtNum1.Text == "" || !int.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Introduzca un valor válido.", "Atención"); // muestra un mensaje,
                txtNum1.Select(); // selecciona el cuadro de texto 

                return ""; //y retorna falso
            }

            if (txtNum2.Text == "" || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Introduzca un valor válido.", "Atención");
                txtNum2.Select();

                return "";
            }
 
            // multiplicacion sin usar el operador *, sumando num2 n veces, donde n es igual a num1
            for (int i = 1; i <= num1; i++)
            {
                resultado += num2;
            }
            return resultado.ToString("#,##0.###");
        }

    }
}
