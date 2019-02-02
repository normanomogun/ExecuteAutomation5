using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExecuteAutomation5FrameWork
{
    public class BrowserDriver
    {
        private static IWebDriver _driver;
        private static string baseUrl = @"http://www.executeautomation.com/demosite/Login.html";

        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            Instance = _driver;
        }

        public static void NavigateTo(string page = null)
        {
            Instance.Navigate().GoToUrl(baseUrl+page);
        }

        public static T Create<T>() where T : BasePage, new()
        {
            var page = new T();
            return page;
        }

        public static void ShutDown()
        {
            Instance.Close();
            Instance.Dispose();
        }
        
    }
}
