using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir un numero y que el programa nos diga si es positivo o negativo");

            string Respuesta = "s";

            while (Respuesta=="s")
            {
                Console.WriteLine("\nTeclea un numero: ");
                string numero = Console.ReadLine();

                Double numero2=Convert.ToDouble(numero);

                if (numero2>0)
                {
                    Console.WriteLine("\nEl numero es positivo.");
                }
                else
                {
                    Console.WriteLine("\nEl numero es negativo.");
                }

                Console.WriteLine("\nDeseas seguir en el juego (s/n)?: ");
                Respuesta = Console.ReadLine();

            }
        }
    }
}
