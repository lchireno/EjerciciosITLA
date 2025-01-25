using System.Linq.Expressions;

namespace EjerciciosITLA
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2; 
            string opcion="";
            string resultado="";

            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");

            Console.Write("Número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Número 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado:");

            Console.WriteLine("");
            Console.WriteLine("Opciones");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Sumar        2. Restar");
            Console.WriteLine("3. Multiplicar  4. Dividir");
            Console.WriteLine("5. Potencia     6. Salir");
            Console.WriteLine("");
            Console.Write("Elija una opcion:");
            opcion =Console.ReadLine();

            while (opcion != "6")
            {
                switch (opcion)
                {
                    case "6":
                        Environment.Exit(0);
                        break;
                    case "5":
                        resultado = (Math.Pow(num1, num2)).ToString("#,##0.###");
                        break;
                    case "4":
                        resultado = ((float)num1 / num2).ToString("#,##0.###");
                        break;
                    case "3":
                        resultado = (num1 * num2).ToString("#,##0.###");
                        break;
                    case "2":
                        resultado = (num1 - num2).ToString("#,##0.###");
                        break;
                    case "1":
                        resultado = (num1 + num2).ToString("#,##0.###");
                        break;
                }
                opcion = opciones(num1, num2, resultado).ToString();
            }


            static string opciones( int num1, int num2, string resultado = "")
            {
                Console.Clear();
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("Leonardi Alonzo Chireno");
                Console.WriteLine("");
                Console.WriteLine("Número 1: " + num1);
                Console.WriteLine("Número 2: " + num2);
                Console.WriteLine("Resultado:" + resultado);


                Console.WriteLine("");
                Console.WriteLine("Opciones");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Sumar        2. Restar");
                Console.WriteLine("3. Multiplicar  4. Dividir");
                Console.WriteLine("5. Potencia     6. Salir");
                Console.WriteLine("");
                Console.Write("Elija una opcion:");
                string opcion = Console.ReadLine();
            
                return opcion;
            }
        }
    }
}











        //    private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnResta_Click(object sender, EventArgs e)
        //{
        //    // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
        //    txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = (num1 - num2).ToString() : "";
        //}

        //private void btnMultiplicacion_Click(object sender, EventArgs e)
        //{
        //    // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
        //    txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = (num1 * num2).ToString() : "";
        //}

        //private void btnDivision_Click(object sender, EventArgs e)
        //{
        //    // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
        //    txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = ((float)num1 / num2).ToString() : "";
        //}

        //private void btnPotencia_Click(object sender, EventArgs e)
        //{
        //    // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
        //    txtResultado.Text = VerificarEntrada() == true ? txtResultado.Text = Math.Pow(num1, num2).ToString() : "";
        //}

        //private void btnSuma_Click(object sender, EventArgs e)
        //{
        //    // si VerificarEntrada() retorna verdadero, entonces realiza la operacion, sino vacio
        //    txtResultado.Text = VerificarEntrada() == true ? (num1 + num2).ToString() : "";
