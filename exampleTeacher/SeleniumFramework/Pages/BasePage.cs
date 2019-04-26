using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumFramework.Pages
{
    public class BasePage
    {
        public RemoteWebDriver webDriver;
        public string baseUrl;

        public BasePage()
        {
            webDriver = (RemoteWebDriver)ScenarioContext.Current["webDriver"];
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        public string GetElementText(By element)
        {
            string title = webDriver.FindElement(element).Text;
            return title; 
        }

        public void waitForLocator(By locator)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromMinutes(1));
            wait.Until(webDriver => webDriver.FindElement(locator).Displayed);
        }
         
        public void selectComboboxText (By locator, String location)
        {
            webDriver.FindElement(locator).Click();
            new Actions(webDriver).SendKeys(location).Perform();
            new Actions(webDriver).SendKeys(Keys.Enter).Perform();
        }
        public void Navigate(string url)
        {
            webDriver.Navigate().GoToUrl(url);
            baseUrl = url;

        }

        public void ClickOn(By locator)
        {
            webDriver.FindElement(locator).Click();
        }

        public void SendKeysOn(By locator, String text)
        {
            webDriver.FindElement(locator).SendKeys(text);
        }
        public string GetTitle()
        {
           string title = webDriver.Title;
            return title;
        }
        public void CompareElementToString(By element, string text)
        {
           string elementText = GetElementText(element);
           Assert.AreEqual(elementText, text);
        }

        public void ComparePageTitleToString(string title, string text)
        {
            Assert.AreEqual(title, text);
        }

        public bool ElementIsDisplayed(By locator)
        {
            return webDriver.FindElement(locator).Displayed;
        } 
        public void MouseOverElement(By locator)
        {
            IWebElement newLocator = webDriver.FindElement(locator);
            new Actions(webDriver).MoveToElement(newLocator).Perform();
        }
        public void RadioButtn(By locator)
        {
            //localiza el primer radio por id
            IWebElement newLocator = webDriver.FindElement(locator);
            new Actions(webDriver).Click(newLocator).Perform();
          
        }

        //public void Clear(By locator)
        //{
        //    IWebElement newLocator = webDriver.FindElement(locator);
        //    webDriver.FindElement(By.Id("")).Clear(); 
        //}

  

    }
}
