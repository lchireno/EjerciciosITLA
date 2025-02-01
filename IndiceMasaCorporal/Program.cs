namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que calcule el índice de masa corporal (IMC) Fórmula: IMC = peso / (altura * altura).

            // declaramos variables
            decimal peso, altura, imc;

            Console.WriteLine("CALCULAR INDICE DE MASA CORPORAL (IMC)");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Peso (kg): ");
            peso = decimal.Parse(Console.ReadLine());
            Console.Write("Altura (m): ");
            altura = decimal.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            // imprimimos resultado
            Console.WriteLine("");
            Console.WriteLine("Indice de Masa Corporal (IMC): " + imc);

            Console.ReadLine();
        }
    }
}