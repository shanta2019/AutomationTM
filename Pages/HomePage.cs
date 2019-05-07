using AutomationTM.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTM.Pages
{
    class HomePage
        
    {
        
        
        public void NavigateTM()
        {
            //Click on the Dropdown list of Column "Administration"
            Thread.Sleep(1000);
            IWebElement TypeCodelabel_dropdown = CommonDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Thread.Sleep(1000);
            TypeCodelabel_dropdown.Click();

            //select Time and Materials option
            CommonDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement TimeandMaterials = CommonDriver.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TimeandMaterials.Click();
        }

    }
}
