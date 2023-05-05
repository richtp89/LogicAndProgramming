using System;
using System.Collections.Generic;
using System.Text;

namespace project_Poo
{
    internal class CommissionEmployee:Employee
    {
        public Decimal Sales { get; set; }
        public double CommissionPercentage { get; set; }

        public decimal GetValueToPay()
        {
            return Sales * (decimal)(CommissionPercentage / 100);
        }

       public void ShowEmployeeInformation()
        {
            Console.WriteLine(string.Format("Empleado Comisionista : {0}\n Nombre del Empleado: {1}\n Apellido: {2}" +
           " \n Fecha de Nacimiento: {3}\n Fecha de Ingreso: {4}" +
           "\n Esta Activo ?: {5} \n Ventas Mes: {6:C} \n Porcentaje De Comision: {7} \n Ingreso Comision : {8:C}",
           Id,
           FirstName,
           LastName,
           BirthDate,
           HiringDate,
           IsActive,
           Sales,
           CommissionPercentage,
           GetValueToPay()));
        }
    }
}
