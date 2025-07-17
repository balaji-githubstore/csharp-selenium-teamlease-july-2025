using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo3TabsOrWindows
    {
        static void Mains(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.db4free.net/";


            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();

            //Console.WriteLine(driver.WindowHandles);

            //Console.WriteLine(driver.WindowHandles.ElementAt(0));
            //Console.WriteLine(driver.WindowHandles[1]);

            //switch to 2nd tab
            //driver.SwitchTo().Window(driver.WindowHandles[1]);

            foreach (var sessionId in driver.WindowHandles)
            {
                driver.SwitchTo().Window(sessionId);
                if (driver.Title.Equals("phpMyAdmin"))
                {
                    break;
                }
            }

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            driver.FindElement(By.Id("input_go")).Click();

            string actualError= driver.FindElement(By.Id("pma_errors")).Text;
            Console.WriteLine(actualError);

            driver.Close();

            driver.SwitchTo().Window(driver.WindowHandles[0]);

            Console.WriteLine(driver.Title);


           


            //opens new tab
            //driver.SwitchTo().NewWindow(WindowType.Tab);
            //driver.Url = "https://gmail.com";

        }
    }
}
