using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomation5FrameWork
{
    public class TextBox : Element
    {
        public void TypeText(string text)
        {
            WebElement.SendKeys(text);
        }
    }
}
