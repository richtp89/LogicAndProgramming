using System;

namespace LegalAgeValidator
{
    public class LegalAgeValidator

    {
        static void Main(string[] args)
        {

            byte age;
            byte adulthood;
            byte swt;

            adulthood = 18;
            swt = 1;



            while (swt == 1)
            {
                Console.WriteLine("   ***********************************************************");
                Console.WriteLine("   *                                                         *");
                Console.WriteLine("   *          Legal Age Validator In Colombia                *");
                Console.WriteLine("   ***********************************************************");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("                   Please Enter Your Age");
                Console.WriteLine(" ");
                age = Convert.ToByte(Console.ReadLine());

                if (age > adulthood)
                {
                    Console.WriteLine("              ************************");
                    Console.WriteLine("              **    You're Of Age   **");
                    Console.WriteLine("              ************************");

                }
                else
                {
                    Console.WriteLine("             *******************************");
                    Console.WriteLine("             **  You Are Not Of Legal Age **");
                    Console.WriteLine("             *******************************");
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("           If You Want Another Try, Type 1 Or Type 0 To Exit");
                swt = Convert.ToByte(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
