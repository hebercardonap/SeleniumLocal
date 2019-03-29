using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildConfigurator.Modules
{
    public class CalculatorModule : BasePage
    {
        private static By BY_PAYMENT_CALCULATOR_CONTAINER = By.XPath("//div[@class='payment-calculator__content']");
        private static By BY_MSRP_FIELD = By.XPath("//input[@id='txtMsrp']");
        private static By BY_REBATE_AMOUNT = By.XPath("//input[@id='txtRebateAmount']");
        private static By BY_DOWN_PAYMENT = By.XPath("//input[@id='txtDownPayment']");
        private static By BY_INTEREST_RATE = By.XPath("//input[@id='txtInterestRate']");
        private static By BY_LOAN_RATE = By.XPath("//input[@id='txtLoanTerm']");
        private static By BY_CALCULATE_PAYMENTS_BUTON = By.XPath("//a[contains(@class,'payment-calculator__submit')]");
        private static By BY_PYMNT_CALC_HEADER = By.XPath("//div[contains(@class,'payment-calculator')]//h2");
        private static By BY_CALC_VIRTUAL_KYB = By.XPath("//div[contains(@class,'ui-keyboard')]//button[@data-value='7']");

        public CalculatorModule(ParallelConfig parallelConfig) : base(parallelConfig)
        {
        }

        public bool IsPaymentCalculatorDisplayed()
        {
            return DriverActions.IsElementPresent(BY_PAYMENT_CALCULATOR_CONTAINER);
        }

        public void ClickMsrpField()
        {
            ClickPaymentCalculatorHeader();
            DriverActions.clickElement(BY_MSRP_FIELD);
            DriverActions.waitForAjaxRequestToComplete();
        }

        public void ClickPaymentCalculatorHeader()
        {
            DriverActions.clickElement(BY_PYMNT_CALC_HEADER);
        }

        public bool IsCalcVirtualKeyboardDisplayed()
        {
            DriverActions.waitForElementVisibleAndEnabled(BY_CALC_VIRTUAL_KYB);
            return DriverActions.IsElementPresent(BY_CALC_VIRTUAL_KYB);
        }
    }
}
