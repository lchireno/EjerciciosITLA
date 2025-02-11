using System.Threading;

namespace EjerciciosITLA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea 2: Escribe un programa que determine si un número es divisible por 3 y por 5 al mismo tiempo.
            //Ejemplo de salida:
            //Ingresa un número: 15
            //15 es divisible por 3 y por 5.

            int num1;

            Console.WriteLine("DETERMINAR SI NÚMERO ES DIVISBLE ENTRE 3 Y 5");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingresa un número: ");
            num1 = int.Parse(Console.ReadLine());

            if ((num1 % 3 == 0) && (num1 % 5 ==0))
            {
                Console.WriteLine(num1 + " es divisible por 3 y por 5");
            }
            else 
            {
                Console.WriteLine(num1 + " NO es divisible por 3 y por 5");
            }

            Console.WriteLine("");
            Console.Write("Presionene Enter para salir");
            Console.ReadLine();
        }
    }
}