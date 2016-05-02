using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir y contar los numeros que son multiplos de 2 o 3 que hay entre 1 y 100: \n");
            int Mdos = 0;
            int Mtres = 0;
            for (int i = 1; i <=100; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("El {0} es multiplo de 2",i);
                    Mdos++;
                    if (i%3==0)
                    {
                        Console.WriteLine("El {0} es multiplo de 3", i);
                        Mtres++;
                    }
                }
                else if (i%3==0)
                {
                    Console.WriteLine("El {0} es multiplo de 3", i);
                    Mtres++;
                }
                
            }
            Console.WriteLine("\nLa cantidad de multiplos de 2 que hay entre 1 y 100 es: {0}", Mdos);
            Console.WriteLine("\nLa cantidad de multiplos de 3 que hay entre 1 y 100 es: {0}", Mtres);
            Console.ReadKey();
        }
    }
}
