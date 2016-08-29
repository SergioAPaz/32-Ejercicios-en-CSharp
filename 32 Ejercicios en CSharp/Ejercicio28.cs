using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simular el lanzamiento de una moneda al aire e imprimir si ha salido cara o cruz.");
            

            String x = "y";
            while ((x == "Y") || (x == "y"))
            {
                Random rnd = new Random();

                int Var = rnd.Next(50);

                if (Var <25)
                {
                    Console.WriteLine("\nLa moneda cayo en sello");
                }
                else
                {
                    Console.WriteLine("\nLa moneda cayo en cruz");
                }

                Console.WriteLine(Var);

                Console.WriteLine("\nDeseas seguir jugando? (Y/N): ");
                x = Console.ReadLine();
            }

        }
    }
}
