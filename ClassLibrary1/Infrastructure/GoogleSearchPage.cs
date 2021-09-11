using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TechnicalAssessment.Infrastructure
{
    class GoogleSearchPage
    {
        private const string Url = "https://www.google.com/";
        private readonly IWebDriver Driver;

        public GoogleSearchPage(IWebDriver webDriver)
        {
            Driver = webDriver;
            Driver.Url = Url;
        }

        // локаторы можно выделять отдельно в будущем,
        // так как одни и теже элементы могут быть переиспользованы в разных частях проекта
        private IWebElement SearchField => Driver.FindElement(By.XPath("//input[@name=\"q\"]"));

        public void EnterTextInSearchField(string text)
        {
            SearchField.SendKeys(text);
        }
    }

}
