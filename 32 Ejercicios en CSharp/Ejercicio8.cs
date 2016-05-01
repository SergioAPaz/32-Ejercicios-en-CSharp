using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo que solo permite introducir las palabras SI o NO\n");

            String Respuesta="SI";
            String Respuesta2 = "s";
            while ((Respuesta2=="s"))
            {
                Console.WriteLine("\nIngresa SI o NO: ");
                Respuesta = Console.ReadLine();
                if ((Respuesta=="SI")||(Respuesta=="NO"))
                {
                    Console.WriteLine("\nBien echo sigue tecleando...\n");
                }
                else
                {
                    Console.WriteLine("Mal, solo puedes agregar SI o NO....\n");
                    
                }
                Console.WriteLine("Deseas seguir en el juego (s/n)?:");
                Respuesta2 = Console.ReadLine();
            }
        }
    }
}
