using OpenQA.Selenium;
using Pra7.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra7.Pages
{
    public class InventoryPage : BasePage
    {
        public InventoryPage(IWebDriver driver):base(driver) { }

        // Select inventory items' button 
        /*
         * There are multiple products on the page, so:
            This locator matches ALL “Add to Cart” buttons
            But Selenium will click the FIRST one only
            It clicks the first product’s “Add to Cart” button
         */
        private By firstAddToCart = By.CssSelector(".inventory_item button");
        private By cartIcon = By.ClassName("shopping_cart_link");

        public void AddFirstItemToCart()
        {
            Click(firstAddToCart);
        }

        public void GoToCart()
        {
            Click(cartIcon);
        }
    }
}
