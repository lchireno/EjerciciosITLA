namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que convierta una cantidad de dólares a euros Usa un tipo de cambio fijo (por ejemplo, 1 dólar = 0.85 euros).

            // declaramos variables
            double dolares, euros, tipoCambio = 0.85;

            Console.WriteLine("CONVERTIR DOLARES A EUROS");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese la cantidad en dólares: ");
            dolares = int.Parse(Console.ReadLine());
            
            euros = dolares * tipoCambio;

            // imprimimos resultado
            Console.WriteLine("");
            Console.Write("Euros: " + euros);
            Console.ReadLine();
        }
    }
}