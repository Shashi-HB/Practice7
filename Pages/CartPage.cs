using OpenQA.Selenium;
using Pra7.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra7.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver) { }

        private By cartItem = By.ClassName("inventory_item_name");
        private By checkoutBtn = By.Id("checkout");

        public bool IsItemDisplayed()
        {
            return driver.FindElement(cartItem).Displayed;
        }

        public void ClickCheckout()
        {
            Click(checkoutBtn);
        }
    }
}
