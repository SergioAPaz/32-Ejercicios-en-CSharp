using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir la suma de los 100 primeros numeros: \n");
            int suma=0;
            for (int i = 0; i <= 100; i++)
            {
                suma = suma + i;
                Console.WriteLine("La suma de los primeros: "+i+" numeros es: "+suma);
            }
            Console.ReadKey();
        }
    }
}
    