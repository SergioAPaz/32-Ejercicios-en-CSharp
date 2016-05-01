using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir un numero por teclado y que nos diga si es paro impar: \n");

            String Respuesta = "s";

            while (Respuesta=="s")
            {
                Console.WriteLine("\nIntroduce un numero:");
                String Numero = Console.ReadLine();
                Double Numero2 = Convert.ToDouble(Numero);

                if (Numero2 % 2 == 0)
                {
                    Console.WriteLine("\nEl numero {0} es par. \n",Numero2);

                }else if(Numero2%0 != 2)
                {
                    Console.WriteLine("\nEl numero {0} es impar.\n",Numero2);
                }

                Console.WriteLine("Deseas seguir en el juego (s/n)? ");
                Respuesta = Console.ReadLine();
            }
        }
    }
}
