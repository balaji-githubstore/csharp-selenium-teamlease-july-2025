using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo2FB
    {
        static void Mai1n(string[] args)
        {
            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.facebook.com"; //wait for page lo

            driver.FindElement(By.CssSelector("#email")).SendKeys("hello");

            driver.FindElement(By.LinkText("Create new account")).Click();


            string actualHeader= driver.FindElement(By.XPath("//div[contains(text(),'new')]")).Text;

            //label[text()='Custom']
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByText("20");


            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Apr");

            //var elementOptions =  selectMonth.Options;


            IList<IWebElement> elementOptions = selectMonth.Options;

            Console.WriteLine(elementOptions.Count);

            //Console.WriteLine(elementOptions[0].Text);

            for(int i=0;i<elementOptions.Count;i++)
            {
                Console.WriteLine(elementOptions[i].Text);
            }

            foreach(IWebElement ele in elementOptions)
            {
                Console.WriteLine(ele.Text);
            }

            IWebElement ele1=  elementOptions.FirstOrDefault(x => x.Text == "Dec");
            Console.WriteLine(ele1.Text);
        }
    }
}
