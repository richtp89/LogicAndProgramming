using System;

namespace Point_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dado un vector de tamaño N, llenar el vector aleatoriamente con números enteros.
            //Pedir por pantalla un número y determinar si ese número se encuentra en el vector,
            //en caso afirmativo, indicar su posición (índice) dentro del vector, en caso negativo,
            //mostrar el mensaje “El número no existe”.
            int n,num,cont=0,stwh=1;
            Random random= new Random();
            

            Console.WriteLine("\n    *****    adivinando el numero   *****\n");
            Console.WriteLine(" Ingresa la cantidad de numeros de los cuales vamos adivinar uno, van del 0 al 100 ");
            n=Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i=0;i<numbers.Length;i++) 
            {
                numbers[i] = random.Next(0,100);    
            }
           
            while (stwh == 1)
            {
                Console.WriteLine("ingresa por favor un numero para ver si esta en el vector ");
                num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == num)
                    {
                        Console.WriteLine(string.Format("si esta, es el de la posiscion {0}", i + 1));
                        cont++;
                    }
                }
                if (cont == 0) Console.WriteLine("El numero no existe ");
                Console.WriteLine("\n Para intentar otro marca 1 o cualquier otro para salir");
                stwh = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
