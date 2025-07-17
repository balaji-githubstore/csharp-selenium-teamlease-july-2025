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
    public class Demo7Actions1
    {
        static void Maine(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://online-video-cutter.com/";

            Size size1 = driver.Manage().Window.Size;
            Console.WriteLine(size1.Width);
            Console.WriteLine(size1.Height);


            Size size2 = new Size(688, 688);
            driver.Manage().Window.Size = size2;

            Size size= driver.FindElement(By.XPath("//a[normalize-space()='Audio']")).Size;

            Console.WriteLine(size.Width);
            Console.WriteLine(size.Height);

            Point point= driver.FindElement(By.XPath("//a[normalize-space()='Audio']")).Location;
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            //mousehover on audio menu
            Actions actions =new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.XPath("//a[normalize-space()='Audio']"))).Perform();

           // actions.MoveByOffset(point.X, point.Y+10).Perform();

          //  actions.

            driver.FindElement(By.XPath("//a[contains(normalize-space(),'Change Volume')]")).Click();

            
        }
    }
}
