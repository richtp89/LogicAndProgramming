using System;

namespace AñoBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year, mult4=4, mult100=100, mult400=400, swth = 1;
            while (swth == 1)
            {
                Console.WriteLine("\n    *******  Verificador de año Bisiesto  *******  \n");
                Console.WriteLine("                  Ingresa Por Favor el Año\n");
                year= Convert.ToInt32(Console.ReadLine());
                if (year % mult400 == 0 || year % mult4 == 0 && year % mult100 != 0)
                { Console.WriteLine(string.Format("El Año {0} Es Bisiesto", year)); }
                else Console.WriteLine(string.Format("El Año {0} No Es Bisiesto", year));
                Console.WriteLine(" ");
                Console.WriteLine(" Para Ingresar Otro Año Marca 1 o Cualquiera Para Finalizar");
                swth= Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }
        }
    }
}
