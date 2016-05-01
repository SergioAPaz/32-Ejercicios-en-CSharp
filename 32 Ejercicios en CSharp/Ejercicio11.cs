using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir y contar los multiplos de 3 desde la unidad hasta un numero que intorucimos por teclado: \n");

            String Respuesta = "s";

            while (Respuesta=="s")
            {
                Console.WriteLine("\nIntroduce un numero: ");
                String Numero = Console.ReadLine();
                Double numero2 = Convert.ToDouble(Numero);

                for (int i = 0; i < numero2; i++)
                {

                    if (i%3==0 && i!=0)
                    {
                        Console.WriteLine("El numero {0} es multiplo de 3.",i);
                    }
                    else
                    {
                        Console.WriteLine("No hay ningun numero dentro del rango que sea multiplo de 3.");
                    }
                }


                Console.WriteLine("\nDeseas seguir en el juego (s/n) ?:");
                Respuesta = Console.ReadLine();


            }
        }
    }
}
