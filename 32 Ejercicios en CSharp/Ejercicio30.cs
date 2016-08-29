using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSimular una carrera de dos caballos si cada uno tiene igual probabilidad de ganar.\n");

            int x = 1;

            String Ans = "Y";

            while ((Ans=="Y")||(Ans=="y"))
            {
                x = 1;
                while (x == 1)
                {
                    x = 0;
                    Random rnd = new Random();
                    int C1 = rnd.Next(20);
                    int C2 = rnd.Next(20);
                    if (C1 != C2)
                    {
                        if (C1 > C2)
                        {
                            Console.WriteLine("El ganador es el caballo numero 1");
                            Console.WriteLine("Caballo 1: " + C1);
                            Console.WriteLine("Caballo 2: " + C2);
                        }
                        else
                        {
                            Console.WriteLine("El ganador es el caballo numero 2");
                            Console.WriteLine("Caballo 2: " + C2);
                            Console.WriteLine("Caballo 1: " + C1);
                        }
                    }
                    else
                    {
                        x = 1;
                    }

                    
                }
                Console.WriteLine("\nDeseas hacer otra carrera? (Y/N): ");
                Ans = Console.ReadLine();
            }
          
            Console.ReadKey();
          
        }
    }
}
