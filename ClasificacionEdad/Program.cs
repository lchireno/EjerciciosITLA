using System;
using System.Threading;

namespace EjerciciosITLA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea 1: Escribe un programa que clasifique a una persona en una de estas categorías según su edad:
            //Niñez(0 - 12 años).
            //Adolescencia(13 - 17 años).
            //Adultez(18 - 64 años).
            //Vejez(65 años o más).
            //
            //Ejemplo de salida:
            //Ingresa tu edad: 25
            //Estás en la etapa de adultez. 


            int edad;

            Console.WriteLine("CLASIFICACION POR EDAD");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingresa tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 0 && edad <= 12)
            {
                Console.WriteLine("Estás en la etapa de Niñez");
            }
            else if (edad >= 13 && edad <= 17)
            {
                Console.WriteLine("Estás en la etapa de Adolescencia");
            }
            else if (edad >= 18 && edad <= 64)
            {
                Console.WriteLine("Estás en la etapa de Adultez");
            }
            else if (edad >= 65)
            {
                Console.WriteLine("Estás en la etapa de Vejez");
            }

            Console.WriteLine("");
            Console.Write("Presionene Enter para salir");
            Console.ReadLine();
        }
    }
}