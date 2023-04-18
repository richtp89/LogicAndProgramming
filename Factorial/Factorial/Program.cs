using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int swth = 1;
            while (swth == 1)
            {
                int num, fact = 1;
                Console.WriteLine("\n         *******    Bienvenidos Al Factorial Del Numero   ******\n");
                Console.WriteLine("\n                       **    Ingresa El Numero    **\n");
                num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    fact = i * fact;
                }

                Console.WriteLine(string.Format("\n    El Factorial de {0} Es:  {1}\n", num, fact));
                Console.WriteLine("   ***   Si Desea Ingresar Un Nuevo Numero Ingresa 1 o cualquiera Para Finalizar  ***");
                swth = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
