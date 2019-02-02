using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomation5FrameWork
{
    public class Button : Element
    {
        public void Submit()
        {
            WebElement.Submit();
        }
    }
}
