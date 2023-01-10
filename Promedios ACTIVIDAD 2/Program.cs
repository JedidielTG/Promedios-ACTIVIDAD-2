using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedios_ACTIVIDAD_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int promedio;
            int promedio2;
            int promedio3;

            int sedades, sedades2;
            int sedades3, sedades4;
            int sedades5, sedades6;
            int f;

            sedades = 0;
            sedades3 = 0;
            sedades5 = 0;

            for (f = 1; f <= 10; f++)
            {
                Console.WriteLine("Por favor ingresa las edades de los alumnos de la mañana: ");
                sedades2 = int.Parse(Console.ReadLine());
                sedades = sedades + sedades2;


            }
            for (f = 1; f <= 10; f++)
            {
                Console.WriteLine("Por favor ingresa las edades de los alumnos de la tarde: ");
                sedades4 = int.Parse(Console.ReadLine());
                sedades3 = sedades3 + sedades4;

            }
            for (f = 1; f <= 10; f++)
            {
                Console.WriteLine("Por favor ingresa las edades de los alumnos de la noche: ");
                sedades6 = int.Parse(Console.ReadLine());
                sedades5 = sedades5 + sedades6;
            }




            promedio = sedades / 10;
            promedio2 = sedades3 / 10;
            promedio3 = sedades5 / 10;



            int total = promedio;


            if (total < promedio2) total = promedio2;
            if (total > promedio3) total = promedio3;



            Console.WriteLine("Promedio del turno MATUTINO");
            Console.WriteLine(promedio);

            Console.WriteLine("Promedio del turno VESPERTINO");
            Console.WriteLine(promedio2);

            Console.WriteLine("Promedio del turno NOCTURNO");
            Console.WriteLine(promedio3);

            Console.WriteLine(" El turno que tiene el promedio mas bajo es: ");
            Console.WriteLine("EL QUE TIENE:"); Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
