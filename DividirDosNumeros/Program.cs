namespace Modulo1ITLA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que divida dos números

            int num1 = 29, num2 = 3; // declaramos variables y asignamos valores
            float num3;

            Console.WriteLine("DIVIDIR DOS NUMERO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine();

            // Escribe los numeros
            Console.WriteLine("Dividendo: " + num1);
            Console.WriteLine("Divisor: " + num2);

            // Calcula y escribe el resultado
            num3 = (float) num1 / num2;
            Console.WriteLine("Cociente: " + num3);

            Console.ReadKey();
        }
    }
}