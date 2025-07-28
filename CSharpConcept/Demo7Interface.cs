using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{

    interface IWebDriverDemo
    {
        public abstract void Quit();
        string GetTitle();
    }

    interface IJavascriptExecutorDemo
    {
        public abstract void ExecuteScript();
    }
    class ChromeDriverDemo : IWebDriverDemo,IJavascriptExecutorDemo
    {
        public ChromeDriverDemo()
        {
            Console.WriteLine("chrome browser launch");
        }

        public void ExecuteScript()
        {
            Console.WriteLine("execute js in chrome");
        }

        public string GetTitle()
        {
            return "chrome get title";
        }

        public void Quit()
        {
            Console.WriteLine("chrome quit browser");
        }

       
    }
    class EdgeDriverDemo1 : IWebDriverDemo,IJavascriptExecutorDemo
    {
        public EdgeDriverDemo1()
        {
            Console.WriteLine("edge browser launch");
        }
        public string GetTitle()
        {
            return "edge get title";
        }

        public void Quit()
        {
            Console.WriteLine("edge quit browser");
        }
        public void ExecuteScript()
        {
            Console.WriteLine("execute js in edge");
        }
    }

    public class Demo7Interface
    {
        static void Main(string[] args)
        {

            IWebDriverDemo driver = new ChromeDriverDemo();

            Console.WriteLine(driver.GetTitle());
            driver.Quit();

            IJavascriptExecutorDemo driver2 = (IJavascriptExecutorDemo)driver;
            driver2.ExecuteScript();

         
        }
    }

}

