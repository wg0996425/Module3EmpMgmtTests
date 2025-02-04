using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module3EmpMgmt
{
    public class Employee
    {
        // Creates neccessary private variables
        private int? id;
        private string? name;
        private string? department;
        private decimal? basesalary;

        // Gets the private variables and sets them to public, usable ones
        public int? ID { get { return id; } set { id = value; } }
        public string? Name { get { return name; } set { name = value; } }
        public string? Department { get { return department; } set { department = value; } }
        public decimal? BaseSalary { get { return basesalary; } set { basesalary = value; } }

        // Defines structure of the Employee class
        public Employee(int id, string name, string department, decimal basesalary)
        {
            this.ID = id;
            this.Name = name;
            this.Department = department;
            this.BaseSalary = basesalary;
        }

        // Placeholder method for calculating pay
        public virtual void CalculatePay()
        {
            var pay = BaseSalary;
        }

        // Placeholder (and ultimately useless) method for displaying employee details
        public virtual void DisplayEmployeeDetails()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}");
        }
    }
}
