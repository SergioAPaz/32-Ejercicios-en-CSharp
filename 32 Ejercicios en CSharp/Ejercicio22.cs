using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir una frase por teclado. Imprimirla cinco veces en filas consecutivas, pero cada impresion ir  desplazada cuatro columnas hacia la derecha.\n");

            Console.WriteLine("Introduce un frase:\n");
            String Frase = Console.ReadLine();


            Console.WriteLine(Frase);
            Console.WriteLine("\t"+Frase);
            Console.WriteLine("\t\t" + Frase);
            Console.WriteLine("\t\t\t" + Frase);
            Console.WriteLine("\t\t\t\t" + Frase);

            Console.ReadKey();

        }
    }
}
