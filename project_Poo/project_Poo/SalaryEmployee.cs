using System;
using System.Collections.Generic;
using System.Text;


    public class SalaryEmployeed : Employee
    {
        public decimal Salary { get; set; }
        
        public decimal GetValuePay() 

        { 
        return Salary;
        }

        public void ShowEmployeeInformation()
        {
        Console.WriteLine(string.Format("Empleado Asalariado : {0}\n Nombre del Empleado: {1}\n Apellido: {2}" +
            " \n Fecha de Nacimiento: {3}\n Fecha de Ingreso: {4}" +
            "\n Esta Activo ?: {5} \n Salario: {6:C}",
            Id,
            FirstName,
            LastName, 
            BirthDate, 
            HiringDate, 
            IsActive, 
            Salary));
        }

    }

