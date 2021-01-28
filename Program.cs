using System;

namespace FinalOopLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee developer = new Employee {Title = "developer", Position = ".Net Devision", Amount = 3500, Rate = 1.75, Experience = 10, HourlyPaymentCount = 240, SickLeaveCount = 23 };
            Employee hr = new Employee{ Title = "HR manager", Position = "HR Devision", Amount = 1350, Rate =  1.65, Experience = 7, HourlyPaymentCount = 230, SickLeaveCount = 19 };
            Employee driver = new Employee { Title = "corparate driver", Position = "Administration", Amount = 800, Rate = 1.66, Experience = 15, HourlyPaymentCount = 220, SickLeaveCount = 11 };

            Employee employeeInfo1 = new Employee();
            Employee employeeInfo2 = new Employee("developer", ".Net Devision");
            Employee employeeInfo3 = new Employee("developer", ".Net Devision", 3500, 1.75, 5, 240, 23);
           
            bool isFirstSalarybiggerThanSecond = developer.IsSalaryBigger(hr);
            developer.Amount = 3500;
            hr.Amount = 1350;
            driver.Amount = 800;

            var mostPaidEmployee = Employee.GetMostPaidEmployee(developer,hr,driver);

            decimal developer1 = developer.GetSalaryEmployee();
            decimal hr2 = hr.GetSalaryEmployee();
            decimal driver3 = driver.GetSalaryEmployee();
        }
    }
}
