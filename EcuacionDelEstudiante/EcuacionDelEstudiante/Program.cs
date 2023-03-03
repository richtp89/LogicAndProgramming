using System;

namespace EcuacionDelEstudiante
{
    internal class Program
    {
        static void Main()
        {
            double a, b, c, respositivo, resnegativo, res;
            int shw = 1;
            while (shw == 1)
            {
                Console.WriteLine("                 ************************             ");
                Console.WriteLine("      Aplicacion Para Resolver Ecuaciones Cuadraticas ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("           Ingresa Por Favor El Coeficiente de x^2:  ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("            Ingresa Por Favor el Coeficiente de x:  ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("                 Ingresa Por Favor la Constante:    ");
              
                c = Convert.ToDouble(Console.ReadLine());

                double discriminante = (b * b - 4 * a * c);

                if (discriminante > 0)
                {
                    respositivo = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    resnegativo = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    Console.WriteLine(" ");
                    Console.Write($"         La Respuesta es:    {respositivo}  ");
                    Console.WriteLine($"      y :    {resnegativo}");
                }
                else if (discriminante == 0)
                {

                    res = -b / 2 * a;
                    Console.Write("               La Respuesta es; ");
                    Console.WriteLine(res);
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("             la respuesta no esta en los reales");
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" Si Desea Ingresar Otra Ecuación Por Favor Digite 1 ó 0 Para Finalizar ");
                int otra = Convert.ToInt32(Console.ReadLine());
                if (otra == 1) shw = 1;
                else shw = 0;

                Console.Clear();
            }
        }
    }
}


