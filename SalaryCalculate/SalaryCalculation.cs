using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculate
{
    class SalaryCalculation
    {
        public string employeeName;
        public double basicSalary;
        public double houseRent;
        public double medicalAllownce;

        public void SetInfo(string eName,double bSalary)
        {
            employeeName = eName;
            basicSalary = bSalary;
        }

        public double HouseRent(double hRent)
        {
            houseRent = basicSalary * hRent / 100;
            return houseRent;
        }

        public double MedicalAllownce(double mAllownce)
        {
            medicalAllownce = basicSalary * mAllownce / 100;
            return medicalAllownce;
        }
    }
}
