using AutomationFramework.Base;
using BuildConfigurator.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    class BuildConfigureSteps : BaseStep
    {
        public BuildConfigureSteps()
        {
            CurrentPage = GetInstance<BuildConfigurePage>();
        }
        [When(@"I add random accessory")]
        public void ThenIAddRandomAccessory()
        {
            CurrentPage.As<BuildConfigurePage>().clickProtectionCategory();
            CurrentPage.As<BuildConfigurePage>().clickRoofSubcategory();
            CurrentPage.As<BuildConfigurePage>().clickRandomAccessoryCardAddButton();
        }

    }
}
