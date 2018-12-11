using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BDDDemo
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        public static IWebDriver driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new ChromeDriver("E:/software/A08/file/chromedriver_win32");
            driver.Url = "http://www.store.demoqa.com";
        }
        
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
                       

            driver.FindElement(By.XPath(".//*[@id='account']/a")).Click();
        }
        
        [When(@"User enter credentials")]
        public void WhenUserEnterCredentials(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            //var test = dictionary["Username"];          

            driver.FindElement(By.Id("log")).SendKeys(dictionary["Username"]);
            driver.FindElement(By.Id("pwd")).SendKeys(dictionary["Password"]);
        }
    
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            
                driver.FindElement(By.Id("login")).Click();
        }
        
        
        
        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {


            Assert.AreEqual("Your Account", driver.
                FindElement(By.TagName("h1")).GetAttribute("innerHTML"));
            //true.Equals(driver.FindElement(By.Id("header")));
            Thread.Sleep(2000);
           
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
           
            driver.FindElement(By.XPath("//*[@id='meta']/ul/li[2]/a")).Click();
            Thread.Sleep(2000);
            // ScenarioContext.Current.Pending();
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {



          true.Equals(driver.FindElement(By.Id("loginform")));
            Thread.Sleep(2000);
            
            //ScenarioContext.Current.Pending();
             driver.Quit();
        }
    }
}
