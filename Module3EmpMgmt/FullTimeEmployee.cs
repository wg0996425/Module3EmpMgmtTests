using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3EmpMgmt
{
    public class FullTimeEmployee : Employee
    {
        // Creates neccessary private variable
        private decimal? annualbonus;

        // Gets the private variable and sets it to a public, usable one 
        public decimal? AnnualBonus { get { return annualbonus; } set { annualbonus = value; } }

        // Defines inherited structure of the FullTimeEmployee class
        public FullTimeEmployee(int id, string name, string department, decimal basesalary, decimal annualbonus) : base(id, name, department, basesalary)
        {
            this.AnnualBonus = annualbonus;
        }

        // Method for calculating pay
        public override void CalculatePay()
        {
            var pay = BaseSalary + AnnualBonus;
            Console.WriteLine($"Full-Time Employee Pay: {pay}");
        }

        // ToString method to display employee description
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}, Annual Bonus: {AnnualBonus}";
        }
    }
}
