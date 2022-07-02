using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_WebDriver.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver { get; }
        public LoginPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }


        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));

        //Assertion
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));

        IWebElement btnLogin =>    Driver.FindElement(By.XPath("//input[@value='Log in']"));


        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }

    }
}
