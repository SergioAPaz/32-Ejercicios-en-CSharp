using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar la tabla de multiplicar de un numero entre 0 y 10.");

            String x = "y";
            while ((x=="Y")||(x=="y"))
            {

                Console.WriteLine("\nIngresa un numero entre el 0 y el 10 para mostrarte su tabla de multiplicar\n");

                String Num = Console.ReadLine();

                int NumT = Convert.ToInt16(Num);

                Console.WriteLine("");

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(NumT + " x " + i + "=" + (NumT * i));
                }


                Console.WriteLine("\nDeseas agregar otro numero");
                x = Console.ReadLine();
                
            }

            Console.WriteLine("\nAdios!");

            Console.ReadKey();
        }
    }
}
