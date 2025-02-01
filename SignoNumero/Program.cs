namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que determine si un numero por teclado es positivo, negativo o cero

            // declaramos variables
            int num1;

            Console.WriteLine("DETERMINAR SI UN NUMERO ES POSITIVO, NEGATIVO O CERO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese el Número: ");
            num1 = int.Parse(Console.ReadLine());

            // imprimimos resultado
            Console.WriteLine("");
            if (num1 == 0)
            {
                Console.WriteLine("el número es Cero");
            }
            
            else if (num1 > 0)
            {
                Console.WriteLine("el número es Positivo");
            }
              
            else
            {
                Console.WriteLine("el número es Negativo");
            }

            Console.ReadLine();
        }
    }
}