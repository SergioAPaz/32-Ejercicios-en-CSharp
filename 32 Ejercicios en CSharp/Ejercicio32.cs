using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio32
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un programa que nos permita introducir un numero por teclado y sobre el se realicen las siguientes operaciones: comprobar si es primo, hallar su factorial o imprimir su tabla de multiplicar atravez de un switch y con funciones.");

            Console.WriteLine("\nIntroduce un numero: ");
            String Num = Console.ReadLine();
            int Numx = Convert.ToInt32(Num);

            Console.WriteLine("\nA) Encontrar si es primo");
            Console.WriteLine("B) Encontrar su factorial");
            Console.WriteLine("C) Imprimir su tabla de multiplicar");

            Console.WriteLine("\nOpcion a elejir: ");
            String Ans = Console.ReadLine();
            switch (Ans)
            {

                case "A":
                    Primo(Numx);
                    break;
                case "B":
                    Factorial(Numx);
                    break;
                case "C":
                    Tabla(Numx);
                    break;

                default:
                    Console.WriteLine("\nNo mames escoje solo de las opciones disponibles.");
                    break;
            }

            Console.ReadKey();


        }

        static void Primo(int Numx)
        {
            if (Numx % 2 == 0)
            {
                Console.WriteLine("\nEl numero si es primo.");
            }
            else
            {
                Console.WriteLine("\nEl numero no es primo.");
            }
            
        }


        static void Factorial(int Numx)
        {
            for (int i = Numx; i > 2; i--)
            {
                Numx = Numx * (i - 1);
            }
            Console.WriteLine(Numx);
        }


        static void Tabla(int Numx)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(Numx+" x "+i+"="+"{0}",(Numx*i));
            }
        }
    }
}
