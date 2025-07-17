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
    public class Demo10Fluent
    {
        static void Maindd(string[] args)
        {
            IWebDriver driver = new EdgeDriver();
            driver.Manage().Window.Maximize();


            driver.Url = "https://www.facebook.com";

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.PollingInterval = TimeSpan.FromSeconds(1);
            wait.Timeout = TimeSpan.FromSeconds(10);
            wait.IgnoreExceptionTypes(typeof(Exception));
           

            //driver.FindElement(By.LinkText("Create new account12345")).Click();
            ///driver.FindElement(By.XPath("//input[@value='-1']")).Click();

            wait.Until(x => x.FindElement(By.LinkText("Create new account"))).Click();

            wait.Until(x => x.FindElement(By.XPath("//input[@value='-1']"))).Click();

            string actualTitle = wait.Until(x => x.Title);
            Console.WriteLine(actualTitle);

            string actualAlertText = wait.Until(x => x.SwitchTo().Alert()).Text;
            Console.WriteLine(actualTitle);

            wait.Until(x => x.SwitchTo().Alert()).Accept();

            wait.Until(x => x.FindElement(By.XPath("")).Text == "jack");



        }
    }
}
