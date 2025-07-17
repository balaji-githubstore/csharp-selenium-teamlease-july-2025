using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamL.EmployeeManagement
{
    public class Employee
    {
        public string empName;
        public double empSalary;
        public string empPerformance;
        public static string companyName;

        private int _empId;

        public Employee(int empId)
        {
            Console.WriteLine("Browser launch!!!");
            this._empId = empId;
        }
        public Employee(double a)
        {
       
        }

        public Employee(int empId, string empName)
       {
            _empId = empId;
            this.empName = empName;
        }

        public Employee(string empName, int empId):this(empId, empName) 
        {
          
        }

        public int EmpId
        {
            get
            {
                return _empId;
            }
            set
            {
                if (value > 100)
                {
                    _empId = value;
                }
                else
                {
                    Console.WriteLine("Cannot be less than 100");
                }
            }
        }

        public static string GetAuthorName()
        {
            return "Balaji Dinakaran";
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(this.empName);
            Console.WriteLine(empSalary);
            Console.WriteLine(empPerformance);
            Console.WriteLine(Employee.companyName);
        }

        public static void PrintEmployeeDetails2(Employee x)
        {
            Console.WriteLine(x.EmpId);
            Console.WriteLine(x.empName);
            Console.WriteLine(x.empSalary);
            Console.WriteLine(x.empPerformance);
            Console.WriteLine(Employee.companyName);
        }

        //public static Employee GetEmployeeInstance()
        //{
        //    Employee employee = new Employee();

        //    return employee;
        //}

        public void AllocateBonus()
        {
            if (empPerformance.ToLower().Equals("excellent"))
            {
                empSalary = empSalary + 10000;
            }
        }
    }
}
