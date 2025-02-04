using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3EmpMgmt
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initializes each type of employee
            FullTimeEmployee fulltimeemployee = new FullTimeEmployee(80011, "Joe Loser", "Gamma Department", 50000, 500);
            PartTimeEmployee parttimeemployee = new PartTimeEmployee(80101, "Garrett Bennett", "Beta Department", 20400, 17, 1117);
            Contractor contractor = new Contractor(81011, "Moe Swampson", "Sigma Department", 0, new DateTime(2025, 04, 21));

            // Using the ToString method, this portion of code displays the variables stored by each employee class
            Console.WriteLine(fulltimeemployee);
            Console.WriteLine(parttimeemployee);
            Console.WriteLine(contractor);

            // Calculates the employees pay and displays it
            fulltimeemployee.CalculatePay();
            parttimeemployee.CalculatePay();
            contractor.CalculatePay();
        }
    }
}