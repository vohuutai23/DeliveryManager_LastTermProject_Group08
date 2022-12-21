using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManager_LastTermProject_Group08
{
    public abstract class Employee : ISearch
    {
        //fields
        public string sIDEmployee;
        public string sEmployeeName;
        public double dBassicSalary;
        public string sNumberphoneofEmployee;
        public int iSearch = 0;
        //properties
        public string IDEmployee
        {
            get { return this.sIDEmployee; }
            set { this.sIDEmployee = value; }
        }
        public string EmployeeName
        {
            get { return this.sEmployeeName; }
            set { this.sEmployeeName = value; }
        }
        public double BassicSalary
        {
            get { return this.dBassicSalary; }
            set { this.dBassicSalary = value; }
        }
        public string NumberphoneofEmployee
        {
            get { return this.sNumberphoneofEmployee; }
            set { this.sNumberphoneofEmployee = value; }
        }

        //constructors
        public Employee()
        {

        }

        public Employee(string idEmployee, string employeeName, double bassicSalary, string numberphoneofEmployee)
        {
            this.sIDEmployee = idEmployee;
            this.sEmployeeName = employeeName;
            this.dBassicSalary = bassicSalary;
            this.sNumberphoneofEmployee = numberphoneofEmployee;
        }

        //destructors
        ~Employee()
        {

        }
        public abstract double Salary();

        public virtual void PrintInformEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("Information of Employee");
            Console.WriteLine("ID of Employee:                  " + this.sIDEmployee);
            Console.WriteLine("Name of Employee:                " + this.sEmployeeName);
            Console.WriteLine("Basic Salary:                    " + this.dBassicSalary);
            Console.WriteLine("Phone Number of Employee:        " + this.sNumberphoneofEmployee);

        }

        //interface
        public void Search(string employee)
        {

            if (employee == EmployeeName)
            {
                iSearch++;
                PrintInformEmployee();
            }
        }
    }
}
