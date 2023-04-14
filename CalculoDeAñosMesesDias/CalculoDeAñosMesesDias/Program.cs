using System;

namespace CalculoDeAñosMesesDias
{
    internal class Program
    {
        static void Main()
        {
            int dias, meses, años,diasrestantes,diasrestantesaño, stwch=1;

            

            while (stwch==1)
            {
                askdata(out dias);
                años = CalcuAño(dias);
                meses = Calcumes(dias);
                diasrestantes= Calcumes(dias);
                Console.WriteLine(string.Format("{0} Son {1} Años, {2} Meses, {3} Dias",dias,años,meses,diasrestantes));
                Console.WriteLine(" ");
                Console.WriteLine(" Para Ingresar Otro Numero Marca 1 o Cualquiera Para Finalizar");
                stwch=Convert.ToInt32(Console.ReadLine());
               
                Console.Clear();
                            
            }


        }
        static void askdata(out int dias)
        {
            Console.WriteLine("\n                                **************           ");
            Console.WriteLine("             ***************  Bienvenidos Al Programa  ***************\n");
            Console.WriteLine("\n         Calcularemos Cuantos Años, Meses y Dias Tiene Cierto NÚmero de Dias       \n");
            Console.WriteLine("                                Introduce el Numero ");
            dias = Convert.ToInt32(Console.ReadLine());
        }
        static int CalcuAño(int dias)
        {
            int años;
            años = dias / 365;

            return años;
        }
        static int Calcumes(int dias)
        {
            int diasrestantesaño;
            int meses;
            diasrestantesaño = dias % 365;
            meses = diasrestantesaño / 30;
            return meses;
        }

        static int Calculdias(int dias)
        {
            int diasrestantes;
            int diasrestantesaño;
            diasrestantesaño = dias % 365;
            diasrestantes = diasrestantesaño % 30;
            return diasrestantes;
        }
    }
}
