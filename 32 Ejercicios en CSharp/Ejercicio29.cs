using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio29
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simular cien tiradas de dos dados y contar las veces que entre los dos suman 10.");

            Random rnd = new Random();
            int Counter=0;
            for (int i = 0; i < 100; i++)
            {

                int Dado1 = rnd.Next(1,7);
                int Dado2 = rnd.Next(1,7);
               
                if (Dado1+Dado2==10)
                {
                    Counter= Counter + 1;
                    Console.WriteLine("Dado1: " + Dado1+"*");
                    Console.WriteLine("Dado2: " + Dado2+"*");
                }
                else
                {
                    Console.WriteLine("Dado1: " + Dado1);
                    Console.WriteLine("Dado2: " + Dado2);
                }
            }

            Console.WriteLine("\nEl numero de veces que los dados sumaron 10 son: {0}",Counter);
            Console.ReadLine();
        }
    }
}
