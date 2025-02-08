using System;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace EjerciciosITLA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa en C# que ayude al usuario a determinar si su dinero es suficiente para pagar un helado.
            //El programa debe:
            //      -Pedir al usuario que ingrese la cantidad de dinero que tiene.
            //      -Mostrar un menú de opciones con diferentes tipos de helado y sus precios.
            //      -Permitir que el usuario seleccione un tipo de helado.
            //      -Determinar si el dinero es suficiente para comprar el helado seleccionado.
            //      -Mostrar un mensaje indicando si la compra es posible o si falta dinero.

            int presupuesto, precio=0, opcion = 0;

            Console.WriteLine("DETERMINAR SI TIENE DINERO SUFICIENTE PARA UN HELADO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");

            Console.Write("Ingrese su presupuesto: ");
            presupuesto = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("OPCIONES DE DE HELADO");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("1- Helado 10 oz  $ 150       2- Helado 12 oz  $ 200");
            Console.WriteLine("3- Helado 16 oz  $ 250       4- Helado 20 oz  $ 300");
            Console.WriteLine("");
            Console.Write("Elija una Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    precio = 150;
                    break;
                case 2:
                    precio = 200;
                    break;
                case 3:
                    precio = 250;
                    break;
                case 4:
                    precio = 300;
                    break;
                default:
                    opcion = 0;
                    Console.WriteLine("Elija una Opcion Válida");
                    break;
            }

            if (precio > presupuesto && opcion !=0)
            {
                Console.WriteLine("NO PUEDE COMPAR EL HELADO");
            }
            else if (opcion !=0)
            {
                Console.WriteLine("PUEDE COMPAR EL HELADO");
            }

            Console.ReadLine();
        }
    }
}