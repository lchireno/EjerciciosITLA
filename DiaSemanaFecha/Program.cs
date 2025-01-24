using Microsoft.VisualBasic;

namespace EjerciciosITLA
{

    class Program
    {
        //creamos una enumeracion para los dias de la semana en Español.
        //ya que la propiedad .DayOfWeek, muestra los dias en ingles aunque puede convertirse a entero (0-6)
        enum diasSemana 
        { 
            Domingo,
            Lunes, 
            Martes, 
            Miercoles, 
            Jueves, 
            Viernes, 
            Sábado        
        }; // los enums deben definir a nivel de clase o namespace (no en un metodo), ya que son tipos de datos

        static void Main(string[] args)
        {
            //Programa que pida al usuario su fecha de nacimiento, y diga de qué día de la semana se trataba.

            DateTime fechaNacimiento;
            string continuar = "S";

            while (continuar == "S")
            {
                Console.Clear();
                Console.WriteLine("LEER LA FECHA DE NACIMIENTO Y MOSTRAR QUE DIA DE SEMANA ES");
                Console.WriteLine("leonardi Alonzo Chireno");
                Console.WriteLine("");

                // Leemos la fecha de nacimiento
                Console.Write("Fecha de nacimiento:");
                fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("");

                // creamos la variable dia del tipo diaSemana y le asignamos el valor de la lista diaSemana
                // que corresponda al valor entero de la propiedad DayOfWeek
                diasSemana dia = (diasSemana)((int)fechaNacimiento.DayOfWeek);

                // mostramos el dia en pantalla
                Console.WriteLine("El dia " + fechaNacimiento.ToString("dd-MM-yyyy") + " es " + dia);

                Console.Write("Desea continuar (S/N):");
                continuar = Console.ReadLine().ToUpper();
            }
        }
    }
}