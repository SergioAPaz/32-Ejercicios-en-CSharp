using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un pseudocodigo que simule el funcionamiento de un reloj digital y que permita ponerlo en hora.");

            Console.WriteLine("Elige una hora en la cual comenzar: ");
            String Hora1 = Console.ReadLine();
            int Hours = Convert.ToInt32(Hora1);

            Console.WriteLine("Elige un minuto en el cual comenzar: ");
            String Hora2 = Console.ReadLine();
            int Mins = Convert.ToInt32(Hora2);

            Console.WriteLine("Elige una segundo en el cual comenzar: ");
            String Hora3 = Console.ReadLine();
            int Seconds = Convert.ToInt32(Hora3);
            
            while (Hours<24)
            {
               
                while (Mins<60)
                {
                 
                    while (Seconds<=59)
                    {
                        Console.WriteLine(Hours + ":" + Mins + ":" + Seconds);
                        Seconds = Seconds + 1;
                    }
                    Seconds = 0;
                    Mins = Mins + 1;
                }
                Mins = 0;
                Hours = Hours + 1;
            }
            Console.ReadKey();
        }
    }
}
