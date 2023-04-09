using System;

namespace MultiploDelPrimero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, swth = 1;

            while (swth == 1)
            {
                Console.WriteLine("\n    *********   Multiplo Del Primero   **********\n");
                Console.WriteLine("               Ingresa Por Favor 2 Numeros\n");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 % num2 == 0) Console.WriteLine(string.Format("El {0} es Multiplo de {1} ", num2, num1));
                else Console.WriteLine(string.Format("El {0} No es Multiplo de {1} ", num2, num1));

                Console.WriteLine(" Si Desea Ingresar Otros Numeros Marque 1 o Cualquiera Para finalizar");
                swth=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
