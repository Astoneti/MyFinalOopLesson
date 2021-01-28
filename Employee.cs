using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalOopLesson
{
    class Employee
    {
        private decimal amount;
        private double rate;
        private decimal experience;
        private decimal hourlyPaymentCount;
        private decimal sickLeaveCount;
        
        public string Title { get; set; } 
        public string Position { get; set; }
        public decimal Amount 
        {
            get { return amount; }
            set 
            {
                if (value >= 0)
                {
                    amount = value;
                }
                else
                if (value < 0) throw new Exception("Invalid error!, enter the correct value > 0");
            } 
        }
        public double Rate
        {
            get { return rate; }
            set
            {
                if (value >= 0)
                {
                    rate = value;
                }
                else
                if (value < 0) throw new Exception("Invalid error!, enter the correct value > 0");
            }
        }
        public decimal Experience
        {
            get { return experience; }
            set
            {
                if (value >= 0)
                {
                    experience = value;
                }
                else
                if (value < 0) throw new Exception("Invalid error!, enter the correct value > 0");
            }
        }
        public decimal HourlyPaymentCount
        {
            get { return hourlyPaymentCount; }
            set
            {
                if (value >= 0)
                {
                    hourlyPaymentCount = value;
                }
                else
                if (value < 0) throw new Exception("Invalid error!, enter the correct value > 0");
            }
        }
        public decimal SickLeaveCount
        {
            get { return sickLeaveCount; }
            set
            {
                if (value >= 0)
                {
                    sickLeaveCount = value;
                }
                else
                if (value < 0) throw new Exception("Invalid error!, enter the correct value > 0");
            }
        }

        public Employee() { }
        public Employee(string title, string position) : this() 
        {
            Title = title;
            Position = position;
        }

        public Employee(string title, string position, decimal amount, double rate, decimal experience, decimal hourlyPaymentCount, decimal sickLeaveCount) : this( title, position)
        {
            Amount = amount;
            Rate = rate;
            Experience = experience;
            HourlyPaymentCount = hourlyPaymentCount;
            SickLeaveCount = sickLeaveCount;
        }

        public static Employee GetMostPaidEmployee(Employee employee1, Employee employee2, Employee employee3)    
        {
            decimal salary1 = employee1.GetSalaryEmployee();  
            decimal salary2 = employee2.GetSalaryEmployee();    
            decimal salary3 = employee3.GetSalaryEmployee(); 
            return (salary1 > salary2) ? ((salary1 > salary3) ? employee1 : employee3) : ((salary2 > salary3) ? employee2 : employee3);
        }

        public bool IsSalaryBigger(Employee salary) 
        {
            return amount > salary.amount;
        }

        public decimal GetSalaryEmployee()
        {
            decimal salary = (decimal) rate * amount;
            decimal hourAmount = GetSalaryBasedOnHourlyPaid();
            decimal experienceAmount = GetSalaryBasedOnExperience(salary);
            return salary + experienceAmount + hourAmount;
        }
        
        public override string ToString()
        {
            return string.Format("Title: {0}, Position: {1}, Amount: {2}, Rate: {3}, Experience: {4}, HourlyPaymentCount: {5}, SickLeaveCount: {6}", Title, Position, Amount, Rate, Experience, HourlyPaymentCount, SickLeaveCount);
        }

        private decimal GetSalaryBasedOnHourlyPaid()     
        {
            decimal hourlyWage = hourlyPaymentCount * 10;
            return hourlyWage;
        }

        private decimal GetSalaryBasedOnExperience (decimal salary)      
        {
            decimal result = 0;
            if (experience > 10)
            {
                result = (salary / 100) * 10;
            }
            if (experience > 20)
            {
                result = (salary / 100) * 20;
            }
            return result;
        }
    }
}
