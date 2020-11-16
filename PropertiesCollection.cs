using System;
using OpenQA.Selenium;

namespace SeleniumFirst
{

    public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }

    public class PropertiesCollection
    {
        //Auto-implemented property

        public static IWebDriver driver { get; set; }
    }
}
