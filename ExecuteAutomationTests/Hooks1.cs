using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExecuteAutomation5FrameWork;
using TechTalk.SpecFlow;

namespace ExecuteAutomationTests
{
    [Binding]
    public sealed class Hooks1
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            BrowserDriver.Initialize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BrowserDriver.ShutDown();
        }
    }
}
