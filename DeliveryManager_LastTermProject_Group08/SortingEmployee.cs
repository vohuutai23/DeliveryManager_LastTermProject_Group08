using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class SortingEmployee : Employee
    {
        public double dWorkingTime;

        public SortingEmployee() : base()
        {

        }
        public SortingEmployee(int workingTime, string idEmployee, string employeeName, double bassicSalary, string numberphoneofEmployee) : base(idEmployee, employeeName, bassicSalary, numberphoneofEmployee)
        {
            this.dWorkingTime = workingTime;
        }

        public override double Salary()
        {
            return this.dWorkingTime * 1000 + this.dBassicSalary;
        }

        public override void PrintInformEmployee()
        {
            base.PrintInformEmployee();
            Console.WriteLine("Salary of this sorting employee: " + this.Salary());
        }

        //edit form
        public override string ToString()
       => $"{dWorkingTime,5}{string.Join(",", sIDEmployee),10}{string.Join(",", sEmployeeName),25}{string.Join(",", dBassicSalary),15}{string.Join(",", sNumberphoneofEmployee),15}";
    }
}
