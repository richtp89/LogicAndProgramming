using System;
using System.Collections.Generic;
using System.Text;

namespace project_Poo
{
    internal class HourlyEmployee : Employee
    {
        public Decimal HoursValue { get; set; }
        public double Hours { get; set; }

        public decimal GetValueToPay()
        {
            return (decimal)Hours * HoursValue;
        }

        public void ShowEmployeeInformation()
        {
            Console.WriteLine(string.Format("Empleado Prestacion De Servicios Id : {0}\n Nombre del Empleado: {1}\n Apellido: {2}" +
           " \n Fecha de Nacimiento: {3}\n Fecha de Ingreso: {4}" +
           "\n Esta Activo ?: {5} \n Horas Laboradas: {6} \n Valor Hora: {7:C} \n Sueldo Devengado : {8:C}",
           Id,
           FirstName,
           LastName,
           BirthDate,
           HiringDate,
           IsActive,
           Hours,
           HoursValue,
           GetValueToPay()));
        }
    }
}
