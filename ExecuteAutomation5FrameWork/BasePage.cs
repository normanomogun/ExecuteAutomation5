using OpenQA.Selenium;

namespace ExecuteAutomation5FrameWork
{
    public class BasePage
    {
        private IWebDriver _driver;
        public BasePage()
        {
            _driver = BrowserDriver.Instance;
        }

        public Finder FindElement()
        {
            return new Finder(_driver);
        }

        public Finder FindElements()
        {
            return new Finder(_driver);
        }
    }
}