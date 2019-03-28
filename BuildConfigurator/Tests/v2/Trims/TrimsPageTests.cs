using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.Trims
{
    [TestFixture]
    public class TrimsPageTests : TestBase
    {

        //[Test, Category(TestCategories.RZR), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifyTrimsNotDuplicateRzr()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            BuildModelPage.ClickOneSeat();
            BuildTrimPage.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickTwoSeat();
            BuildModelPage.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickFourSeat();
            BuildModelPage.ClickEachModelAndVerifyTrimsAreNotDuplicate();
        }

        //[Test, Category(TestCategories.ATV), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifyTrimsNotDuplicateAtv()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            BuildModelPage.ClickOneSeat();
            BuildTrimPage.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickTwoSeat();
            BuildModelPage.ClickEachModelAndVerifyTrimsAreNotDuplicate();
        }

        //[Test, Category(TestCategories.GEN), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifyTrimsNotDuplicateGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            BuildModelPage.ClickTwoSeat();
            BuildTrimPage.ClickEachModelAndVerifyTrimsAreNotDuplicate();
            BuildModelPage.ClickSelectSeatsDropdown();
            BuildModelPage.ClickFourSeat();
            BuildModelPage.ClickEachModelAndVerifyTrimsAreNotDuplicate();
        }

        //[Test, Category(TestCategories.RZR), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifySeeSpecsLinkRzr()
        {
            CPQNavigate.NavigateToModelsPage(Brand.RZR);
            ClickRandomModeTrimSeeSpecsLinkAndVerify();

        }

        //[Test, Category(TestCategories.ATV), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifySeeSpecsLinkAtv()
        {
            CPQNavigate.NavigateToModelsPage(Brand.ATV);
            ClickRandomModeTrimSeeSpecsLinkAndVerify();

        }

        //[Test, Category(TestCategories.GEN), Category(TestCategories.TRIMS_PAGE), RetryDynamic]
        //[Ignore("Brand running CPQ v3 version")]
        public void VerifySeeSpecsLinkGen()
        {
            CPQNavigate.NavigateToModelsPage(Brand.GEN);
            ClickRandomModeTrimSeeSpecsLinkAndVerify();

        }

        private void ClickRandomModeTrimSeeSpecsLinkAndVerify()
        {
            BuildModelPage.WaitForBuildModelPageToLoad();
            BuildModelPage.SelectRandomSeatOption();
            BuildModelPage.ClickRandomModel();
            BuildTrimPage.ClickRandomSeeSpecsLink();
            Assert.IsTrue(BuildTrimPage.IsSeeSpecsModalDisplayed());
        }
    }
}
