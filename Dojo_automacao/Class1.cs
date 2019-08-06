using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Dojo_automacao
{
    [TestClass]
    public class Class1
    {
        IWebDriver non;
        [TestMethod]
        public void teste()
        {
            non = new ChromeDriver();
            non.Navigate().GoToUrl("localhost:3000");
            var demoApp = non.FindElement(By.XPath("//*[@id='app']/div/div[2]/ol/li[1]/a"));
            demoApp.Click();
            var novoVeiculo = non.FindElement(By.Name("newMpg"));
            var tradeMpg = non.FindElement(By.Name("tradeMpg"));
            var newPpg = non.FindElement(By.Name("newPpg"));
            var tradePpg = non.FindElement(By.Name("tradePpg"));
            var milesDriven = non.FindElement(By.Name("milesDriven"));

            

            novoVeiculo.SendKeys("4");
            tradeMpg.SendKeys("2");
            newPpg.SendKeys("2");
            milesDriven.SendKeys("2");
            tradePpg.SendKeys("2");

            var loss = non.FindElement(By.XPath("//*[@id='app']/div/div[2]/table[2]/tbody/tr/td[2]/table/tbody/tr[2]/td[1]"));

            Assert.AreNotEqual("$0", loss.Text);





        }

        [TestMethod]
        public void validarValorAno()
        {
            non = new ChromeDriver();
            non.Navigate().GoToUrl("localhost:3000");
            var demoApp = non.FindElement(By.XPath("//*[@id='app']/div/div[2]/ol/li[1]/a"));
            demoApp.Click();
            var novoVeiculo = non.FindElement(By.Name("newMpg"));
            var tradeMpg = non.FindElement(By.Name("tradeMpg"));
            var newPpg = non.FindElement(By.Name("newPpg"));
            var tradePpg = non.FindElement(By.Name("tradePpg"));
            var milesDriven = non.FindElement(By.Name("milesDriven"));



            novoVeiculo.SendKeys("22");
            tradeMpg.SendKeys("2");
            newPpg.SendKeys("2");
            milesDriven.SendKeys("2");
            tradePpg.SendKeys("2");

            var lossMonth = non.FindElement(By.XPath("//*[@id='app']/div/div[2]/table[2]/tbody/tr/td[2]/table/tbody/tr[2]/td[1]"));
            var lossYear = non.FindElement(By.XPath("//*[@id='app']/div/div[2]/table[2]/tbody/tr/td[2]/table/tbody/tr[2]/td[2]"));

            var lossMonthNCifrao = lossMonth.Text.Replace("$", "");

            var month = Convert.ToDecimal(lossMonthNCifrao) * 12;

            var lossYearNCifrao = lossYear.Text.Replace("$", "");

            var year = Convert.ToDecimal(lossYearNCifrao);

            Assert.AreEqual(month, year);





        }




    }
}
