using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir el mayor y el menor de una serie de cinco numeros que vamos introduciendo por teclado: \n");
            int[] numeros;
            numeros = new int[4];
            String NumerosTxt;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingresa un numero: ");
                NumerosTxt = Console.ReadLine();

                int NumerosInt = Convert.ToInt32(NumerosTxt);

                numeros[i] = NumerosInt;
                
            }
            Console.WriteLine("\nLa lista de numeros fue: ");
            int Mayor=0;
            int Menor = 999999999;
            for (int x = 0; x < 4; x++)
            {
                if (numeros[x]>Mayor)
                {
                    Mayor = numeros[x];
                }
                if (numeros[x] < Menor)
                {
                    Menor = numeros[x];
                }
                Console.WriteLine("{0}",numeros[x]);
            }

            Console.WriteLine("\nEl mayor de la lista es: {0}",Mayor);
            Console.WriteLine("\nEl menor de la lista es: {0}", Menor);
            Console.ReadKey();
        }
    }
}
