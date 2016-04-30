using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            String Respuesta = "s";
            Console.WriteLine("imprimir los numeros naturales que hay desde la unidad hasta un numero que introducimos por teclado \n");
            while (Respuesta=="s")
            {
                Console.WriteLine("\nFavor de ingresar un numero: ");
                String Teclado = Console.ReadLine();
                Console.WriteLine("\n");
                int x = Int32.Parse(Teclado);
                int Contador = 0;
                for (int i = 0; i < x; i++)
                {
                    Contador = Contador + 1;
                    Console.WriteLine(Contador);
                }
                Console.WriteLine("\nDesea seguir ingresando numeros: (s/n)?: ");
                Respuesta = Console.ReadLine();
               
            }
            Console.ReadKey();

        }
    }
}
