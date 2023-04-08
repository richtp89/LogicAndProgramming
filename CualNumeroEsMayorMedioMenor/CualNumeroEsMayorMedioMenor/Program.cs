using System;

namespace CualNumeroEsMayorMedioMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, swth = 1;
            while (swth == 1)
            {
                Console.WriteLine("\n ****** Cual Numero Es Mayor, Medio y El Menor de los Ingresados  ******\n");
                Console.WriteLine("                Ingresa Por Favor 3 Numeros\n");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2 && num1 > num3) Console.WriteLine($"\n El Numero Mayor es {num1}");
                else if (num2 > num1 && num2 > num3) Console.WriteLine($"\n El Numero Mayor es {num2}");
                else Console.WriteLine($"\n El Numero Mayor es {num3}");
                Console.WriteLine(" ");
                if (num1 < num2 && num1 > num3) Console.WriteLine($"\n El Numero Medio es {num1}");
                else if (num2 < num1 && num2 > num3) Console.WriteLine($"\n El Numero Medio es {num2}");
                else if (num2>num1&&num2<num3)Console.WriteLine($"\n El Numero Medio es {num2}");
                else if (num3< num1&&num3>num2) Console.WriteLine($"\n El Numero Medio es {num3}");
                else if (num3>num1&& num3<num2) Console.WriteLine($"\n El Numero Medio es {num3}");
                else if (num1>num2&&num1<num3) Console.WriteLine($"\n El Numero Medio es {num1}");
                Console.WriteLine(" ");
                if (num1 < num2 && num1 < num3) Console.WriteLine($"\n El Numero Menor es {num1}");
                else if (num2 < num1 && num2 < num3) Console.WriteLine($"\n El Numero Menor es {num2}");
                else Console.WriteLine($"\n El Numero Menor es {num3}");
                Console.WriteLine(" ");
                Console.WriteLine("   Para Ingresar Nuevos Numeros Marca 1 O Cualquiera Para Finalizar");
                swth=Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }

        }
    }
}
