using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo que calcula los numeros del 1 al 100 y calcula la suma de los pares por un lado y por otro lado la suma de los impares: \n");
            int Pares = 0;
            int Impares = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("El numero {0} es par",i);
                    Pares = Pares + i;

                }
                else
                {
                    Console.WriteLine("El numero {0} es impar",i);
                    Impares = Impares + i;
                }
            }
            Console.WriteLine("\nLa suma de los pares es: {0}",Pares);
            Console.WriteLine("\nLa suma de los impares es: {0}", Impares);
            Console.ReadKey();

        }
    }
}
