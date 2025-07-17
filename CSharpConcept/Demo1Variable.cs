
using Equiniti.Fomulae;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo1Variable
    {
        public static int aS = 10;  //static variable or class variable
        public static int bS = 20;
        public int aNS = 10;
        public int bNS = 20;  //non-static variable or instance variable 

        static void Mainw(string[] args)
        {
            Demo1Variable.aS = 900;

            Console.WriteLine(Demo1Variable.aS);
            Console.WriteLine(Demo1Variable.bS);


            Demo1Variable obj1 = new Demo1Variable();
            Demo1Variable obj2 = new Demo1Variable();

            obj1.aNS = 800;

            obj2 = obj1;

            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);

            Console.WriteLine(obj2.aNS);
            Console.WriteLine(obj2.bNS);

            double res= Area.AreaOfRectangle(2, 2);
        }
    }
}
