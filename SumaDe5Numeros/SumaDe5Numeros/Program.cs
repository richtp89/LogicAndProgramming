using System;

namespace SumaDe5Numeros
{
    public class Program
    {
        static void Main()
        {
            double num1, num2, num3, num4, num5, res;
            int shw=1;

            while (shw == 1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("          **********************             ");
                Console.WriteLine("            Suma De 5 Numeros     ");
                Console.WriteLine(" ");
                Console.Write("  Ingresa Primer Numero:   ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("  Ingresa Segundo Numero:   ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("  Ingresa Tercer Numero:   ");
                num3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("  Ingresa Cuarto Numero:   ");
                num4 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("  Ingresa Quinto Numero:   ");
                num5 = Convert.ToDouble(Console.ReadLine());

                if (num1 < 0) { num1 = -1 * num1; };
                if (num2 < 0) { num2 = -1 * num2; };
                if (num3 < 0) { num3 = -1 * num3; };
                if (num4 < 0) { num4 = -1 * num4; };
                if (num5 < 0) { num5 = -1 * num5; };

                res = num1 + num2 + num3 + num4 + num5;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("      La Suma es:    ");
                Console.WriteLine(res);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Si Desea Otra Suma Digite 1 ó 0 Para Salir");
                shw=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }  
        }
    }
}
