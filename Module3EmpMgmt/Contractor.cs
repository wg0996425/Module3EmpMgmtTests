using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3EmpMgmt
{
    public class Contractor : Employee
    {
        // Creates neccessary private and public variables
        public DateTime startdate = new DateTime(2025, 01, 01);
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
            BaseSalary = Convert.ToInt32((ContractExpiryDate - startdate).TotalDays * 30 * 10);

        }

        // ToString method to display employee description
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}, Contract Expiry Date: {ContractExpiryDate}";
        }
    }
}
