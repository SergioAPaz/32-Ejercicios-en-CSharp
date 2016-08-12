using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio15
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Introducir dos numeros por teclado. Imprimir los numeros naturales que hay entre ambos numeros empezando por el m s pequeño, contar cuantos de ellos son pares.Calcular la suma de los impares.\n");
            
            Console.WriteLine("Ingresa un numero: ");
            String Numero = Console.ReadLine();
            Double n1 = Convert.ToDouble(Numero);

            int Cont = 0;
            int ContPar = 0;
            int ContInpar = 0;
            Double SumImpar = 0;

            Console.WriteLine("Ingresa un segundo numero: ");
            String Numero2 = Console.ReadLine();
            Double n2 = Convert.ToDouble(Numero2);

            if (n1 < n2)
            {
                for (Double i = n1; i < n2; i++)
                {
                    Cont = Cont+1;
                    Console.WriteLine("\n");
                    Console.WriteLine(i);
                    if (i%2==0)
                    {
                        ContPar++;
                    }
                    else
                    {
                        ContInpar++;
                        SumImpar = SumImpar + i;
                    }
                }
            }
            else if(n2<n1)
            {
                for (Double i = n2; i < n1; i++)
                {
                    Cont = Cont+1;
                    Console.WriteLine("\n");
                    Console.WriteLine(i);
                    if (i % 2 == 0)
                    {
                        ContPar++;
                    }
                    else
                    {
                        ContInpar++;
                        SumImpar = SumImpar + i;
                    }
                }
            }
            else if (n1==n2)
            {
                Console.WriteLine("Los numeros son iguales.");
                Cont = 2;
                if (n1 % 2 == 0)
                {
                    ContPar++;
                }
                else
                {
                    ContInpar++;
                    SumImpar = n2 + n1;
                }
            }

            Console.WriteLine("\n  El numero de numeros que hay es {0}.", Cont);
            Console.WriteLine("\n  De todos ellos solo {0} son pares.",ContPar);
            Console.WriteLine("\n  La suma de los impares es: {0}", SumImpar);
            Console.ReadKey();

        }
        
       
    }
}
