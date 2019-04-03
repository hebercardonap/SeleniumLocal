using AutomationFramework.DataProvider;
using AutomationFramework.Helpers;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Hooks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Tests.v3.PageRedirect
{
    [TestFixture]
    public class PageRedirectTests : TestBase
    {
        [Test, Category(TestCategories.PAGE_REDIRECTS), RetryDynamic]
        public void VerifyQuotePageRedirectsToHomeNoSubmissionId()
        {
            CPQNavigate.NavigateToQuoteDefaultPage();
            Assert.AreEqual(CPQNavigate.GetCurrentUrl(), UrlBuilder.getRzrBuildModelUrl());
        }
    }
}
