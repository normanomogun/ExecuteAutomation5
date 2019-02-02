using OpenQA.Selenium;

namespace ExecuteAutomation5FrameWork
{
    public class Element
    {
        public IWebElement WebElement { get; set; }

        public void SetElement(IWebElement element)
        {
            WebElement = element;
        }
    }
}