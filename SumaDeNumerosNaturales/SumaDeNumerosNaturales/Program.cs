using System;

namespace SumaDeNumerosNaturales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i,swth=1;
            while (swth == 1)
            {
                int suma = 0;
                Console.WriteLine("\n ****** Suma de Numeros Naturales hasta el Numero Ingresado *****   \n");
                Console.WriteLine("              Ingresa Por favor Un Numero Natural");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    suma = suma + i;
                }

                Console.WriteLine(string.Format("\nLa suma es: {0} ", suma));

                Console.WriteLine("Si Desea hacer Otra Suma Marque 1 o Cualquiera Para Finalizar");
                swth = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
