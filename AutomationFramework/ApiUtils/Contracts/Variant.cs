using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.ApiUtils.Contracts
{
    public class Variant
    {
        public string Edition { get; set; }
        public string BadgeText { get; set; }
        public PriceContainer Price { get; set; }
        public string ModelID { get; set; }
        public string[] AltModelIDs { get; set; }
        public string ModelYear { get; set; }
        public string WholegoodId { get; set; }
        public string SiteWholegoodParentProduct { get; set; }
        public string[] CpqCategoryExcludes { get; set; }
        public string[] CpqPreselect { get; set; }
        public string WholegoodMarketingName { get; set; }
        public string WholegoodNameHeading { get; set; }
        public string WholegoodNameSubheading { get; set; }
        public string SEOName { get; set; }
        public string SEOColor { get; set; }
        public string SEODescription { get; set; }
        public string Description { get; set; }
        public int SeatingCapacity { get; set; }
        public string WholegoodFamily { get; set; }
        public string OverviewPageURL { get; set; }
        public string WholegoodImageUrl { get; set; }
        public string ColorSwatchImageUrl { get; set; }
        public string ImagePath { get; set; }
        public string Features { get; set; }
        public string Slug { get; set; }
        public string ColorThumbnailPath { get; set; }
        public string BuildURL { get; set; }
        public string[] CategoryNames { get; set; }
        public float FreightPrice { get; set; }
        public bool IsSnowCheck { get; set; }
        public string SnowCheckMessage { get; set; }
        public string Id { get; set; }
    }
}
