using System;

namespace Calculadora1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, suma, resta, mult, div;
            int option, swth = 1;
            while(swth==1) 
            {
                Console.WriteLine("\n        **********  Bienvenidos A la Calculadora  *************\n");
                Console.WriteLine("                       Ingresa 2 Numeros                           ");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("\n                     ¿ Que Operacion Deseas Hacer ?                         \n");
                Console.WriteLine("                           1 -   Suma                              ");
                Console.WriteLine("                           2 -   Resta                             ");
                Console.WriteLine("                           3 -   Multiplicación                    ");
                Console.WriteLine("                           4 -   División                           ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        suma = num1 + num2;
                        Console.WriteLine(string.Format(" La suma es {0}",suma));
                        break;
                    case 2:

                        resta = num1 - num2;
                        Console.WriteLine(string.Format(" La Resta es {0}", resta));
                        break;
                    case 3:

                        mult = num1 * num2;
                        Console.WriteLine(string.Format(" La Multiplicación es: {0}", mult));
                        break;
                    case 4:

                        if (num1 == 0 && num2 == 0)
                            Console.WriteLine(" La division es Indeterminada");

                        else if (num2 == 0)
                        {
                            div = num2 / num1;
                            Console.WriteLine(string.Format("Division entre 0 no es definida se hace la Operacion {0} dividido entre {1} ", num2, num1));
                            Console.WriteLine(string.Format("La Respuesta es: {0}", div));
                        }
                        else
                        {
                            div = num1 / num2;
                            Console.WriteLine(string.Format(" La Division es: {0}", div));
                        }
                        break;
                    default:
                        Console.WriteLine("\n Por Favor Digita una Opción Valida\n");
                        break;
                }
                Console.WriteLine("Para Regresar A las Opciones Marca 1 o Cualquiera Para Finalizar");
                swth = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
