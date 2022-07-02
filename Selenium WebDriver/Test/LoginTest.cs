using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_WebDriver.Pages;

namespace Selenium_WebDriver.Test
{
    public class LoginTest
    {
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Test]
        public void Login()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("mulu2022", "Mulu2022!");

            Assert.That(homePage.IsEmployeeListExist, Is.True);
        }
        [TearDown]
        public void TearDown() => webDriver.Quit();
    }
}
