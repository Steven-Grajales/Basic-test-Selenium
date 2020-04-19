using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BasicTest
{
    [TestClass]
    public class SeleniumTest
    {

        [TestMethod]
        public void setup() {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:44328/login.aspx");
            Thread.Sleep(2000);

            //Ingresar al login
            driver.FindElement(By.Id("txtUserName")).SendKeys("admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("123");
            driver.FindElement(By.Id("btnlogin")).Click();
            Thread.Sleep(1000);

            //Registro de usuario
            driver.FindElement(By.Id("txtUserName")).SendKeys("Juan");
            driver.FindElement(By.Id("txtPassword")).SendKeys("951");
            driver.FindElement(By.Id("btnRegistrar")).Click();
        }
    }
}
