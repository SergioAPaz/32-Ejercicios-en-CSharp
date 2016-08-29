using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio38
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cargar en una matriz las notas de los alumnos de un colegio en funcion del numero de cursos(filas) y del n£mero de alumnos por curso(columnas).");


            Console.WriteLine("\nTeclea el numero de cursos");
            String CursoTxt = Console.ReadLine();
            int Cursos = Convert.ToInt16(CursoTxt);

            Console.WriteLine("\nTeclea el numero de alumnos");
            String AlumnosTxt = Console.ReadLine();
            int Alumnos = Convert.ToInt16(AlumnosTxt);

            Double[,] Array = new Double[Cursos, Alumnos];

         

            for (int f = 0; f < Cursos; f++)
            {
                for (int c = 0; c < Alumnos; c++)
                {
                    Console.WriteLine("\nTeclee la calificacion del alumno "+c+" del grupo "+f);
                    String CalifTxt = Console.ReadLine();
                    Double Calif = Convert.ToDouble(CalifTxt);
                    Array[f, c] = Calif;
                }
            }
            Console.WriteLine("");
            for (int f1 = 0; f1 < Cursos; f1++)
            {
                for (int c1 = 0; c1 < Alumnos; c1++)
                {
                    Console.Write(Array[f1, c1]);
                    if (c1 != 4)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
    }
}
