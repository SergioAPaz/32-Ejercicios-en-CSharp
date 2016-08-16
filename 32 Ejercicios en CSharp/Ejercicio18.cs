using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacer un pseudocodigo que cuente las veces que aparece una determinada letra en una frase que introduciremos por teclado.");
            Char x='s';
            while (x=='s')
            {
                int Count = 0;
                Console.WriteLine("\nInroduce una palabra de 10 digitos o menos: ");
                String Word = Console.ReadLine();

                Console.WriteLine("\nInroduce una letra que desees buscar y contar en la palabra que acabas de ingresar: ");
                String letter = Console.ReadLine();
                Char letterx = Convert.ToChar(letter);

                if (Word.Length <= 15)
                {
                    if (Word.Contains(letter))
                    {
                        for (int i = 0; i < Word.Length; i++)
                        {
                            if ((Convert.ToChar(Word[i])) == letterx)
                            {
                                Count = Count + 1;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("La palabra es demasiado larga.");
                }

                Console.WriteLine("\nEl numero de veces que aparece la letra " + letter + "es: {0}", Count);

                Console.WriteLine("\nDeseas seguir ingresando palabras? (s/n): ");
                x = Console.ReadKey().KeyChar;

                Console.ReadKey();
            }
        }
    }
}
