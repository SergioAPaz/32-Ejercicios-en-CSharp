using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir los numeros pares entre 0 y 100: \n");

            int x = 0;

            for (int i = 0; i <= 100 ; i=i+2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
