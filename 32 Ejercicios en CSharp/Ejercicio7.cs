using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intrducir tantas frases como queramos y contarlas: \n");
            String Respuesta = "s";
            int Contador=0;
            while (Respuesta=="s")
            {
                Contador=Contador+1;
                Console.WriteLine("\nIntroduce una frase: ");
                Console.ReadLine();
                Console.WriteLine("\nDeseas seguir agregando palabras (s/n)?:");
                Respuesta = Console.ReadLine();


            }

            Console.WriteLine("\nEl numero de palabras agregadas fue: {0}",Contador);
            Console.ReadKey();

        }
    }
}
