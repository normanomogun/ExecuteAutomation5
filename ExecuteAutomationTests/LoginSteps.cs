using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExecuteAutomation5FrameWork;
using TechTalk.SpecFlow;

namespace ExecuteAutomationTests
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage _loginPage = BrowserDriver.Create<LoginPage>();
        [Given(@"I am on login page")]
        public void GivenIAmOnLoginPage()
        {
            PageBuilder.NavigateToLoginPage();

        }

        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterAnd(string username, string password)
        {
            _loginPage.UserNametextBox.TypeText(username);
            _loginPage.PasswordtextBox.TypeText(password);

        }

        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            _loginPage.LoginButton.Submit();
        }

        [Then(@"I should be successfully logged in")]
        public void ThenIShouldBeSuccessfullyLoggedIn()
        {
            //ScenarioContext.Current.Pending();
        }

    }
}
