using CSharpConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamL.CSharpConcept
{
    public class Program
    {
        static void Mai3n(string[] args)
        {

            object a = 10; //boxing
            object v = 102.3;
            object c = new Calculator();


            int z = (int)a; //unboxing 

            int x = (int)v;

            Calculator f = (Calculator)c; 

            f.Add(2, 2);

            //Console.WriteLine("Balaji Dinakarantt");

            //byte a = 100;  //8 bits 
            //sbyte b = 100; //8 bits 

            //short c = 100; //16 bits
            //int d = 100; //32 bits 

            //long e = 100L;

            //float f = 10.2f; //32 bits 

            //double g = 10.2; //64 bits 

            //decimal h = 10.2m;

            //bool i = true;

            //char letter= '#';  //16 bits

            //string myName = "bala";  //4*16 bits of memory 

            //Console.WriteLine(myName);

            //Console.WriteLine(myName.ToUpper());
            //Console.WriteLine(myName[2]);

            //int[] numbers = new int[5];  //5*32 bits of memory 

            //numbers[0] = 10;
            //Console.WriteLine(numbers.GetHashCode());
            //numbers = new int[6];
            //Console.WriteLine(numbers.GetHashCode());
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);

            //string[] colors=new string[6];
            //string[] colors1 = { "red", "green", "yellow" };
            //Console.WriteLine(colors[0]);

            //Console.WriteLine((double)25/2);
        }
    }
}
