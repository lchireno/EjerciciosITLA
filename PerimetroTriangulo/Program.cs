namespace EjerciciosITLA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa que calcule el perímetro de un triángulo (suma de sus lados)


            // declaramos variables
            int a, b, c, perimetro;

            Console.WriteLine("CALCULAR EL PERIMETRO DE UN TRIANGULO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Lado A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Lado B : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Lado C : ");
            c = int.Parse(Console.ReadLine());

            // clacula el area
            perimetro = a + b + c;

            // imprime el resultado
            Console.WriteLine("El perimetro del triangulo es: " + perimetro);

            Console.ReadLine();
        }
    }
}