using System;

namespace Point_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sthw = 1;
            Console.WriteLine("****** Bienvenidos Este Programa Suma DOS vectores  ***** \n");
            while (sthw == 1)
            {
                Console.WriteLine("Introduce El primer Vector \n");
                int[] vector1 = new int[5];
                for (int i = 0; i < vector1.Length; i++)
                {
                    Console.Write(string.Format("Numero {0}: ", i + 1));
                    vector1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\n\nIntroduce El segundo Vector \n");
                int[] vector2 = new int[5];
                for (int i = 0; i < vector2.Length; i++)
                {
                    Console.Write(string.Format("Numero {0}: ", i + 1));
                    vector2[i] = Convert.ToInt32(Console.ReadLine());
                }
                int[] suma = new int[5];
                for (int i = 0; i < suma.Length; i++)
                {
                    suma[i] = vector1[i] + vector2[i];
                    Console.WriteLine(string.Format(" La Suma {0} es : {1}", i + 1, suma[i]));
                }
                Console.WriteLine(" Para Ingresar otros Vectores Digite 1 o cualquiera para Salir");
                sthw=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
