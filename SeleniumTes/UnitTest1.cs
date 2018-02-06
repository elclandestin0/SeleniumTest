using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTes
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver chrome;
        static IWebElement searchBar;
        
        
        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {
            // start with options
            ChromeOptions cOptions = new ChromeOptions();
            cOptions.AddArgument("disable-infobars");
            cOptions.AddArgument("--start-maximized");
            // add options to chrome driver
            chrome = new ChromeDriver(@"D:\chromedrivers\", cOptions);
        }

        [TestMethod]
        public void GoogleTest()
        {
            // go to google
            chrome.Navigate().GoToUrl("https://www.google.com");

            // find search bar
            searchBar = chrome.FindElement(By.Id("lst-ib"));

            // execute operations on searchbar! 
            searchBar.SendKeys("Tel7as teezi");
            searchBar.SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void ExecuteAutomationTest()
        {
            chrome.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
            SeleniumTest.Select(chrome, "TitleId", "Mr.", "Id");
            SeleniumTest.EnterText(chrome, "Initial", "MK", "Id");
            SeleniumTest.EnterText(chrome, "FirstName", "Memo", "Id");
            SeleniumTest.EnterText(chrome, "MiddleName", "Khoury", "Id");
            SeleniumTest.Click(chrome, "Save", "Name");

        }

 
    }
}
