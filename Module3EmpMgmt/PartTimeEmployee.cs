using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3EmpMgmt
{
    public class PartTimeEmployee : Employee
    {
        // Creates neccessary private variables
        private decimal? hourlyrate;
        private int? hoursworked;

        // Gets the private variables and sets them to public, usable ones
        public decimal? HourlyRate { get { return hourlyrate; } set { hourlyrate = value; } }
        public int? HoursWorked { get { return hoursworked; } set { hoursworked = value; } }

        // Defines inherited structure of the PartTimeEmployee class
        public PartTimeEmployee(int id, string name, string department, decimal basesalary, decimal hourlyrate, int hoursworked) : base(id, name, department, basesalary)
        {
            this.HourlyRate = hourlyrate;
            this.HoursWorked = hoursworked;
        }

        // Method for calculating pay
        public override void CalculatePay()
        {
            var BaseSalary = HourlyRate * HoursWorked;
            Console.WriteLine($"Part-Time Employee Pay: {BaseSalary}");
        }

        // ToString method to display employee description
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}, Hourly Rate: {HourlyRate}, Hours Worked: {HoursWorked}";
        }
    }
}
