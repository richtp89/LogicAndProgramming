using System;

namespace ElMayorDeLosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, swth = 1;

            do
            {
                Console.WriteLine("     *************************");
                Console.WriteLine("     *El Mayor de Los Numeros*");
                Console.WriteLine("     *************************\n");
                Console.WriteLine("    Por Favor Ingresa 3 Numeros ");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                if (num1 > num2 && num1 > num3)
                    Console.WriteLine("El Numero Mayor es {0}", num1);
                else if (num2 > num1 && num2 > num3) Console.WriteLine("El Numero Mayor es {0}", num2);
                else if (num3 > num1 && num3 > num2) Console.WriteLine(" El Nuero Mayor es {0}", num3);
                Console.WriteLine("\n Para ingresar nuevos Numeros Marca 1 o cualquiera para finalizar");
                swth= Convert.ToInt32(Console.ReadLine());
            }
            while (swth == 1);

        }
    }
}
