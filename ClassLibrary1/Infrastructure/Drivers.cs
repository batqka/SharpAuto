using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TechnicalAssessment
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

            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var chromeOptions = new ChromeOptions();
            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);

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
