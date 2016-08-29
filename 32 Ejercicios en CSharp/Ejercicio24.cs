using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio24
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comprobar si un numero mayor o igual que la unidad es primo.");

            Console.WriteLine("\nTeclea un numero: \n");
            String Num = Console.ReadLine();

            int Num2 = Convert.ToInt16(Num);

            if (Num2>=1)
            {
                if (Num2%2!=0)
                {
                    Console.WriteLine("El numero introducido es un numero primo");
                }
                else
                {
                    Console.WriteLine("El numero introducido es par");
                }
            }
            else
            {
                Console.WriteLine("El numero es menor que la unidad");
            }

            Console.ReadKey();
        }
    }
}
