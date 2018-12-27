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
using TechTalk.SpecFlow;

namespace BuildConfigurator.Steps.v3
{
    [Binding]
    public class ExtendedConfiguratorSteps : BasePage
    {
        public ExtendedConfiguratorSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        [Given(@"I have navigated to (.*) models page")]
        public void GivenIHaveNavigatedToModelsPage(string brandName)
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
