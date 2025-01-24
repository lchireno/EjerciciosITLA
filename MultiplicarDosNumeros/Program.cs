namespace EjerciciosITLA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que permita digital 2 números y luego los multiplique

            int num1, num2; // declaracion de variables

            Console.WriteLine("LEER DOS NUMEROS Y MULTIPLICARLOS ");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine();

            // Lee el primer numero
            Console.Write("Escriba el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Lee el segundo numero
            Console.Write("Escriba el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Muestra el resultado
            Console.Write("El Producto es: " + num1 * num2);

            Console.ReadKey();
        }
    }
}

