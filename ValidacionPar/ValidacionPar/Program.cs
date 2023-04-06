using System;

namespace ValidacionPar
{
    internal class Program
    {
        static void Main()
        {
            int n, swth = 1;
            string res;
            while (swth == 1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("****** Validacion SI el Numero es Par o NO  *****   \n");
                Console.WriteLine("     Ingresa El Numero Por Favor ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    res = "Par";
                    Console.WriteLine(" El Numero es " + res);
                }
                else
                {
                    res = "Impar";
                    Console.WriteLine(" El Numero es " + res);
                }
                Console.WriteLine("\n para ingresar otro numero marque 1 o cualquiera para finalizar");
                swth = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
