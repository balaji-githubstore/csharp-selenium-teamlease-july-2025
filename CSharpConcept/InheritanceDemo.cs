
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
   public class Son : Father
    {
        public int sAge = 20;
        public Son(int fAge,int sAge):base(fAge) 
        {
            Console.WriteLine("son constuctor");
        }
        public void SonStyle()
        {
            base.FatherStyle();
            Console.WriteLine(base.fAge);
            Console.WriteLine("son style");
        }
    }

    public class InheritanceDemo
    {
        static void Mainww(string[] args)
        {
            //Father f = new Father();
            //Console.WriteLine(f.fAge);
            //f.FatherStyle();

            Son son = new Son(70,30);

            Console.WriteLine(son.fAge);
            Console.WriteLine(son.sAge);

            son.FatherStyle();
            son.SonStyle();
        }
    }
}
