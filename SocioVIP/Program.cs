namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //programa que determine si un soscio es VIP

            // declaramos variables
            string cat;
            int ant;

            Console.WriteLine("DETERMINAR SI SOCIO ES VIP");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese la Categoría: ");
            cat = Console.ReadLine();
            Console.Write("Ingrese la Antigüedad: ");
            ant = int.Parse(Console.ReadLine());

            // imprimimos resultado
            Console.WriteLine("");

            if (cat == "a" || (ant >= 10 && ant <= 20))
            {
                Console.WriteLine("SOCIO VIP");
            }

            Console.ReadLine();
        }
    }
}