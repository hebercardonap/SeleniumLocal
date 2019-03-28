using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v2.PartRequiresPart
{
    [TestFixture]
    [Ignore("Brand running CPQ v3 version")]
    public class GemPartRequiresPartTests : TestBase
    {
        //[Test, Category(TestCategories.GEM), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPartRequiresPartTriggeredGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Exterior");
            BuildConfigurePage.ClickAccessorySubCategory("Roof");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Solar Panel");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was not triggered");

        }

        //[Ignore("As per GEM rules file recently updated, there is no conflict to be replicated")]
        //[Test, Category(TestCategories.GEM), Category(TestCategories.PART_REQUIRES_PART), RetryDynamic]
        public void VerifyPrpPersistsAfterConflictGem()
        {
            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, ModelPageUrl.GEM_EL_XD_PRP);
            BuildConfigurePage.WaitForBuildPageToLoad();
            BuildConfigurePage.ClickAccessoryCategory("Exterior");
            BuildConfigurePage.ClickAccessorySubCategory("Bumper");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Rear Bumper Set");
            BuildConfigurePage.ClickAccessoryCategory("Rear Carrier Options");
            BuildConfigurePage.ClickAccessorySubCategory("Bed");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Bed with Hinged Tailgate");
            Assert.IsTrue(BuildConfigurePage.IsConflictContainerDisplayed());
            BuildConfigurePage.ClickRemoveLinkByProductIdConflictContainer("0752964");
            BuildConfigurePage.ClickAccessoryCategory("Exterior");
            BuildConfigurePage.ClickAccessorySubCategory("Roof");
            BuildConfigurePage.ClickSpecificAccessoryCardAddButton("Solar Panel");
            Assert.IsTrue(BuildConfigurePage.IsPRPHeaderDisplayed(), "Part Requires Part was not triggered");

        }
    }
}
