using AutomationFramework.Base;
using AutomationFramework.UrlBuilderSites;
using AutomationFramework.Utils;
using BuildConfigurator.Pages.v3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.TestBases
{
    public class CpqUrlTestBase : BasePage
    {
        public CpqUrlTestBase(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public void NavigateToModelsPage(string brandName)
        {
            if (stringEqualsIgnoreCase(brandName, Brand.RAN))
            {
                GoToUrl(UrlBuilder.getRangerBuildModelUrl());
                _parallelConfig.CurrentPage = new ModelsPage(_parallelConfig);
            }
            else
                Assert.Fail("Brand {0} not supported", brandName);
        }
    }
}
