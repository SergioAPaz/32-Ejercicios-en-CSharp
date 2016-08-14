using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir diez veces la serie de numeros del 1 al 10.");

            int Cont = 0;
            int Serie = 0;
            while (Cont<=9)
            {
                
                for (int i = 1; i <=10 ; i++)
                {
                    Console.WriteLine("\n Serie {0}",Serie);
                    Console.WriteLine("Numero: {0}", i);
                }
                Serie++;
                Cont++;
            }
            Console.ReadKey();
        }
    }
}
