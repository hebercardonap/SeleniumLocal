using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.ApiUtils.Contracts
{
    public class CpqPreselect
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public PriceContainer Pricing { get; set; }
        public string ImageUrl { get; set; }
        public string PolarisProductId { get; set; }
        public string MTOFeatureID { get; set; }
        public string FOOptionId { get; set; }
        public bool IsMTO { get; set; }
        public bool IsFactoryInstalled { get; set; }
        public int SortOrder { get; set; }
        public bool IsFeatureAndOption { get; set; }
        public bool DoNotShowOnWholegood { get; set; }
        public bool IsDefaultFeatureAndOption { get; set; }
        public string ParentContentReference { get; set; }
        public string Id { get; set; }
    }
}
