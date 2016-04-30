using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio2
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros del 100 al 0 en orden decreciente: \n");

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

    }
}
