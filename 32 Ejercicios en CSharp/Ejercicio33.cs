using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear un array unidimensional de 10 elementos con nombres de personas. Visualizar los elementos de la lista debiendo ir cada uno en una fila distinta.\n");


            String[] Names = { "pepe","Maria","Carlos", "joajoa", "Mikey", "Gimbo", "Bart", "ocho", "nueve", "10" };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Names[i]);
            }
            Console.ReadKey();

        }
    }
}
