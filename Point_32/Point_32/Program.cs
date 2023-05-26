using System;

namespace Point_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n,higher=0,less=0,stwh=1;

            Console.WriteLine("        *******           Bienvenidos     ***************\n\n" +
                "   ****     Este Programa Determina El numero Mayor Y Menor de los Ingresados  *** ");
            while (stwh == 1)
            {
                Console.WriteLine("\n Cuantos Numeros deeseas Ingresar");
                n = Convert.ToInt32(Console.ReadLine());
                int[] arrayNumbers = new int[n];


                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    Console.Write(string.Format("\n Por Favor Introducir el Numero {0} : ", i + 1));
                    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                higher = arrayNumbers[0];
                less = arrayNumbers[0];
                for (int i = 1; i < arrayNumbers.Length; i++)
                {
                    if (higher < arrayNumbers[i]) higher = arrayNumbers[i];
                    if (less > arrayNumbers[i]) less = arrayNumbers[i];
                }
                Console.WriteLine(string.Format("\nEl Numero Mayor es {0} y El Menor es {1} ", higher, less));
                Console.WriteLine("Para Introducir otros Numeros Digita 1 o cualquiera para salir");
                stwh=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
