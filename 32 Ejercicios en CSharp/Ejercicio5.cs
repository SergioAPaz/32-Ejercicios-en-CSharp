using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imprimir los numeros impares hasta el cien e imprimir cuantos impares hay: \n");
            int Contador = 0;
            for (int i = 1; i <= 100; i=i+2)
            {
                Contador = Contador+1;
                Console.WriteLine(i);

            }
            Console.WriteLine("\nEl numero de impares que hay es: {0}",Contador);
            Console.ReadKey();
        }
    }
}
