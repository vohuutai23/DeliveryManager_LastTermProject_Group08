using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public class Shipper : Employee
    {
        public int iNumberOfOrdersDelivered;

        public Shipper() : base()
        {

        }
        public Shipper(int numberOfOrdersDelivered, string idEmployee, string employeeName, double bassicSalary, string numberphoneofEmployee) : base(idEmployee, employeeName, bassicSalary, numberphoneofEmployee)
        {
            this.iNumberOfOrdersDelivered = numberOfOrdersDelivered;
            this.iNumberOfOrdersDelivered = 0;
        }

        public void congDonhang()
        {
            this.iNumberOfOrdersDelivered = this.iNumberOfOrdersDelivered + 1;
        }
        public override double Salary()
        {
            return this.iNumberOfOrdersDelivered * 3000 + this.dBassicSalary;
        }

        public override void PrintInformEmployee()
        {
            base.PrintInformEmployee();
            Console.WriteLine("Salary of this shipper:          " + this.Salary());
            Console.WriteLine("Amount of order deliveried:      " + this.iNumberOfOrdersDelivered);
        }

        //edit form
        public override string ToString()
        => $"{iNumberOfOrdersDelivered,5}{string.Join(",", sIDEmployee),10}{string.Join(",", sEmployeeName),15}{string.Join(",", dBassicSalary),15}{string.Join(",", sNumberphoneofEmployee),15}";
    }
}
