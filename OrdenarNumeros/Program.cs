namespace EjerciciosITLA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que permita digitar 10 numeros desordenados y luego ordenarlos. Usando arreglos.

            int[] listaNumeros = new int[10];// declaramos la variable como una rreglo de 10 enteros.

            Console.WriteLine("LEER DIEZ NUMEROS Y ORDENARLOS");
            Console.WriteLine("leonardi Alonzo Chireno");
            Console.WriteLine("");

            Console.WriteLine("Escriba los diez números:");

            // leer los 10 numeros y asginarlos a las diez posiciones el arreglo
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1).ToString("00°:"));
                listaNumeros[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(listaNumeros); // ordena el arreglo


            // Escribir los 10 numeros del arreglo ordenados
            Console.WriteLine();
            Console.WriteLine("NUMEROS ORDENADOS");

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1).ToString("00°:"));
                Console.WriteLine(listaNumeros[i]) ;
            }

            Console.ReadKey();
        }
    }
}