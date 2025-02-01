namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa que concatene tu nombre y tu edad en una sola cadena.

            // declaramos variables
            string nombre, edad;

            Console.WriteLine("CONCATENER EL NOMBRE Y LA EDAD");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingresa tu nombre:");
            nombre = Console.ReadLine().ToUpper();
            Console.Write("Ingresa tu edad:");
            edad = Console.ReadLine();

            // imprimimos resultado
            Console.WriteLine("");
            Console.WriteLine("Tu nombre es " + nombre + " y tu edad es " + edad);

            Console.ReadLine();
        }
    }
}