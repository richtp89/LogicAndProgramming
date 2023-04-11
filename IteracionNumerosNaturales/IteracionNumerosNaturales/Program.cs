using System;

namespace IteracionNumerosNaturales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, swth = 1;


            while (swth == 1)

            {
                int res = 0;

                Console.WriteLine("\n ***  Suma de Numeros Pares Hasta EL Ingresado  *** \n");
                Console.WriteLine("          Ingresa Por Favor Un Numero  ");
                n = Convert.ToInt32(Console.ReadLine());

                for (i = 0; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        res = res + i;
                    }
                }
                Console.WriteLine(string.Format("La suma de Los numeros pares es: {0}", res));
                Console.WriteLine("\n  Para Ingresar Otro Numero Marca 1 o Culaquiera Para Finalizar \n");
                swth = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
