using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using System;
using WebDriverManager.DriverConfigs.Impl;

namespace QNA_Integration_Tests
{
    [TestClass]
    public class EdgeDriverTest
    {
        // In order to run the below test(s), 
        // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
        // to install Microsoft WebDriver.

        private ChromeDriver _driver;
        private string testUrl = "http://localhost:5000/";

        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            // Initialize edge driver 
            var options = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal,
                AcceptInsecureCertificates = true
            };

            _driver = new ChromeDriver(options);
        }
             
        [TestMethod]
        [DataRow("Business")]
        public void CreateCategory( string Category) {

            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(testUrl + "Categories/Create");
            // _driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(3));

             var x = _driver.FindElementById("Category");

            //var x = _driver.FindElement(By.CssSelector("input.Category"));

                 x.SendKeys(Category);

            //Act

            // _driver.FindElement(By.CssSelector("input.btn btn-primary")).Click;

            _driver.FindElementById("CategoryCreate").Click();

        
        }

        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            _driver.Quit();
        }

    }

    
    
}
