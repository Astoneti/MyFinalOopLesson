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

        public static Employee GetMostPaidEmployee(Employee salary1, Employee salary2, Employee salary3)    
        {
            decimal sum1 = salary1.GetSalaryCalculation();  
            decimal sum2 = salary2.GetSalaryCalculation();    
            decimal sum3 = salary3.GetSalaryCalculation(); 
            return (sum1 > sum2) ? ((sum1 > sum3) ? salary1 : salary3) : ((sum2 > sum3) ? salary2 : salary3);
        }

        public bool ShowIsSalaryBigger(Employee salary) 
        {
            return amount > salary.amount;
        }

        public decimal GetSalaryCalculation()
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
            decimal hourSalary = hourlyPaymentCount * 10;
            decimal totalSum = amount + hourlyPaymentCount;
            return totalSum;
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
