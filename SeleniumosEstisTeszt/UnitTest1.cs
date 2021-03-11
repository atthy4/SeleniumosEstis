using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumosEstisTeszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver dw = new FirefoxDriver();
            dw.Manage().Window.Maximize();
            dw.Navigate().GoToUrl("https://www.portfolio.hu/");
            string s = dw.Url;
            Assert.AreEqual("tukorforegep", s);
        }
    }
}
