namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que convierta grados Celsius a Fahrenheit Fórmula: F = (C * 9/5) + 32.

            // declaramos variables
            decimal f, c;

            Console.WriteLine("CELSIUS A FAHRENHEIT");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Celsius (°C): ");
            c = decimal.Parse(Console.ReadLine());

            f = (c * 9 / 5) + 32;

            // imprimimos resultado
            Console.WriteLine("");
            Console.WriteLine("Fahrenheit (°F): " + f);

            Console.ReadLine();
        }
    }
}