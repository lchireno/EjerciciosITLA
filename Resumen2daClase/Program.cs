using System;

namespace EjerciciosITLA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaramos variables
            int num1, num2;

            // leemos los valores para las variables
            Console.WriteLine("RESUMEN DE LA SEGUNDA CLASE");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese el Número 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Número 2:");
            num2 = int.Parse(Console.ReadLine());

            // operadores aritmeticos
            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            int division = num1 / num2;
            int residuo = num1 % num2;
            double division2 = (double)num1 / num2;

            // imprimir resultados operadores aritmeticos
            Console.WriteLine("");
            Console.WriteLine("OPERADORES ARITMETICOS");
            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicación: "+ multiplicacion);
            Console.WriteLine("División (entero): "+ division);
            Console.WriteLine("Residuo: "+ residuo);   
            Console.WriteLine("División (decimal): " + division2 );

            // operadores de comparacion
            bool mayor = num1 > num2;
            bool menor = num1 < num2;
            bool igual = num1 == num2;
            bool diferente = num1 != num2;
            bool mayorIgual = num1 >= num2;
            bool menorIgual = num1 <= num2;

            // imprimir resultados operadores de comparacion 
            Console.WriteLine("");
            Console.WriteLine("OPERADORES DE COMPARACION");
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Igual: " + igual);
            Console.WriteLine("Diferente: " + diferente);
            Console.WriteLine("Mayor o Igual: " + mayorIgual);
            Console.WriteLine("Menor o Igual: " + menorIgual);

            // operadores logicos
            bool and = mayor && menor;
            bool or = mayor || menor;
            bool not = !mayor;

            // imprimir resultados operadores logicos 
            Console.WriteLine("");
            Console.WriteLine("OPERADORES LOGICOS");
            Console.WriteLine("Mayor And Menor: " + and);
            Console.WriteLine("Mayor Or Menor: " + or);
            Console.WriteLine("Mayor Not: " + not);

            // operadores de asignacion
            Console.WriteLine("");
            Console.WriteLine("OPERADORES DE ASIGNACION");
            Console.WriteLine("Imcrementar (++): " + (++num1));
            Console.WriteLine("Disminuir (--): " + (--num1));
            Console.WriteLine("Asignación Más 10 (+=): " + (num1 += 10));
            Console.WriteLine("Asignación Menos 10 (-=): " + (num1 -= 10));
            Console.WriteLine("Asignación Multiplicación 10 (*=): " + (num1 *= 10));
            Console.WriteLine("Asignación División 10 (/=): " + (num1 /= 10));
            Console.WriteLine("Asignación Residuo 10 (%=): " + (num1 %= 10));

            Console.ReadLine();
        }
    }
}