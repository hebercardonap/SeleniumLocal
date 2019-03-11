using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.SnowCheck
{
    [TestFixture]
    public class SnowCheckDataTests : TestBase
    {
        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifySubstepOptionsNotDuplicate()
        {
            string snowCheckUrl = Options.GetNonStockSnowcheckColorPage();
            CPQNavigate.GoToUrl(snowCheckUrl);
            Colors.WaitForChooseColorTitleToDisplay();

            while (Colors.IsStockModelInfoDisplayed())
            {
                snowCheckUrl = Options.GetNonStockSnowcheckColorPage();
                CPQNavigate.GoToUrl(snowCheckUrl);
                Colors.WaitForChooseColorTitleToDisplay();
            }
            Colors.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Starter"));
            Options.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Windshield"));
            Options.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Handlebar"));
            Options.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Shocks"));
            Options.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Gauge"));
        }

        [Test, Category(TestCategories.SNOWCHECK)]
        public void VerifySledsOptionsNotDuplicate()
        {
            CPQNavigate.NavigateToCategoryPage(Brand.SNO);
            Category.ClickRandomWholegoodModelCard();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Trim"));
            Options.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Engine"));
            Options.FooterModule.ClickFooterNextButton();
            Assert.IsTrue(Options.VerifySubstepListOptionsNotDuplicate("Track"));
        }
    }
}
