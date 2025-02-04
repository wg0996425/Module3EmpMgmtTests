using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3EmpMgmt
{
    public class Contractor : Employee
    {  
        // Creates neccessary private variable
        private DateTime contractexpirydate;

        // Gets the private variable and sets it to a public, usable one 
        public DateTime ContractExpiryDate { get { return contractexpirydate; } set { contractexpirydate = value; } }

        // Defines inherited structure of the Contractor class
        public Contractor(int id, string name, string department, decimal basesalary, DateTime contractexpirydate) : base(id, name, department, basesalary)
        {
            this.ContractExpiryDate = contractexpirydate;
        }

        // Method for calculating pay
        public override void CalculatePay()
        {
            // Salary is based upon the total number of days from the current days until the expiry date multiplied by hourly pay, multiplied by hours per day worked
            var BaseSalary = (ContractExpiryDate - DateTime.Today).TotalDays * 30 * 10;
            Console.WriteLine($"Contractor Pay: {BaseSalary}");
        }

        // ToString method to display employee description
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}, Contract Exipry Date: {ContractExpiryDate}";
        }
    }
}
