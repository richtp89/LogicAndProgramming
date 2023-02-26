using System;

namespace SumOfNaturalNumbers
{
    public class SumOfNaturalNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("            *******************************************");
            Console.WriteLine("            **         Sum Of Natural Numbers        **");
            Console.WriteLine("            *******************************************");

            int num, suma, cont, sewtch;


            sewtch = 1;
            while (sewtch == 1)
            {
                cont = 0;
                suma = 0;
                
                Console.WriteLine("           *************  Menu *****************");
                Console.WriteLine("           **                                 **");
                Console.WriteLine("           ** Ingrese 1 Para Ingresar Numero  **");
                Console.WriteLine("           **       o 0 Para Salir            **");
                Console.WriteLine("           **                                 **");
                Console.WriteLine("           *************************************");
                sewtch = Convert.ToInt32(Console.ReadLine());

                if (sewtch != 1 && sewtch != 0)
                {
                    Console.WriteLine("     **  Por Favor Ingrese Un Numero De Acuerdo Al Menu  ** ");
                }
                else
                {
                    while (sewtch == 1)
                    {
                        Console.WriteLine("   **  Por Favor Ingrese Un Numero Natural    **");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num < 0)
                        {
                            Console.WriteLine("    **El Numero Ingresado No Es Un Numero Natural  **");
                        }
                        else
                        {
                            while (cont <= num)
                            {
                                suma = suma + cont;
                                cont = cont + 1;
                            }
                            Console.WriteLine("   ** La suma de los números naturales del número ingresado es: ");
                            Console.WriteLine(suma);
                            sewtch = 0;

                        }
                    }
                    Console.WriteLine("Si desea ingresar un nuevo número, digite 1 ó 0 para finalizar");
                    sewtch = Convert.ToInt32(Console.ReadLine());
                    cont = 0;
                    suma = 0;


                }
                if (sewtch == 0)
                {
                    Console.WriteLine("     ***  Has finalizado el programa. Adiós!    ***");
                }
           
               
                       

                
        


                

            }
        }
    }
}