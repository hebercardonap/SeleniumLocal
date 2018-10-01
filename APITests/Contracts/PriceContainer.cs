using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITests.Contracts
{
    public class PriceContainer
    {

        public PriceContainer()
        {

        }
        public string CurrencyString { get; set; }
        public bool DisplayCurrency { get; set; }
        public float Price { get; set; }
        public string PriceString { get; set; }
        public float DiscountPrice { get; set; }
        public string DiscountPriceString { get; set; }
        public bool DiscountPriceAvailable { get; set; }
        public string AnalyticsPriceString { get; set; }
        public decimal[] PriceRange { get; set; }
        public string PriceRangeString { get; set; }
        public decimal[] MSRPPriceRange { get; set; }
        public string MSRPPriceRangeString { get; set; }
        public bool IsPriceRange { get; set; }
        public bool IsDiscountPriceRange { get; set; }
        public bool IsEmployeeOrMilitary { get; set; }
        public float DiscountAmount { get; set; }
        public float NetPrice { get; set; }
        public string DiscountAmountString { get; set; }
        public string PriceStringNoDecimals { get; set; }
        public string DiscountPriceStringNoDecimals { get; set; }
        public string DiscountAmountStringNoDecimals { get; set; }
    }
}
