using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.SteppedProcess
{
    [TestFixture]
    public class IndSteppedProccessTests : TestBase
    {

        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyIndSteppedProcessScout()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.WaitForCategoryPageToLoad();
            BuildCategoryPage.ClickOnIndianCategory("scout");
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyIndSteppedProcessChief()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.WaitForCategoryPageToLoad();
            BuildCategoryPage.ClickOnIndianCategory("chief");
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyIndSteppedProcessSpringfield()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.WaitForCategoryPageToLoad();
            BuildCategoryPage.ClickOnIndianCategory("springfield");
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyIndSteppedProcessChieftain()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.WaitForCategoryPageToLoad();
            BuildCategoryPage.ClickOnIndianCategory("chieftain");
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyIndSteppedProcessRoadmaster()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.WaitForCategoryPageToLoad();
            BuildCategoryPage.ClickOnIndianCategory("roadmaster");
            CompleteSteppedProcessAndValidate();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.STEPPED_PROCESS), CustomRetry(3)]
        public void VerifyIndSteppedProcessDarkhorse()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.IND);
            BuildCategoryPage.WaitForCategoryPageToLoad();
            BuildCategoryPage.ClickOnIndianCategory("dark horse");
            CompleteSteppedProcessAndValidate();
        }

        private void CompleteSteppedProcessAndValidate()
        {
            BuildModelPage.ClickRandomModel();
            BuildColorPage.WaitForColorPageToLoad();
            BuildColorPage.ClickColor();
            BuildColorPage.ClickNextButton();
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Engine");
            BuildConfigurePage.ClickAccessorySubCategory("Intake");
            BuildConfigurePage.ClickRandomAccessoryCardAddButton();
            BuildConfigurePage.ClickIamFinishedButton();
            BuildQuotePage.WaitForBuildQuotePgeToLoad();
            BuildQuotePage.FillQuoteFormDefaultData();
            BuildQuotePage.ClickGetInternetPriceButton();
            BuildConfirmationPage.WaitForBuildConfirmationPageToLoad();
            BuildConfirmationPage.VerifyBuildconfirmationPageIsAsExpected();
        }
    }
}
