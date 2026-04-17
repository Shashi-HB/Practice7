using OpenQA.Selenium;
using Pra7.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra7.Pages
{
    public class CheckoutPage : BasePage
    {
        public CheckoutPage(IWebDriver driver) : base(driver) { }

        private By firstName = By.Id("first-name");
        private By lastName = By.Id("last-name");
        private By postalCode = By.Id("postal-code");
        private By continueBtn = By.Id("continue");

        public void FillDetails(string fName, string lName, string zip)
        {
            Type(firstName, fName);
            Type(lastName, lName);
            Type(postalCode, zip);
        }

        public void Continue()
        {
            Click(continueBtn);
        }

    }
}
