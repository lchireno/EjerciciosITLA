using System;
using System.Security.Cryptography;

namespace EjerciciosITLA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Escribe un programa que determine si un número es positivo, negativo o cero. 

            int num1;

            Console.WriteLine("DETERMINAR SI UN NUMERO ES POSITIVO, NEGATIVO O CERO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese el numero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 == 0)
            {
                Console.WriteLine("El número es CERO");
            }
            else if (num1 < 0)
            {
                Console.WriteLine("El número es NEGATIVO");
            }
            else
            {
                Console.WriteLine("El número es positivo");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            Console.Clear();

            //Ejercicio 2: Escribe un programa que verifique si un número es par o impar. 

            //int num1;

            Console.WriteLine("VERIFIQUE SI UN NUMERO ES PAR O IMPAR");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese el numero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 == 0 || num1 % 2 == 0)
            {
                Console.WriteLine("El número es PAR");
            }
            else
            {
                Console.WriteLine("El número es IMPAR");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();
            Console.Clear();


            //Ejercicio 3: Escribe un programa que determine si un año es bisiesto. 
            //Reglas:     Es bisiesto si es divisible por 4 y no es divisible por 100, o si es divisible por 400.
            //Formula:    (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)

            int year;

            Console.WriteLine("VERIFIQUE SI AÑO ES BISIESTO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese el año: ");
            year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("El año es BISIESTO");
            }
            else
            {
                Console.WriteLine("El año NO es BISIESTO");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadLine();


            // hacer un menu de tres opciones
            // Practica programa de saludos, elegir tres opciones  Salida esperada (según opción ingresada):

            //            "¡Hola, bienvenido!" si eliges 1.
            //"¡Adiós, hasta luego!" si eliges 2.
            //"Saliendo del programa..." si eliges 3.
            //"Opción no válida" si ingresas otro número.

            int opcion;

            Console.WriteLine("PROGRAMA DE SALUDOS");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese una Opcion del 1 al 3: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola, bienvenido!");
                    break;
                case 2:
                    Console.WriteLine("¡Adiós, hasta luego!");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}