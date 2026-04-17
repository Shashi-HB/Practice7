using Pra7.Base;
using Pra7.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pra7.Tests
{
    public class E2ETests:BaseTest
    {
        [Test]
        public void CompletePurchaseFlow()
        {
            var login = new LoginPage(driver);
            login.Login("standard_user", "secret_sauce");

            var inventory = new InventoryPage(driver);
            inventory.AddFirstItemToCart();
            inventory.GoToCart();

            var cart = new CartPage(driver);
            //Assert.IsTrue(cart.IsItemDisplayed());
            Assert.That(cart.IsItemDisplayed(), Is.True);
            cart.ClickCheckout();

            var checkout = new CheckoutPage(driver);
            checkout.FillDetails("John", "Doe", "12345");
            checkout.Continue();
        }
    }
}
