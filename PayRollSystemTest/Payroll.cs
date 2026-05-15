using PayRollSystemTest.Services;

namespace PayRollSystemTest
{
    [TestClass]
    public sealed class Payroll
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Gross Pay Calculations")]
        public void CalculateGrossPay_10Hours()
        {
            double hours = 10;
            double result = Calculator.CalculateGrossPay(hours);
            TestContext.WriteLine("Expected result: R9500\n" +
                "Actual result: R" + result);
            Assert.AreEqual(9500, result, 0.001);
        }

        [TestMethod]
        [TestCategory("UIF Deduction Calculations")]
        public void CalculateUIFDeduction_GrossPay10000()
        {
            double grossPay = 10000;
            double result = Calculator.CalculateUIFDeduction(grossPay);
            TestContext.WriteLine("Expected result: R100\n" +
                "Actual result: R" + result);
            Assert.AreEqual(100, result, 0.001);
        }

        [TestMethod]
        [TestCategory("Membership Deduction Calculations")]
        public void CalculateMembershipFee_GrossPay10000()
        {
            double grossPay = 10000;
            double result = Calculator.CalculateMembershipFee(grossPay);
            TestContext.WriteLine("Expected result: R1300\n" +
                "Actual result: R" + result);
            Assert.AreEqual(1300, result, 0.001);
        }

        [TestMethod]
        [TestCategory("PAYE Deduction Calculations")]
        public void CalculatePAYEDeduction_GrossPay10000ADependents2()
        {
            double grossPay = 10000;
            int dependents = 2;
            double result = Calculator.CalculatePAYEDeduction(grossPay, dependents);
            TestContext.WriteLine("Expected result: R2212.5\n" +
                "Actual result: R" + result);
            Assert.AreEqual(2212.5, result, 0.001);
        }

        [TestMethod]
        [TestCategory("Net Pay Calculations")]
        public void CalculateNetPay_WhenHoursAre10AndDependentsAre2()
        {
            double hours = 10;
            int dependents = 2;

            double result = Calculator.CalculateNetPay(hours, dependents);
            TestContext.WriteLine("Expected result: R6068.125" +
                "Actual result: R" + result);

            Assert.AreEqual(6068.125, result);
        }
    }
}
