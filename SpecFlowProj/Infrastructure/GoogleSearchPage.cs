using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProj.Infrastructure
{
    class GoogleSearchPage
    {
        private const string Url = "https://www.google.com/";
        private readonly IWebDriver Driver;
        public const int DefaultWaitInSeconds = 5;

        public GoogleSearchPage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebElement SearchField => Driver.FindElement(By.XPath(@"//input[@name=""q""]"));
        private IWebElement SearchButton => Driver.FindElement(By.XPath(@"//form/div/div/div/center/input[@name=""btnK""]"));
        private IWebElement ResultStats => Driver.FindElement(By.Id("result-stats"));

        public void OpenGoogleComPage()
        {
            Driver.Url = Url;
        }

        public void EnterTextInSearchField(string text)
        {
            SearchField.SendKeys(text);
        }

        public void ClickSearchButton()
        {
            SearchButton.Click();
        }

        public bool IsResultStatsExist()
        {
            if (ResultStats.Displayed)
            {
                return true;
            }
            else return false;
        }

    }

}
