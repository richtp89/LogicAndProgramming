using System;

namespace SumaMientrasPositivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, cont=0,swth2=1;
           
                
                while(swth2==1)
                {
                    Console.WriteLine("\n******Programa Para sumar La cantidad de Numeros Positivos que Ingrese*****\n");
                    Console.WriteLine(" Ingresa un Numero Por Favor");
                    n=Convert.ToInt32(Console.ReadLine());
                    if (n >= 0) cont++;
                    else swth2 = 0;
                    if (swth2 == 1) Console.Clear();

                }

            Console.WriteLine($"***********  La Cantidad de Numeros Positivos Son {cont} *************** ");
            Console.ReadKey();
        }
    }
}
