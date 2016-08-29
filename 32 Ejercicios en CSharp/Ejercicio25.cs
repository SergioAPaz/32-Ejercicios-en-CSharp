using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Ejercicios_en_CSharp
{
    class Ejercicio25
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            Console.WriteLine("Introduce numero");
            
            String var11 = Console.ReadLine();
            int var1 = Convert.ToInt32(var11);
            String[] cadena = new String[10];

            if (var1 >= 1 && var1 <= 5000)
            {
                do
                {
                    if (var1 == 5000)
                    {
                        cadena[i] = "V";
                        var1 = var1 - 5000;
                        i++;
                    }
                    else if (var1 == 4000)
                    {
                        var1 = var1 - 4000;
                        cadena[i] = "MV";
                        i++;
                    }
                    else if (var1 >= 1000)
                    {
                        cadena[i] = "M";
                        var1 = var1 - 1000;
                        i++;
                    }
                    else if (var1 == 900)
                    {
                        var1 = var1 - 900;
                        cadena[i] = "CM";
                        i++;
                    }
                    else if (var1 >= 500)
                    {
                        cadena[i] = "D";
                        var1 = var1 - 500;
                        i++;
                    }
                    else if (var1 == 400)
                    {
                        var1 = var1 - 400;
                        cadena[i] = "CD";
                        i++;
                    }
                    else if (var1 >= 100)
                    {
                        cadena[i] = "C";
                        var1 = var1 - 100;
                        i++;
                    }
                    else if (var1 == 90)
                    {
                        var1 = var1 - 90;
                        cadena[i] = "XC";
                        i++;
                    }
                    else if (var1 >= 50)
                    {
                        cadena[i] = "L";
                        var1 = var1 - 50;
                        i++;
                    }
                    else if (var1 == 40)
                    {
                        var1 = var1 - 40;
                        cadena[i] = "XL";
                        i++;
                    }
                    else if (var1 >= 10)
                    {
                        cadena[i] = "X";
                        var1 = var1 - 10;
                        i++;
                    }
                    else if (var1 >= 5)
                    {
                        cadena[i] = "V";
                        var1 = var1 - 5;
                        i++;
                    }
                    else if (var1 >= 1)
                    {
                        cadena[i] = "I";
                        var1 = var1 - 1;
                        i++;
                    }

                } while (var1 > 0);

                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine(cadena[j]);
                }

            }
            else
            {
                Console.WriteLine("El numero es incorrecto");
            }

            Console.ReadKey();
        }
    }
}
