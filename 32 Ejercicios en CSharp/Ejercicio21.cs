using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio21
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hacer un programa que muestre los numeros pares y los impares de los numeros entre 1 y 1000, utilizando un switch y arreglos ademas de funciones.");


            Console.WriteLine("\nElige la opcion deseada:\n");

            Console.WriteLine("A) Los numeros Pares entre el 1 y el 100\n");
            Console.WriteLine("B) Los numeros Impares entre el 1 y el 100\n");
            String Answer = Console.ReadLine();


            switch (Answer)
            {

                case "A":
                    Pares();
                    break;

                case "B":
                    ImPares();
                    break;

                default:
                    Console.WriteLine("\nElige solo una de las opciones.");
                    break;
            }

            Console.ReadKey();

        }



        static void Pares()
        {
            int[] Counter = new int[110];
            int y = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Counter[y] = i;
                    y = y + 1;

                }
            }

            Console.WriteLine("Los pares que hay son los sig:/n");
            for (int i = 0; i <= (y - 1); i++)
            {
                Console.WriteLine(Counter[i]);
            }

        }

        static void ImPares()
        {
            int[] Counter2 = new int[110];
            int y = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 != 0)
                {
                    Counter2[y] = i;
                    y = y + 1;

                }
            }

            Console.WriteLine("Los impares que hay son los sig:/n");
            for (int i = 0; i <= (y - 1); i++)
            {
                Console.WriteLine(Counter2[i]);
            }

        }
    }
}
