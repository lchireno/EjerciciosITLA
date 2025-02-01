namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea 1: Se determina el estado del agua basado en la temperatura ingresada por el usuario.
            //Si la temperatura es menor o igual a 0, el agua está en estado sólido(hielo).
            //Si la temperatura está entre 0 y 100, el agua está en estado líquido.
            //Si la temperatura es 100 o más, el agua está en estado gaseoso(vapor).

            // declaramos variables
            int temperatura;

            Console.WriteLine("DETERMINAR ESTADO DEL AGUA");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Temperatura: ");
            temperatura = int.Parse(Console.ReadLine());

            // imprimimos resultado
            Console.WriteLine("");
            if (temperatura == 0)
            {
                Console.WriteLine("el agua está en estado sólido(hielo)");
            }

            else if (temperatura < 100)
            {
                Console.WriteLine("el agua está en estado líquido");
            }

            else
            {
                Console.WriteLine("el agua está en estado gaseoso(vapor)");
            }

            Console.ReadLine();
        }
    }
}