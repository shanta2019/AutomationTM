using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTM.Pages
{
    class LogInPage
    {
        

        public void LogInSteps()
        {
           

            //launch chromrdriver
            IWebDriver driver = new ChromeDriver();

            //launch url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //enter valid username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");

            //enter valid password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //verify if your on home page
            //go to home page
            //identify 'hello hari
            driver.Manage().Window.Maximize();
            IWebElement HelloHomePage = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (HelloHomePage.Text == "Hello hari!")
            {
                Console.WriteLine("Hello Hari Displayed Test pass");
            }
            else
            {
                Console.WriteLine("Hello Hari Not Displayed Test Failed");
            }
        }
    }
}
