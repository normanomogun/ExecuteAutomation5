using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ExecuteAutomation5FrameWork
{
    public class Finder
    {
        private IWebDriver _driver;

        public Finder(IWebDriver driver)
        {
            _driver = driver;
        }

        private T Find<T>(By locator) where T : Element, new()
        {
            var element = new T();
            element.SetElement(_driver.FindElement(locator));
            return element;

        }

        private IEnumerable<T> FindAll<T>(By locator) where T : Element, new()
        {
            List<T> listOfElements = new List<T>();
            var elements = _driver.FindElements(locator);
            foreach (var webElement in elements)
            {
                var element = new T();
                element.SetElement(webElement);
                listOfElements.Add(element);
            }

            return listOfElements;
        }

        public T ById<T>(string id) where T : Element, new()
        {
            return Find<T>(By.Id(id));
        }

        public T CssSelector<T>(string cssSelector) where T : Element, new()
        {
            return Find<T>(By.CssSelector(cssSelector));
        }
    }
}
