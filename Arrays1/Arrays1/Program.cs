using System;
using System.Runtime.Intrinsics.X86;

namespace Ejercicio28_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notes;
            double sum = 0, avg;

            AskData(out notes,out sum);
            avg=CalculateAverage(notes, sum,out avg);
            ShowResults(notes,sum, avg);     
           
        }
       static public void AskData(out double[] notes,out double sum)
        {
           notes = new double[5];
            sum = 0;
            for (int i = 0; i < notes.Length; i++)
            {
               
                Console.WriteLine(String.Format("Por favor, ingrese la nota del estudiante {0}", i + 1));
                notes[i] = Convert.ToDouble(Console.ReadLine());
                sum = sum + notes[i];

            }
        }
        static public double CalculateAverage(double[] notes, double sum,out double avg)
        {
            notes= new double[5];
            avg = sum / notes.Length;

            Console.Clear();

            return avg;
        }
       static public void ShowResults(double[] notes,double sum, double avg)
        {
          
            Console.WriteLine("NOTAS DE LOS ESTUDIANTES");

            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine(String.Format("Estudiante {0}: Nota {1}", i + 1, notes[i]));
            }

            Console.WriteLine(String.Format("\nEl promedio general del grupo es de {0}", avg));

        }
    }
}