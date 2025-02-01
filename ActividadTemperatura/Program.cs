namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea 2: Se recomienda una actividad basada en la temperatura.
            //Si la temperatura es menor a 10, se recomienda quedarse en casa.
            //Si la temperatura está entre 10 y 20, se recomienda salir a caminar con una chaqueta.
            //Si la temperatura es 20 o más, se recomienda hacer actividades al aire libre.

            // declaramos variables
            int temperatura;

            Console.WriteLine("ACTIVIDAD SEGUN LA TEMPERATURA");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Temperatura: ");
            temperatura = int.Parse(Console.ReadLine());

            // imprimimos resultado
            Console.WriteLine("");
            if (temperatura < 10)
            {
                Console.WriteLine("se recomienda quedarse en casa");
            }

            else if (temperatura >= 10 && temperatura <20)
            {
                Console.WriteLine("se recomienda salir a caminar con una chaqueta");
            }

            else
            {
                Console.WriteLine("se recomienda hacer actividades al aire libre");
            }

            Console.ReadLine();
        }
    }
}