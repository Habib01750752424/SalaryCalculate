using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculate
{
    public partial class SalaryCalculationUI : Form
    {
        SalaryCalculation salaryCalculation = new SalaryCalculation();

        string eName = "";
        double bSalary;
        double hRent;
        double mAllownce;

        public SalaryCalculationUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            eName = nameTextBox.Text;
            bSalary = Convert.ToDouble(basicTextBox.Text);
            hRent = Convert.ToDouble(houseRentTextBox.Text);
            mAllownce = Convert.ToDouble(medicalTextBox.Text);

            salaryCalculation.SetInfo(eName, bSalary);

            salaryCalculation.houseRent = salaryCalculation.HouseRent(hRent);
            salaryCalculation.medicalAllownce = salaryCalculation.MedicalAllownce(mAllownce);

            double totalSalary = salaryCalculation.basicSalary + salaryCalculation.houseRent + salaryCalculation.medicalAllownce;

            MessageBox.Show(salaryCalculation.employeeName+" "+"your Salary: "+ totalSalary);
        }
    }
}
