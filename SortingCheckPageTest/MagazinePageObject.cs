using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SortingCheckPageTest
{
    class MagazinePageObject
    {
        IWebDriver driver;

        private readonly By _allTheDateNews = By.XPath("//span[@itemprop='datePublished']");

        public MagazinePageObject(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public IEnumerable<DateTime> GetListsNewsDates()
        {
            var tableColumnData_ = driver.FindElements(_allTheDateNews);
            IEnumerable<DateTime> f = tableColumnData_.Select(x => DateTime.Parse(x.Text));

            return f;
        }

    }
}
