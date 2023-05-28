using System;

namespace Point_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construya un programa en C# que solicita 5 números al usuario y haga la suma de todos ellos.
            //El algoritmo debe solicitar números siempre y cuando el número ingresado sea positivo,
            //si el usuario ingresa un número no positivo el algoritmo debe terminar e imprimir la suma de los números positivos.

            int[] arrayNumbers = new int[5];
            int sum,swth;
            do
            {
                sum = 0;
                Console.WriteLine("\n    *****  La Suma de Numeros Positivos     *****  \n");
                Console.WriteLine("\nIngresa 5 numeros");
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());

                    if (arrayNumbers[i] < 0) i = arrayNumbers.Length;

                    else sum = sum + arrayNumbers[i];
                }
                Console.WriteLine(string.Format("La Suma de los numeros ingresados es: {0}", sum));
                Console.WriteLine("\n Para un nuevo intento marca 1 o cualquiera para finalizar ");
                swth = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (swth == 1);
        }
    }
}
