using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTes
{
    class SeleniumTest
    {
        // Enter text method
        public static void EnterText(IWebDriver driver, string element, string value, Properties elementType)
        {
            if (elementType == Properties.Id)
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == Properties.Name)
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public static void Click(IWebDriver driver, string element, Properties elementType)
        {
            if (elementType == Properties.Id)
                driver.FindElement(By.Id(element)).Click();
            if (elementType == Properties.Name)
                driver.FindElement(By.Name(element)).Click();
        }

        public static void Select(IWebDriver driver, string element, string value, Properties elementType)
        {
            if (elementType == Properties.Id)
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == Properties.Name)
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
