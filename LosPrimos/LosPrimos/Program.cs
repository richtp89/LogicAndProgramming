using System;

namespace NumerosPrimosHasta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, swth = 1, divs = 0;

            while (swth == 1)
            {
                int j = 2;
                Console.WriteLine("\n  ****  Programa Para Mostrar Los Numeros Primos Hasta el Ingresado  **** \n");
                Console.WriteLine("                    Ingresa Por Favor Hasta que Numero");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                if (n > 2)
                {
                    while (j <= n)
                    {
                        for (int i = 1; i <= j; i++)
                        {
                            if (j % i == 0) divs++;
                            if (divs > 2) break;
                        }

                        if (divs == 2) Console.WriteLine(string.Format("     {0}", j));
                        divs = 0;
                        j++;
                    }

                    Console.WriteLine("\n Para Ingresar Un Nuevo Numero Marca 1 o Cualquiera Para Finalizar ");
                    swth = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(" Por Favor Ingresar un Numero Mayor que 2 ");
                    Console.WriteLine("\n Para Ingresar Un Nuevo Numero Marca 1 o Cualquiera Para Finalizar ");
                    swth = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
            }
        }
    }
}
