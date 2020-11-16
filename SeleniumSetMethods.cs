using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFirst;


namespace SeleniumFirst
{
    public static class SeleniumSetMethods 
    {
        //Enter Text
        //Extended method for entering text in the control
        public static void EnterText(this IWebElement element, String value)
        {
            element.SendKeys(value);

        }

        //Click into a button, checkbox, option etc
        public static void Clicks(this IWebElement element)

        {
            element.Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(this IWebElement element, String value)
        {

            new SelectElement(element).SelectByText(value);
           
        }
    }
}
