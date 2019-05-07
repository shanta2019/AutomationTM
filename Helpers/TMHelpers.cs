using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTM.Helpers
{
    class TMHelpers
    {
        public static void AddTM(IWebDriver driver, string Code, string Description, String price)
        {
            //Click on "Create New" button
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNew.Click();

            //Click on TypeCode 
            IWebElement TypeCodeMenu = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            TypeCodeMenu.Click();

            //To change Material to Time
            IWebElement timeLink = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeLink.Click();

            // enter the Code:18.05 in the text box Code
            IWebElement Codetextbox = driver.FindElement(By.XPath("//*[@id='Code']"));
            Codetextbox.SendKeys("Code");

            //to chek user is able to put all the combinatins and max word in description
            IWebElement Descriptiontextbox = driver.FindElement(By.XPath("//*[@id='Description']"));
            Descriptiontextbox.SendKeys("Description");

            // to check if user is able to enter price per unit
            IWebElement PricePerUnit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PricePerUnit.SendKeys("Price");

            //To check if user is able to access the fiels from the system
            IWebElement Selectfiles = driver.FindElement(By.XPath("//*[@id='files']"));
            Selectfiles.SendKeys("C://Users/pravi_000/Documents");

            //to check if user is abel to save the record
            IWebElement SaveButton = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SaveButton.Click();

            //To Verify if record is saved
            
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            LastPage.Click();
            
            IWebElement savedrecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[1]"));
            


        }







    }
}
