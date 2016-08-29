using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio23
    {
        static void Main(string[] args)
        {
            int x = 0, x2 = 1, x3 = 2;
            for (int i = 0; i < 34; i++)
            {
               Console.WriteLine(x + "\t" + x2 + "\t" + x3);
                x = x3 + 1;
                x2 = x + 1;
                if (x2 != 100)
                    x3 = x2 + 1;
                else
                    x3 = 0;
            }
            Console.ReadKey();
        }
    }
}
