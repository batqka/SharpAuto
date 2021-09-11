using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProj.Drivers
{
    public class BrowserDriver : IDisposable
    {
        private readonly Lazy<IWebDriver> currentWebDriverLazy;
        private bool isDisposed;

        public BrowserDriver()
        {
            currentWebDriverLazy = new Lazy<IWebDriver>(CreateWebDriver);
        }

        public IWebDriver Current => currentWebDriverLazy.Value;


        private IWebDriver CreateWebDriver()
        {

            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return chromeDriver;
        }

        public void Dispose()
        {
            if (isDisposed)
            {
                return;
            }

            if (currentWebDriverLazy.IsValueCreated)
            {
                Current.Quit();
            }

            isDisposed = true;
        }
    }

}
