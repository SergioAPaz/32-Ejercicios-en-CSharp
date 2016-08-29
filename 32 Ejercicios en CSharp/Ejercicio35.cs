using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando el segundo ejemplo, hacer un programa que busque una nota en el vector.");


            Double[] Notes= { 7,8,6,5.5,1,3,9,2.5,2,9,10};

            Console.WriteLine("\nTeclea la nota que deseas buscar dentro de las existentes");
            String Ans = Console.ReadLine();
            Double Ans2 = Convert.ToDouble(Ans);


            Console.WriteLine("\nEl tamaño del arreglo es de {0}\n",Notes.Length);
            for (int i = 0; i < Notes.Length; i++)
            {
                if (Ans2==Notes[i])
                {
                    Console.WriteLine("La calificacion "+Ans2+" ha sido encontrada en la posicion {0}",i);
                }
              
            }

            Console.ReadKey();
        }
    }
}
