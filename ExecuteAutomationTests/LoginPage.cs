using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExecuteAutomation5FrameWork;

namespace ExecuteAutomationTests
{
    public class LoginPage : BasePage
    {
        public TextBox UserNametextBox
        {
            get { return FindElement().CssSelector<TextBox>("input[name='UserName']"); }
        }

        public TextBox PasswordtextBox
        {
            get { return FindElement().CssSelector<TextBox>("input[name='Password']"); }
        }

        public Button LoginButton
        {
            get { return FindElement().CssSelector<Button>("input[name='Login']"); }
        }
    }
}
