using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System;
using System.Linq;

namespace SortingCheckPageTest
{
    [TestFixture]

    public class Tests : BaseClass
    {
        [Test]
        public void Test1()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);
            MagazinePageObject magazine = new MagazinePageObject(driver);
            mainMenu.ClickElement();
            var actualSortDate = magazine.GetListsNewsDates().ToList();
            var expectedSortDate = actualSortDate.OrderByDescending(x => x);
            Assert.IsTrue(expectedSortDate.SequenceEqual(actualSortDate), "The sort date is wrong");
        }
    }
}