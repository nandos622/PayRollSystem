using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollSystemTest.Services
{
    public static class Calculator
    {
        public static double CalculateNetPay(double hours, int dependents)
        {
            double grossPay = CalculateGrossPay(hours);
            double UIFDeduction = CalculateUIFDeduction(grossPay);
            double PAYEDeduction = CalculatePAYEDeduction(grossPay, dependents);
            double membershipFee = CalculateMembershipFee(grossPay);
            return grossPay - UIFDeduction - PAYEDeduction - membershipFee;
        }

        public static double CalculateGrossPay(double hours)
        {
            return hours * 950;
        }

        public static double CalculateUIFDeduction(double grossPay)
        {
            return grossPay * 0.01;
        }

        public static double CalculatePAYEDeduction(double grossPay, int dependents)
        {
            return (grossPay - (grossPay * 0.0575 * dependents)) * 0.25;
        }

        public static double CalculateMembershipFee(double grossPay)
        {
            return grossPay * 0.13;
        }
    }
}
