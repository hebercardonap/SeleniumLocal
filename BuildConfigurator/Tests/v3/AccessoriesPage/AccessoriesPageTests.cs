using AutomationFramework.Helpers;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using BuildConfigurator.TestBases.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3
{
    [TestFixture]
    public class AccessoriesPageTests : TestBase
    {
        private static readonly string TEST_DEALER_ID = "54321";
        private static readonly string MODELS_YEAR = "2019";

        [Test, Category(TestCategories.RZR), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyAccessoriesUIRandomModelRzr()
        {
            string modelColor = ApiDataTestBase.GetRandomModelColorFromApi(Brand.RZR, MODELS_YEAR, TEST_DEALER_ID);

            CPQNavigate.NavigateToAccessoriesPage(Brand.RZR, modelColor);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.VerifyAccessoriesPageORVUIElements();
        }

        [Test, Category(TestCategories.RAN), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyAccessoriesUIRandomModelRan()
        {
            string modelColor = ApiDataTestBase.GetRandomModelColorFromApi(Brand.RAN, MODELS_YEAR, TEST_DEALER_ID);

            CPQNavigate.NavigateToAccessoriesPage(Brand.RAN, modelColor);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.VerifyAccessoriesPageORVUIElements();
        }

        [Test, Category(TestCategories.GEN), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyAccessoriesUIRandomModelGen()
        {
            string modelColor = ApiDataTestBase.GetRandomModelColorFromApi(Brand.GEN, MODELS_YEAR, TEST_DEALER_ID);

            CPQNavigate.NavigateToAccessoriesPage(Brand.GEN, modelColor);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.VerifyAccessoriesPageORVUIElements();
        }

        [Test, Category(TestCategories.ACE), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyAccessoriesUIRandomModelAce()
        {
            string modelColor = ApiDataTestBase.GetRandomModelColorFromApi(Brand.ACE, MODELS_YEAR, TEST_DEALER_ID);

            CPQNavigate.NavigateToAccessoriesPage(Brand.ACE, modelColor);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.VerifyAccessoriesPageORVUIElements();
        }

        [Test, Category(TestCategories.ATV), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyAccessoriesUIRandomModelAtv()
        {
            string modelColor = ApiDataTestBase.GetRandomModelColorFromApi(Brand.ATV, MODELS_YEAR, TEST_DEALER_ID);

            CPQNavigate.NavigateToAccessoriesPage(Brand.ATV, modelColor);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.VerifyAccessoriesPageORVUIElements();
        }

        [Test, Category(TestCategories.GEM), Category(TestCategories.ACCESSORIES_PAGE), RetryDynamic]
        public void VerifyAccessoriesUIRandomModelGem()
        {
            string modelColor = ApiDataTestBase.GetRandomModelColorFromApi(Brand.GEM, MODELS_YEAR, TEST_DEALER_ID);

            CPQNavigate.NavigateToAccessoriesPage(Brand.GEM, modelColor);
            Accessories.WaitForAccessoriesPageToLoad();
            Accessories.VerifyAccessoriesPageGEMUIElements();
        }
    }
}
