using AutomationFramework.Base;
using BuildConfigurator.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    public class BuildInfoModalSteps : BasePage
    {
        public BuildInfoModalSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig.CurrentPage = new BuildInfoModalPage(_parallelConfig);
        }

        [When(@"I click (.*) button from info modal")]
        public void WhenIClickAddButtonFromInfoModal(string buttonName)
        {
            if (stringContainsIgnoreCase(buttonName, "add"))
                _parallelConfig.CurrentPage.As<BuildInfoModalPage>().ClickInfoModalAddAccessoryButton();
            else if (stringContainsIgnoreCase(buttonName, "remove"))
                _parallelConfig.CurrentPage.As<BuildInfoModalPage>().ClickInfoModalRemoveAccessoryButton();
            else if (stringContainsIgnoreCase(buttonName, "close"))
                _parallelConfig.CurrentPage.As<BuildInfoModalPage>().ClickInfoModalCloseButton();
            else
                Assert.Fail("Button {0} not present in UI", buttonName);
        }

    }
}
