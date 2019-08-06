using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Dojo_automacao
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;


        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:3000/");
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }
    }
}
