using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    class DemoFrame
    {

        static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            //switch to frame using webelement
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));

            //switch to frame using index
            //driver.SwitchTo().Frame(0);

            //switch to frame using name or id as a string
            //driver.SwitchTo().Frame("login_page");

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("john123");

            //click on continue 

            //switch to main html
            driver.SwitchTo().DefaultContent();


        }
    }
}
