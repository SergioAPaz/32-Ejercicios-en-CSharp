using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero para calcular su factorial\n");
            String Num = Console.ReadLine();
            int Num2 = Convert.ToInt32(Num);
            Console.WriteLine("\nEl factorial de {0} es: {1}",Num2,Factorial(Num2));
            Console.ReadKey();
        }

        static int Factorial(int Num2)
        {
            for (int i = Num2; i > 2; i--)
            {
                Num2 = Num2 * (i - 1);
            }
            return Num2;
        }

    }
}
