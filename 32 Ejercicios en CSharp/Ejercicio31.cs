using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir dos numeros por teclado y mediante un menu, calcule su suma, su resta, su multiplicacion o su division.");

            Console.WriteLine("\nTecleé un numero: ");
            String N1 = Console.ReadLine();

            Console.WriteLine("\nTecleé un segundo numero: ");
            String N2 = Console.ReadLine();

            int N11= Convert.ToInt32(N1);
            int N22 = Convert.ToInt32(N2);

            Console.WriteLine("\nLa Suma es: {0}",(N11+N22));
            Console.WriteLine("\nLa Resta es: {0}", (N11 - N22));
            Console.WriteLine("\nLa Multiplicacion es: {0}", (N11*N22));
            Console.WriteLine("\nLa Division es: {0}", (N11 /N22));

            Console.ReadKey();
        }
    }
}
