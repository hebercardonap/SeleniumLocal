using AutomationFramework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator
{
    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        [BeforeScenario]
        public static void TestInitialize()
        {
            InitializeSettings();
        }

        [AfterScenario]
        public void TestCleanUp()
        {
            DriverContext.Driver.Quit();
        }
    }
}
