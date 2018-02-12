using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace visual_c_sharp_practice
{
    [TestFixture]
    public class AutomationCore
    {

        IWebDriver driver;

        [SetUp]
        public void startTest()
        {
            
            driver = new ChromeDriver();
            driver.Url = "http://blog.testproject.io/";
        }

        [TearDown]
        public void endtest()
        {
            driver.Quit();
        }
        [Test]
        public void blogTest()
        {
            NUnit.Framework.Assert.IsTrue(driver.Url.Contains("asdfasfd"));
        }
    }
}
