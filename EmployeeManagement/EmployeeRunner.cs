using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamL.EmployeeManagement;

namespace EmployeeManagement
{
    public class EmployeeRunner
    {

        static void Main(string[] args)
        {

           

            string name= Employee.GetAuthorName();
            Console.WriteLine(name);

            Employee.companyName = "TeamL";



            Employee emp1 = new Employee(4.4);
            Employee emp2 = new Employee(200,"john");
            Employee emp3 = new Employee("bala",45);
          //  Employee emp4 = Employee.GetEmployeeInstance();

            emp1.EmpId = 101;
            emp1.empName = "Saul";
            emp1.empSalary = 9000;
            emp1.empPerformance = "Good";

            emp2.EmpId = 200;
            emp2.empName = "Peter";
            emp2.empSalary = 500;
            emp2.empPerformance = "Excellent";

            Console.WriteLine(emp1.EmpId);


            emp2.PrintEmployeeDetails();

            emp3.PrintEmployeeDetails();

            emp1.PrintEmployeeDetails();
            Employee.PrintEmployeeDetails2(emp1 );

            emp2.PrintEmployeeDetails();
            emp2.AllocateBonus();
            emp2.PrintEmployeeDetails();

            List<Employee> employees = new List<Employee>();
            employees.Add( emp1 );
            employees.Add( emp2 );
            employees.Add(emp3);

            foreach( Employee emp in employees )
            {
                if(emp.EmpId==45)
                {
                    emp.PrintEmployeeDetails();
                }
            }

            Employee e = employees.FirstOrDefault(x => x.EmpId == 45);
            e.PrintEmployeeDetails();

        }
    }
}
