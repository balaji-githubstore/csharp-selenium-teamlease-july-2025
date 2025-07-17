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
    public class Demo1SeleniumTest
    {
        static void Main3(string[] args)
        {
            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);

            driver.Url = "https://www.medibuddy.in/";  //wait for page load to complete

            //By loc = By.LinkText("Login");
            //IWebElement ele = driver.FindElement(loc);
            //ele.Click();

            //check for presence of element in 0.5s 
            driver.FindElement(By.LinkText("Login")).Click();    //new NoSuchElementException("")

            driver.FindElement(By.Id("phone")).SendKeys("9090909");

            //driver.FindElement(By.LinkText("Login")).Click();

        }
    }
}
