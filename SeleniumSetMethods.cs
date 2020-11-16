using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFirst;


namespace SeleniumFirst
{
    public class SeleniumSetMethods 
    {
        //Enter Text
        public static void EnterText(IWebElement element, String value)
        {
            element.SendKeys(value);

        }

        //Click into a button, checkbox, option etc
        public static void Click(IWebElement element)

        {
            element.Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebElement element, String value)
        {

            new SelectElement(element).SelectByText(value);
           
        }
    }
}
