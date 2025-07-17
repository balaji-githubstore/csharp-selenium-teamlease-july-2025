using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo9
    {
        static void Mainrr(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.salesforce.com/in/form/signup/sales-ee/";


            //driver.ExecuteJavaScript
            //    ("document.querySelector(\"page-builder-miaw-ui[deployment-dev-name='page_builder_miaw_ui']\").shadowRoot.querySelector(\"button[aria-label='Minimize Agentforce']\").click()");

            
            var pageBuilderShadowRoot= driver.FindElement(By.CssSelector("page-builder-miaw-ui[deployment-dev-name='page_builder_miaw_ui']")).GetShadowRoot();
            pageBuilderShadowRoot.FindElement(By.CssSelector("button[aria-label='Minimize Agentforce']")).Click();

            var shadowRoot1= driver.FindElement(By.XPath("//global-login[contains(@class,'login-vertical-center')]")).GetShadowRoot();

            var shadowRoot2 = shadowRoot1.FindElement(By.CssSelector("create-account")).GetShadowRoot();
            var shadowRoot3= shadowRoot2.FindElement(By.CssSelector("input-text [class=\"hydrated\"]")).GetShadowRoot();
            shadowRoot3.FindElement(By.CssSelector("#input-text-lastName")).SendKeys("hello");



        }
    }
}