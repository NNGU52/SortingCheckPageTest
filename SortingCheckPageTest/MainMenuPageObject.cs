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

        private readonly By _allTheDateNews = By.XPath("//span[@itemprop='datePublished']");
        private readonly By _rentButton = By.XPath("//a[@class='_25d45facb5--link--rqF9a']");
        private readonly By _magazineButton = By.XPath("//span[@data-testid='dropdown_link_icon']");

        public MainMenuPageObject(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // явное ожидание 
        public void WaitElement(By locator)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out that app in specific location: {locator}", ex);
            }
        }

        public void ClickElement()
        {
            var rentBy = driver.FindElement(_rentButton);
            Actions builder = new Actions(driver);
            builder.MoveToElement(rentBy).Perform();
            WaitElement(_magazineButton);
            var magazineBy = driver.FindElement(_magazineButton);
            magazineBy.Click();
        }

        public IEnumerable<DateTime> GetListsNewsDates()
        {
            var tableColumnData_ = driver.FindElements(_allTheDateNews);
            IEnumerable<DateTime> f = tableColumnData_.Select(x => DateTime.Parse(x.Text));

            return f;
        }
    }
}
