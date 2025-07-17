using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo8JS
    {
        static void Main77(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);

            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.malaysiaairlines.com/us/en/home.html";


            driver.FindElement(By.XPath("//span[text()='Accept all cookies']")).Click();

            //div[@id='book-flight']//input[@aria-label='From']

            //approach 1 - not working
            //driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateDeparture']")).SendKeys("06 Aug 2025");

            //approach 2 - automating calendar 

            //approach 3 - Js 
            driver.ExecuteJavaScript("document.querySelector(\"div[id='book-flight'] input[name='dateDeparture']\").value='22 Aug 2025'");

            driver.ExecuteJavaScript("document.querySelector(\"div[id='book-flight'] input[name='dateReturn']\").value='28 Sep 2025'");

            //approach 4 - Js and webelement 

            IWebElement ele1= driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateDeparture']"));
            IWebElement ele2 = driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateReturn']"));

            driver.ExecuteJavaScript("arguments[0].value='23 Aug 2025'",ele1);
            driver.ExecuteJavaScript("arguments[0].value='29 Sep 2025'", ele2);


            //below not recommended
            //driver.ExecuteJavaScript("arguments[0].value='23 Aug 2025';arguments[1].value='29 Sep 2025'", ele1,ele2);

            string actualDepDate=driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateDeparture']")).GetAttribute("value");
            Console.WriteLine(actualDepDate);

            string actualPlaceholder = driver.FindElement(By.XPath("//div[@id='book-flight']//input[@name='dateDeparture']")).GetAttribute("aria-placeholder");
            Console.WriteLine(actualPlaceholder);


            string output=driver.ExecuteJavaScript<string>("return document.querySelector(\"div[id='book-flight'] input[name='dateDeparture']\").value");
            Console.WriteLine(output);

            //document.querySelectorAll("#main>svg")[0].textContent
        }
    }
}
