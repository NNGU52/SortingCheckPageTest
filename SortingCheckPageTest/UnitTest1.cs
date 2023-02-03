using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System;

namespace SortingCheckPageTest
{
    [TestFixture]

    public class Tests : BaseClass
    {
        [Test]
        public void Test1()
        {
            MainMenuPageObject mainMenu = new MainMenuPageObject(driver);

            mainMenu.ClickElement();
            mainMenu.GetListsNewsTime();

        }
    }
}