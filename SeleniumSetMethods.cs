using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumFirst;


namespace SeleniumFirst
{
    public class SeleniumSetMethods 
    {
        //Enter Text
        public static void EnterText(String element, String value,PropertyType elementtype)
        {
            if(elementtype == PropertyType.Id) 
           PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);

            if (elementtype == PropertyType.Name)
            PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);

        }

        //Click into a button, checkbox, option etc
        public static void Click(String element, PropertyType elementtype)

        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();

            if (elementtype == PropertyType.Name)
               PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(String element, String value, PropertyType elementtype)
        {


            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
