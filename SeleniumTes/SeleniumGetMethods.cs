using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTes
{
    class SeleniumGetMethods
    {
        public static string GetText(IWebDriver driver, string element, Properties elementType)
        {
            if (elementType == Properties.Id)
                driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == Properties.Name)
                driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return "";
            return "";
        }
    }
}
