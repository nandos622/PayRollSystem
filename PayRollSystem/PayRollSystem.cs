using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayRollSystem.Services;

namespace PayRollSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResultsPanel.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UIFTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTextBox.Text.Trim() == "" || HoursTextBox.Text.Trim() == "" || DependentsTextBox.Text.Trim() == "")
                {
                    throw new Exception("Input fields cannot be empty");
                }
                double hoursWorked = double.Parse(HoursTextBox.Text.Trim());
                if (hoursWorked < 0) 
                {
                    throw new Exception("Invalid hours worked");
                }
                int totalDependents = int.Parse(DependentsTextBox.Text.Trim());
                if (totalDependents < 0 || totalDependents > 10)
                {
                    throw new Exception("Invalid total dependents");
                }

                double grossPay = Calculator.CalculateGrossPay(hoursWorked);
                double UIFDeduction = Calculator.CalculateUIFDeduction(grossPay);
                double PAYEDeduction = Calculator.CalculatePAYEDeduction(grossPay, totalDependents);
                double membershipFee = Calculator.CalculateMembershipFee(grossPay);
                double netPay = Calculator.CalculateNetPay(hoursWorked, totalDependents);

                ResultsPanel.Visible = true;
                GrossPayTextLabel.Text = "Gross Pay: R" + grossPay;
                UIFTextLabel.Text = "UIF Deduction: R" + UIFDeduction;
                PAYETextLabel.Text = "PAYE Deduction: R" + PAYEDeduction;
                MembershipTextLabel.Text = "Membership Fee: R" + membershipFee;
                TotalDeductionsTextLabel.Text = "Total Deductions: R" + (UIFDeduction + PAYEDeduction + membershipFee);
                NetPayTextLabel.Text = "Net Pay: R" + netPay;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = "";
            DependentsTextBox.Text = "";
            HoursTextBox.Text = "";
            ResultsPanel.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GrossPayTextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
