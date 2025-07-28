using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{

    public abstract class Employee
    {
        public int id;
        public string name;

        public void DisplayEmployeeRecords()
        {
            Console.WriteLine("parent class");
            Console.WriteLine(id);
            Console.WriteLine(name);
        }

        public abstract void CalculateSalary();
    }

    public class PermanentEmployee : Employee
    {
        public int permanentEmpCode;
        public override void CalculateSalary()
        {
            Console.WriteLine(30 * 1000);
        }

        //public override void DisplayEmployeeRecords()
        //{
        //    Console.WriteLine("child class");
        //    Console.WriteLine(id);
        //    Console.WriteLine(name);
        //    Console.WriteLine(permanentEmpCode);
        //}

        public void PermanentClassOnly()
        {

        }

    }
    public class ContractEmployee : Employee
    {

        public override void CalculateSalary()
        {
            Console.WriteLine(8 * 100);
        }

        public void ContractEmployeeClassOnly()
        {

        }
    }

    public class Demo5Abstract
    {
        static void Main44(string[] args)
        {

            Employee e=new PermanentEmployee();
            e.CalculateSalary();
            e.DisplayEmployeeRecords();

            e=new ContractEmployee();
            e.CalculateSalary();

          //  e.CalculateSalary();

            //PermanentEmployee p1 = (PermanentEmployee)e;
            //p1.PermanentClassOnly();

            //PermanentEmployee p = new PermanentEmployee();
            //p.DisplayEmployeeRecords();
            //p.PermanentClassOnly();
           
        }
    }
}
