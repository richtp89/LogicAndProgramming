using System;

namespace project_Poo
{
    internal class Program
    {
        static void Main()
        {
            int id;
            string firstName, lastName;
            DateTime birthDate, hiringDate;
            bool isActive;
            decimal salary, sales, hourValue;
            double commissionPercentage, hours;

            SalaryEmployeed salaryEmployee = new SalaryEmployeed();

            Console.WriteLine("*************");
            Console.WriteLine("**EMPLEADOS**");
            Console.WriteLine("*************\n");

            Console.WriteLine("Empleado Asalariado\n");
            AskData(out id, out firstName, out lastName, out birthDate, out hiringDate, out isActive);

            Console.Write("Ingrese el salario: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n");
            salaryEmployee.Id = id;
            salaryEmployee.FirstName = firstName;
            salaryEmployee.LastName = lastName;
            salaryEmployee.BirthDate = birthDate;
            salaryEmployee.HiringDate = hiringDate;
            salaryEmployee.IsActive = isActive;
            salaryEmployee.Salary = salary;

            salaryEmployee.ShowEmployeeInformation();


            Console.WriteLine("Empleado Por Comisión\n");
            AskData(out id, out firstName, out lastName, out birthDate, out hiringDate, out isActive);

            Console.Write("Ingrese las ventas del mes: ");
            sales = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingrese el porcentaje de la comisión: ");
            commissionPercentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");
            CommissionEmployee commissionEmployee = new CommissionEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                HiringDate = hiringDate,
                IsActive = isActive,
                Sales = sales,
                CommissionPercentage = commissionPercentage,
            };

            commissionEmployee.ShowEmployeeInformation();

            Console.WriteLine("Empleado Por Horas\n");

            AskData(out id, out firstName, out lastName, out birthDate, out hiringDate, out isActive);

            Console.Write("Ingrese las horas trabajadas: ");
            hours = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de la hora: ");
            hourValue = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\n");
            HourlyEmployee hourlyEmployee = new HourlyEmployee()
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                HiringDate = hiringDate,
                IsActive = isActive,
                Hours = hours,
                HoursValue = hourValue,
            };

            hourlyEmployee.ShowEmployeeInformation();
        }

        public static void AskData(out int id, out string firstName, out string lastName, out DateTime birthDate, out DateTime hiringDate, out bool isActive)
        {
            Console.Write("Ingrese su ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese su nombre: ");
            firstName = Console.ReadLine();

            Console.Write("Ingrese sus apellidos: ");
            lastName = Console.ReadLine();

            Console.Write("Ingrese su fecha de cumpleaños: ");
            birthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Ingrese su fecha de contratación: ");
            hiringDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("¿Es un empleado activo?: ");
            isActive = Convert.ToBoolean(Console.ReadLine());
        }

    }
}
