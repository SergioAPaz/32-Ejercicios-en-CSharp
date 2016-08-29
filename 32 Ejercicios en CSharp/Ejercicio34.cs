using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un programa que lea las calificaciones de un alumno en 10 asignaturas, las almacene en un vector y calcule e imprima su media.");

            Double[] Arr=new double [15];
            
            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine("Teclee la calificacion {0}: ", i);
                String CalifTxt = Console.ReadLine();
                Double Calif = Convert.ToDouble(CalifTxt);
                Arr[i] = Calif;

            }

            Console.WriteLine("\nLas calificaciones ingresadas fueron: \n");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(Arr[i]);
            }
            Console.ReadKey();
        }
    }
}
