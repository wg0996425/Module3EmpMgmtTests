using Module3EmpMgmt;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.Net.Sockets;

namespace Tests
{
    // Tests for CalculatorPay method
    [TestClass]
    public class CalculatePayTests
    {
        // Tests for the CalculatePay method in the FullTimeEmployee class
        [TestMethod]
        public void CalculatorPay_ShouldReturnBaseSalaryPlusAnnualBonus()
        {
            // Arrange
            var fulltimeemployee = new FullTimeEmployee(80011, "Joe Loser", "Gamma Department", 50000, 500);
            var expectedPay = 50500;

            // Act
            fulltimeemployee.CalculatePay();
            var result = fulltimeemployee.BaseSalary;

            // Assert
            Assert.AreEqual(expectedPay, result);
        }
        [TestMethod]
        public void CalculatorPay_ShouldReturnOnlyBaseSalary_WhenAnnualBonusIsZero()
        {
            // Arrange
            var fulltimeemployee = new FullTimeEmployee(80011, "Joe Loser", "Gamma Department", 50000, 500);
            var expectedPay = 50000;

            // Act
            fulltimeemployee.AnnualBonus = 0;
            fulltimeemployee.CalculatePay();
            var result = fulltimeemployee.BaseSalary;

            // Assert
            Assert.AreEqual(expectedPay, result);
        }

        // Tests for the CalculatePay method in the PartTimeEmployee class
        [TestMethod]
        public void CalculatorPay_ShouldReturnCorrectAmount_WhenGivenHourlyRateAndHours()
        {
            // Arrange
            var parttimeemployee = new PartTimeEmployee(80101, "Garrett Bennett", "Beta Department", 20400, 17, 1117);
            var expectedPay = 18989;

            // Act
            parttimeemployee.CalculatePay();
            var result = parttimeemployee.BaseSalary;

            // Assert
            Assert.AreEqual(expectedPay, result);
        }
        [TestMethod]
        public void CalculatorPay_ShouldReturnZero_WhenHoursWorkedIsZero()
        {
            // Arrange
            var parttimeemployee = new PartTimeEmployee(80101, "Garrett Bennett", "Beta Department", 20400, 17, 1117);
            var expectedPay = 0;

            // Act
            parttimeemployee.HoursWorked = 0;
            parttimeemployee.CalculatePay();
            var result = parttimeemployee.BaseSalary;

            // Assert
            Assert.AreEqual(expectedPay, result);
        }

        // Tests for the CalculatePay method in the Contractor class
        [TestMethod]
        public void CalculatorPay_ShouldReturnCorrectAmountForContractor()
        {
            // Arrange
            var contractor = new Contractor(81011, "Moe Swampson", "Sigma Department", 0, new DateTime(2025, 04, 21));
            var expectedPay = 33000;

            // Act
            contractor.CalculatePay();
            var result = contractor.BaseSalary;

            // Assert
            Assert.AreEqual(expectedPay, result);
        }
        // TEST 2 NOT FOUND. There is no scenario where the Contractor class can realistically calculate pay with negative numbers
    }

    // Tests for ToString method
    [TestClass]
    public class ToStringTests
    {
        // Tests for correct description from ToString method in Employee class
        [TestMethod]
        public void ToString_ShouldReturnCorrectFormat()
        {
            // Arrange
            var employee = new Employee(0, "name", "department", 1);
            var expected = "ID: 0, Name: name, Department: department, Base Salary: $1.00";

            // Act
            using var sw = new StringWriter();
            Console.SetOut(sw);
            Console.WriteLine(employee);

            // Assert
            var result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }

        // Tests for AnnualBonus from ToString method in FullTimeEmployee class
        [TestMethod]
        public void ToString_ShouldIncludeAnnualBonus()
        {
            // Arrange
            var fulltimeemployee = new FullTimeEmployee(80011, "Joe Loser", "Gamma Department", 50000, 500);

            // Act
            var result = false;
            if (fulltimeemployee.ToString().Contains($"Annual Bonus: {fulltimeemployee.AnnualBonus}"))
            {
                result = true;
            }

            // Assert
            Assert.IsTrue(result);
        }

        // Tests for HourlyRate and HoursWorked from ToString method in PartTimeEmployee class
        [TestMethod]
        public void ToString_ShouldIncludeHourlyRateAndHoursWorked()
        {
            // Arrange
            var parttimeemployee = new PartTimeEmployee(80101, "Garrett Bennett", "Beta Department", 20400, 17, 1117);

            // Act
            var result = false;
            if (parttimeemployee.ToString().Contains($"Hourly Rate: {parttimeemployee.HourlyRate}, Hours Worked: {parttimeemployee.HoursWorked}"))
            {
                result = true;
            }

            // Assert
            Assert.IsTrue(result);
        }

        // Tests for ContractExpiryDate from ToString method in PartTimeEmployee class
        [TestMethod]
        public void ToString_ShouldIncludeContractExpiryDate()
        {
            // Arrange
            var contractor = new Contractor(81011, "Moe Swampson", "Sigma Department", 0, new DateTime(2025, 04, 21));

            // Act
            var result = false;
            if (contractor.ToString().Contains($"Contract Expiry Date: {contractor.ContractExpiryDate}"))
            {
                result = true;
            }

            // Assert
            Assert.IsTrue(result);
        }
    }
}