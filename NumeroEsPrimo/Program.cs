namespace EjerciciosITLA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que diga si el número digitado es primo o no

            int num1, countPrimo = 0; // declaramos las variables a utilizar

            Console.WriteLine("DETERMINAR SI EL NUMERO ES PRIMO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine();

            // Lee el numero
            Console.Write("Escriba el número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            // bucle for para calcular el modulo del numero entre cada numero desde el mismo hasta 1
            // incrementando la variable countPrimo cada vez que el modulo sea 0
            for (int i = num1; i >= 1; i--)
            {
                if (num1 % i == 0)
                {
                    countPrimo++;
                }
            }

            // si el contador (counPrimo) es igual a 2, escribe que es primo
            if (countPrimo == 2 || num1 == 1)
            {
                Console.WriteLine("Es un número Primo");
            }
            
            // sino es igual 2 escribe que no lo es.
            else
            {
                Console.WriteLine("NO es un número primo");
            }

            Console.ReadKey();
        }
    }
}