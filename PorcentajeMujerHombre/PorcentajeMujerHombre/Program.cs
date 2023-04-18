using System;

namespace PorcentajeMujerHombre
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, gender;
            float percentageMale, percentageFemale, persons;
            int i, swth=1;
            while (swth == 1)
            {
                int counterMale = 0, counterFemale = 0;
                Console.WriteLine("\n****************    ¿Cuántas personas quieres ingresar?   ******************\n");
                persons = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n ");

                for (i = 1; i <= persons; i++)
                {
                    Console.Write(string.Format(" {0}-Nombre: ", i));
                    firstName = Console.ReadLine();
                    Console.Write("  ");

                    Console.Write("  Apellido: ");
                    lastName = Console.ReadLine();
                    Console.Write("  ");

                    Console.Write("  Genero M o F:  ");
                    gender = Console.ReadLine();
                    Console.Write(" \n ");

                    if (gender == "M" || gender == "m") counterMale++;
                    else counterFemale++;
                }

                percentageMale = (counterMale / persons) * 100;
                percentageFemale = (counterFemale / persons) * 100;

                Console.WriteLine($"\n\nEl procentaje de hombres es: {String.Format("{0:0.##}", percentageMale)}%");
                Console.WriteLine($"El procentaje de mujeres es: {String.Format("{0:0.##}", percentageFemale)}%");
                Console.WriteLine(" Para Ingresar de Nuevo Marca 1 o Cualquiera Para Finalizar");
                swth=Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}