namespace EjerciciosITLA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que pregunte al usuario su nombre y le responda cuál es su inicial.

            string nombre;

            Console.WriteLine("LEER NOMBRE Y RESPONDER CUAL ES SU INICIAL");
            Console.WriteLine("leonardi Alonzo Chireno");
            Console.WriteLine("");

            Console.Write("Escriba su Nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("La inicial es: (" + nombre[0] + ")");
            
            Console.ReadKey();
        }
    }
}