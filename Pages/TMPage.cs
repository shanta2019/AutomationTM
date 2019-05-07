using AutomationTM.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTM.Pages
{
    class TMPage
    {
        

        public void CreateTM()
        {
            //Click on "Create New" button
            IWebElement CreateNew = CommonDriver.driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNew.Click();

            //Click on TypeCode 
            IWebElement TypeCodeMenu = CommonDriver.driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            TypeCodeMenu.Click();

            //To change Material to Time
            IWebElement timeLink = CommonDriver.driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timeLink.Click();

            // enter the Code:18.05 in the text box Code
            IWebElement Codetextbox = CommonDriver.driver.FindElement(By.XPath("//*[@id='Code']"));
            Codetextbox.SendKeys("18.05");

            //to chek user is able to put all the combinatins and max word in description
            IWebElement Descriptiontextbox = CommonDriver.driver.FindElement(By.XPath("//*[@id='Description']"));
            Descriptiontextbox.SendKeys("123456789abcd");

            // to check if user is able to enter price per unit
            IWebElement PricePerUnit = CommonDriver.driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            PricePerUnit.SendKeys("123");

            //To check if user is able to access the fiels from the system
            IWebElement Selectfiles = CommonDriver.driver.FindElement(By.XPath("//*[@id='files']"));
            Selectfiles.SendKeys("C://Users/pravi_000/Documents");

            //to check if user is abel to save the record
            IWebElement SaveButton = CommonDriver.driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SaveButton.Click();

            //Assert.That(helloHomepage.Text, Is.EqualTo("Hello hari!"));

            //To Verify if record is saved
            Thread.Sleep(1000);
            IWebElement LastPage = CommonDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(1000);
            IWebElement savedrecord = CommonDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[1]"));
            Thread.Sleep(1000);
            if (savedrecord.Text == "18.05")
            {
                Console.WriteLine("Record saved successfully");
            }
            else
            {
                Console.WriteLine("Recocrd not saved");
            }





        }
        public void EditTM()
        {
            // To Check if user is abel to edit any existing record
            IWebElement editbutton = CommonDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            editbutton.Click();

            //To check if user is able to edit Typecode textbox
            IWebElement TypeCode = CommonDriver.driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/label"));
            TypeCode.Click();


            //To Ckheck if user is able to edit the Typecode from  Time to Material
            IWebElement TimeLink = CommonDriver.driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            Thread.Sleep(1000);
            TimeLink.Click();

            //To check if user is able to edit the code 
            IWebElement CodeTextBox = CommonDriver.driver.FindElement(By.XPath("//*[@id='Code']"));
            CodeTextBox.Clear();
            CodeTextBox.SendKeys("007");

            //To check if user is able to edit the code
            IWebElement DescriptionText = CommonDriver.driver.FindElement(By.XPath("//*[@id='Description']"));
            DescriptionText.Clear();
            DescriptionText.SendKeys("abcd007");

            //To check if user is able to edit the price per unit
            //IWebElement PriceText = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            //Thread.Sleep(1000);
            //PriceText.Clear();
            //PriceText.SendKeys("1234");

            //To check if user can save the edited record
            IWebElement SaveTextButton = CommonDriver.driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            SaveTextButton.Click();

            //To verify if Edited record is saved Successfrlly
            Thread.Sleep(1000);
            IWebElement EditedRecord = CommonDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]"));
            Thread.Sleep(1000);
            if (EditedRecord.Text == "007")
            {
                Console.WriteLine("Edited Record saved successfully Test Passed");
            }
            else
            {
                Console.WriteLine("Edited Recorrd not saved Test Failed");
            }

            

        }

        public void DeleteTM()
        {
            //To check if user is able to Delete the existing record
            IWebElement DeletButton = CommonDriver.driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[2]"));
            DeletButton.Click();
            CommonDriver.driver.SwitchTo().Alert().Accept();


        }

        



















        
    }
}
