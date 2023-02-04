using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SortingCheckPageTest
{
    public class BaseClass
    {
        protected static IWebDriver driver;

        [OneTimeSetUp]
        protected void DoBeforeAllTheTests()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
        }

        [SetUp]
        protected void DoBeforeEach()
        {
            driver.Navigate().GoToUrl(TestSettings.HostPrefix);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        protected void DoAfterEach()
        {
            driver.Quit();
        }
    }
}
