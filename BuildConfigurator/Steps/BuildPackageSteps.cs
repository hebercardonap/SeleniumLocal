using AutomationFramework.Base;
using BuildConfigurator.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps
{
    [Binding]
    public class BuildPackageSteps : BuildPackagePage
    {
        public BuildPackageSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        [When(@"I get to build package page")]
        public void GivenIGetToBuildPackagePage()
        {
            _parallelConfig.CurrentPage.As<BuildPackagePage>().WaitForBuildPageToLoad();
            _parallelConfig.CurrentPage.As<BuildPackagePage>().HeaderModule.WaitForHeaderToBeDisplayed();
            _parallelConfig.CurrentPage.As<BuildPackagePage>().HeaderModule.WaitForCloseIconToBeEnabled();
        }

        [When(@"Model (.*) is displayed build package header")]
        public void GivenModelIsDisplayedBuildPackageHeader(string model)
        {
            Assert.IsTrue(_parallelConfig.CurrentPage.As<BuildPackagePage>().HeaderModule.IsNavigationBarBrandNameDisplayed());
            Assert.IsTrue(stringContainsIgnoreCase(_parallelConfig.CurrentPage.As<BuildPackagePage>().HeaderModule.GetHeaderBrandName(),
                model));
        }

        [When(@"I click close icon from build package header")]
        public void WhenIClickCloseIconFromBuildPackageNavigationBar()
        {
            _parallelConfig.CurrentPage.As<BuildPackagePage>().HeaderModule.ClickHeaderCloseIcon();
        }

    }
}
