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
    class MainMenuPageObject
    {
        IWebDriver driver;

        private readonly By _allTheTimeNews = By.XPath("//span[@itemprop='datePublished']");
        private readonly By _rentButton = By.XPath("//a[@class='_25d45facb5--link--rqF9a']");
        private readonly By _magazineButton = By.XPath("//a[@href='https://orekhovo-zuyevo.cian.ru/magazine/']");

        public MainMenuPageObject(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public void ClickElement()
        {
            var rentBy = driver.FindElement(_rentButton);
            Actions builder = new Actions(driver);
            builder.MoveToElement(rentBy).Perform();
            Thread.Sleep(1000);
            //var magazineBy = driver.FindElement(_magazineButton);
            //magazineBy.Click();
            //Thread.Sleep(1000);
        }

        public void GetListsNewsTime()
        {
            //return driver
            //.FindElement(_allTheTimeNews).First(x => DateTime.Parse(x.Text));
            //var cells = driver.FindElements(_allTheTimeNews);
            //Assert.IsTrue(cells.OrderBy(c => c.Text).SequenceEqual(cells));
            IList<IWebElement> tableColumnData = driver.FindElements(_allTheTimeNews);
            tableColumnData.OrderBy(t => DateTime.Parse(t.Text)).ToList();
        }
    }
}
