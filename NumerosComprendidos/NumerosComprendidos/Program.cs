using System;

namespace NumerosComprendidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, swth = 1, swth1=1;
            

           
            while (swth1 == 1)
            {
                Console.WriteLine("\n     ******  Numeros Comprendidos desde A Hasta B  *****   \n");
                Console.WriteLine("               Introduce Por Favor 2 Numeros");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("   La secuencia es: \n");
                if (num1 > num2)
                    Console.WriteLine(num2);
                else Console.WriteLine(num1);
                do
                {
                    if (num1 > num2)
                    {

                        num2++;
                        Console.WriteLine(num2);
                    }
                    else
                    {

                        num1++;
                        Console.WriteLine(num1);
                    }

                    if (num1 == num2)
                        swth = 0;
                }
                while (swth == 1);

                Console.WriteLine("\nSi Desea Ingresar Nuevos Numeros digite 1 o cualquiera para salir");
                swth1=Convert.ToInt32(Console.ReadLine());
                if (swth1 == 1) swth = 1;
                Console.Clear();

            }
        }
    }
}
