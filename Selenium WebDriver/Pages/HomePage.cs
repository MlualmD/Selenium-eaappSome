using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_WebDriver.Pages
{
    public class HomePage
    {
        private IWebDriver Driver { get; }
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        public IWebElement LnkLogin => Driver.FindElement(By.LinkText("Login"));

        public IWebElement LnkEmployeeList => Driver.FindElement(By.LinkText("Employee List"));

        public void ClickLogin() => LnkLogin.Click();

        public bool IsEmployeeListExist() => LnkEmployeeList.Displayed;



    }
}
