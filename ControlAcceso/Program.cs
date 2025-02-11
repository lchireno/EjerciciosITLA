using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;
using System;

namespace EjerciciosITLA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea 3(opcional): Escribe un programa que simule un sistema de autenticación.

            //Solicita al usuario un nombre de usuario y una contraseña. 

            //Si el nombre de usuario es "admin" y la contraseña es "1234", muestra "Acceso concedido".

            //De lo contrario, muestra "Acceso denegado".


            string usuario, password;

            Console.WriteLine("PROGRAMA QUE SIMULE UN SISTEMA DE AUTENTICACIÓN");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingresa su Usuario: ");
            usuario = Console.ReadLine();
            Console.Write("Ingresa su Contraseña: ");
            password =Console.ReadLine();

            if ((usuario == "admin") && (password == "1234"))
            {
                Console.WriteLine("Acceso concedido");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }

            Console.WriteLine("");
            Console.Write("Presionene Enter para salir");
            Console.ReadLine();
        }
    }
}