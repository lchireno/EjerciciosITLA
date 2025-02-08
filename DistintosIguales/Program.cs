namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que lea tres números y determine si los tres números son ituales (conforme al flujograma facilitado)
            // declaramos variables
            
            int a, b, c;

            Console.WriteLine("LEER TRES NUMEROS Y DETERMINAR SI SON IGUALES");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese un valor para A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un valor para B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un valor para C: ");
            c = int.Parse(Console.ReadLine());

            // imprimimos resultado
            
            Console.WriteLine("");
            if (a == b)
            {
                if (b == c)
                {
                    Console.WriteLine("IGUALES");
                }

                else
                {
                    Console.WriteLine("DISTINTOS");
                }
            }

            else
            {
                Console.WriteLine("DISTINTOS");
            }

            Console.ReadLine();
        }
    }
}