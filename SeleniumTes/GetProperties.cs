using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTes
{
    enum Properties
    {
        Id,
        Name,
        Text,
        LinkText,
        ClassName
    }
    class GetProperties
    {
       
        public static IWebDriver driver { get; set; }
    }
}
