using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFirst;

namespace SeleniumFirst
{
    class MainClass
    {
       


        public static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialise()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //Navigate to Google page
            //PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?Username=&Password=&Login=Login");
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Open URL");
        }


        [Test]
        public void ExecuteTest()
        {

            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");
            pageEA.FillUserForm("KK", "Karthik","Automation");


            //Initialized the page by calling reference
            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("executeautomation");
            page.btnSave.Click();



            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            ////Initials
            //SeleniumSetMethods.EnterText("Initial","executeautomation",PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText( "TitleID", PropertyType.Id));
            //Console.WriteLine("The value from my initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////Click
            //SeleniumSetMethods.Click("Save",PropertyType.Name);




        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine();
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }

    }
}
