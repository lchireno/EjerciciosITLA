class Program
{
    static void Main(string[] args)
    {
        
        //Programa que lea base y altura y calcule el perimetro y area de un rectangulo 

        int b, h, P, A; // declaramos las variables a utilizar

        Console.WriteLine("CALCULAR EL PERIMETRO Y AREA DE UN RECTANGULO");
        Console.WriteLine("Leonardi Alonzo Chireno");
        Console.WriteLine("");

        // Lee la base
        Console.Write("Esbriba la base (b): ");
        b = int.Parse(Console.ReadLine());

        // Lee la altura
        Console.Write("Esbriba la altura (h): ");
        h = int.Parse(Console.ReadLine());

        // calcula el perimetro y el area
        P = 2 * b + 2 * h;
        A = b * h;

        // muestra los resultados en pantalla
        Console.WriteLine("El Perimetro (P) es: " + P);
        Console.WriteLine("El Area (A) es: " + A);
    }
}