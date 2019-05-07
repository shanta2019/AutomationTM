using AutomationTM.Helpers;
using AutomationTM.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using NUnit.Framework;

namespace AutomationTM
{
    [TestFixture]
    class Program
    {
        
        static void Main(string[] args)
        {

                     
                        

        }
        [SetUp]
        public void LogInPage()
        {
            CommonDriver.driver = new ChromeDriver();

            //login page object and loin into TM page
            LogInPage logintm = new Pages.LogInPage();
            logintm.LogInSteps();

            //HomePage object and navigate to TM page
            HomePage homepagetm = new HomePage();
            homepagetm.NavigateTM();

        }
        [Test]
        public void CreateTM()
        {
            //TMpage object and create TM
            TMPage createtm = new TMPage();
            createtm.CreateTM();

        }
        [Test]
        public void EditTM()
        {

            //TMpage object and Edit Tm page
            TMPage edittm = new TMPage();
            edittm.EditTM();


        }
        [Test]
        public void DeleteTM()
        {
            //TMPage page object and delete Tmpage
            TMPage deletetm = new TMPage();
            deletetm.DeleteTM();
                        
        }
        [TearDown]
        public void closedriver()
        {
            CommonDriver.driver.Close();
        }










    }
}

