using System;

namespace DivMayorEntreMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int swth=1;
            double num1 , num2 ;
            double res ;

            while (swth == 1)

            {
                Console.WriteLine("    ***********************");
                Console.WriteLine("    *Division De 2 Numeros*");
                Console.WriteLine("    ***********************\n");
                Console.WriteLine("    Ingresa 2 NUmeros");
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());

                if (num1 == 0 && num2 == 0)
                {
                    Console.WriteLine("*************INDETERMINACION*****************");
                    Console.WriteLine(" ");
                    Console.WriteLine(" INGRESA 1 Para volver a Ingresar Los Numeros");
                    swth = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                else if (num1 == 0)
                {
                    res = num1 / num2;
                    Console.WriteLine(" ");
                    Console.WriteLine($"La Div Del Mayor Entre El Menor es: {res} \n");
                    Console.WriteLine(" INGRESA 1 Para volver a Ingresar Los Numeros o  cualquiera Para finalizar");
                    swth = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                else if (num2 == 0)
                {
                    res = num2 / num1;
                    Console.WriteLine(" ");
                    Console.WriteLine($"La Div Del Mayor Entre El Menor es: {res} \n");
                    Console.WriteLine(" INGRESA 1 Para volver a Ingresar Los Numeros o  cualquiera Para finalizar");
                    swth = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                else
                if (num1 < num2)
                {
                    res = num2 / num1;
                    Console.WriteLine(" ");
                    Console.WriteLine($"La Div Del Mayor Entre El Menor es: {res} \n");
                    Console.WriteLine(" INGRESA 1 Para volver a Ingresar Los Numeros o  cualquiera Para finalizar");
                    swth = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    res = num1 / num2;
                    Console.WriteLine(" ");
                    Console.WriteLine($"La Div Del Mayor Entre El Menor es: {res} \n");
                    Console.WriteLine(" INGRESA 1 Para volver a Ingresar Los Numeros o  cualquiera Para finalizar");
                    swth = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }


            }
           

        }
    }
}
