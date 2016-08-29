using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio37
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generar una matriz de 4 filas y 5 columnas con n£meros aleatorios entre 1 y 100, y hacer su matriz transpuesta.");

            int[,] array2D = new int[4, 5];
            Random rnd = new Random();

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    array2D[f, c] = rnd.Next(1, 101); ;

                }


            }

            for (int f1 = 0; f1 < 4; f1++)
            {
                for (int c1 = 0; c1 < 5; c1++)
                {
                    Console.Write(array2D[f1, c1]);
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
