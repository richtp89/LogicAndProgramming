using System;

namespace Point_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realice un programa que solicite N números,
            // luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú.
            // Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar,
            // si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero).
            // Independientemente de la selección, imprima el resultado.
            // Además, el programa debe tener la posibilidad de volver al menú para pedir N nuevos números y hacer la elección de la operación aritmética
            // o digitar cero para finalizar el programa
            int n,menu,sum=0,rest=0,div=0,mult=1;
            Console.WriteLine("\n*******  BIENVENIDOS A LA CALCULADORA  ******");
            Console.WriteLine("\n Por Favor Introduce Cuantos Numeros desea  Operar");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Ahora Ingresa los NUMEROS ");
            int[] numeros= new int[n];
            for (int i=0; i<numeros.Length; i++) 
            {
                numeros[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Que Operacion deseas Realizar ");
            Console.WriteLine("1- Sumar" +
                "\n2- Restar" +
                "\n3- multiplicar" +
                "\n4- Dividir");
            menu= Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1: 
                    for (int i=0;i<numeros.Length;i++)
                    {
                        sum = sum +numeros[i];
                    }
                    Console.WriteLine(string.Format(" La suma es: {0}", sum));
                    break;
                case 2:
                    rest = 2 * numeros[0];
                    for (int i=0;i<numeros.Length;i++)
                    {
                       
                        rest= rest - numeros[i];
                    }
                    Console.WriteLine(string.Format(" La resta es: {0}", rest));
                    break;
                case 3:
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        mult = mult * numeros[i];

                    }
                    Console.WriteLine(string.Format("\nLa Multiplicacion es: {0}",mult));
                    break;


            }
        }
    }
}
