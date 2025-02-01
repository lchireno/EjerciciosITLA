namespace EjerciciosITLA 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa que calcule el área de un rectángulo (base * altura).


            // declaramos variables
            int numBase, numAltura, numArea;

            Console.WriteLine("CALCULAR EL AREA DE UN RECTANGULO");
            Console.WriteLine("Leonardi Alonzo Chireno");
            Console.WriteLine("");
            Console.Write("Ingrese la base:");
            numBase = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura:");
            numAltura = int.Parse(Console.ReadLine());

            // clacula el area
            numArea = numBase * numAltura;

            // imprime el resultado
            Console.WriteLine("El Área del Rectangulo es:" + numArea);

            Console.ReadLine();
        }
    }
}