using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo11Table
    {
        static void Main(string[] args)
        {


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://datatables.net/extensions/select/examples/checkbox/checkbox.html";

            ////for loop for page
            //for(int page=1;page<=7;page++)
            //{
            //    var rowElements = driver.FindElements(By.XPath("//table[@id='example']/tbody/tr"));
            //    for (int i = 1; i <= rowElements.Count; i++)
            //    {
            //        string name1 = driver.FindElement(By.XPath($"//table[@id='example']/tbody/tr[{i}]/td[2]")).Text;
            //        Console.WriteLine(name1);
            //        //if(name1.Equals("Brenden Wagner"))
            //        //{
            //        //    driver.FindElement(By.XPath($"//table[@id='example']/tbody/tr[{i}]/td[1]")).Click();
            //        //    break;
            //        //}
            //    }

            //    driver.FindElement(By.CssSelector("button[aria-label='Next']")).Click();
            //}

            var allAtagsElements = driver.FindElements(By.XPath("//a"));

            IWebElement ele = allAtagsElements.FirstOrDefault(x => x.GetAttribute("href").Contains("datatables.net/tn/20#Initialisation-target"));
            ele.Click();

            List<string> colors = new List<string>();
            colors.Add("yellow");
            colors.Add("red");

            string output= colors.FirstOrDefault(x => x.Equals("red"));

            
        }
    }
}
