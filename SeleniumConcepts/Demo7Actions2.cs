using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo7
    {
        static void Main11(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.google.com/";

            Actions actions=new Actions(driver,TimeSpan.FromMilliseconds(1000));
            actions.Click(driver.FindElement(By.Name("q"))).KeyDown(Keys.Shift).SendKeys("hello world").KeyUp(Keys.Shift).Pause(TimeSpan.FromMilliseconds(1000))
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromMilliseconds(1000))
                .SendKeys(Keys.Enter)
                .Perform();

          
        }
    }
}
