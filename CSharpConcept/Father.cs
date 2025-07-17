using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
   public class Father
    {
        public int fAge = 60;

        public Father(int fAge)
        {
            this.fAge = fAge;
            Console.WriteLine("father constuctor");
        }

        public void FatherStyle()
        {
            Console.WriteLine("father style!!");
        }
    }
}
