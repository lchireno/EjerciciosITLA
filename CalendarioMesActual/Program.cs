namespace EjerciciosITLA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestre el calendario del mes actual .

            // declaramos una matriz bidireccionar tipo string de 5 filas y 7 columnas.
            string[,] calendario = new string[5, 7];

            // declaramos la variable mesActual,
            // a la cual le asignamos la fecha actual menos los dias que lleva el mes
            // obtener el primer dia del mes actual
            DateTime inicioMes = DateTime.Today.AddDays(1-DateTime.Today.Day);

            int diaSemInicioMes = (int)inicioMes.DayOfWeek; //variable es igual al no. del dia de la semana del inicio de mes
            int dia = 1;
            int diasMes = inicioMes.AddMonths(1).AddDays(-1).Day; //variable es igual a la cantidaad de dias que tiene el mes

            Console.WriteLine("CALENDARIO DEL MES ACTUAL");
            Console.WriteLine("leonardi Alonzo Chireno");
            Console.WriteLine("");

            Console.WriteLine(inicioMes.ToString("MMMM yyyy").ToUpper());
            Console.WriteLine("");
            Console.WriteLine(" D  L  M  M  J  V  S");
            Console.WriteLine("--------------------");

            for (int f = 0; f < 5; f++) // bucle para las filas (semanas)
            {
                for (int c = 0; c < 7; c++) // bucle para las columnas (dias)
                {
                    // si la columna  es inferior al no. dia de la semana del inicio del mes (c < diaSemInicioMes)
                    // y es la primera fila (f==0) o si el dia es mayor los dias del mes ( || dia > diasMes)
                    if (c < diaSemInicioMes && f == 0 || dia > diasMes)
                    {
                        calendario[f, c] = "   "; //guarda tres espacios en la posiscion de la matriz calendario
                    }
                    else 
                    {
                        calendario[f, c] = dia.ToString("00 "); //guarda el dia en la posiscion de la matriz calendario, formateado a 3 carcateres
                        dia = dia + 1; // incrementa dia en 1

                    }
                    Console.Write(calendario[f, c]); // escribe el valor guardado en la posicion de la matiz calendario
                }
                Console.WriteLine();// inserta una linea para escribir la siguiente fila
            }
            Console.ReadKey();
            // leer los 10 numeros y asginarlos a las diez posiciones el arreglo
        }
    }
}