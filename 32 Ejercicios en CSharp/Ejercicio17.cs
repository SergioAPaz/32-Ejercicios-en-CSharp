using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Imprimir, contar y sumar los multiplos de 2 que hay entre una serie de numeros, tal que el segundo sea mayor o igual que el primero.\n");

            Console.WriteLine("Introduce un numero: ");
            String N1 =Console.ReadLine();

            Console.WriteLine("Introduce un segundo numero: ");
            String N2 = Console.ReadLine();

            int Num1 = Convert.ToInt16(N1);
            int Num2 = Convert.ToInt16(N2);

            if (Num2>=Num1)
            {

                Console.WriteLine("\nLa serie de numeros que hay entre ellos es: \n");
                int Count = 0;
                int MultiploDe2 = 0;
                for (int i = Num1; i <= Num2; i++)
                {
                    if (i%2==0)
                    {
                        MultiploDe2= MultiploDe2+i;
                    }
                    Count = Count+1;
                    Console.WriteLine("El numero {0}", i);
                }
                Console.WriteLine("\nEl numero de numeros que hay entre ellos es: {0} \n", Count);
                Console.WriteLine("\nLa suma de numeros multiplos de 2 en la lista anterior es: {0}",MultiploDe2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nIntenta que el primer numero sea menor al segundo");
                Console.ReadKey();
            }
        }
    }
}
