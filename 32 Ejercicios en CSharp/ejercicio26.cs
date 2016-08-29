using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class ejercicio26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir una frase por teclado. Imprimirla en el centro de la pantalla.");


            Console.WriteLine("\nEscriba una frase:\n");
            String Frase = Console.ReadLine();

            Console.WriteLine("\t\t\t\t"+Frase+"\t\t\t\t");
            Console.ReadKey();
        }

    }
}
