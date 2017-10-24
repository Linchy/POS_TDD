using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POS_TDD.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestItemAPrice()
        {
            var code = "A";
            var checkout = new Checkout();
            var price = checkout.GetPrice(code);
            Assert.AreEqual(20, price);
        }

        [TestMethod]
        public void TestItemBPrice()
        {
            var code = "B";
            var checkout = new Checkout();
            var price = checkout.GetPrice(code);
            Assert.AreEqual(10, price);
        }


        [TestMethod]
        public void TestItemCPrice()
        {
            var code = "C";
            var checkout = new Checkout();
            var price = checkout.GetPrice(code);
            Assert.AreEqual(15, price);
        }

        [TestMethod]
        public void TestNoItemPrice()
        {
            var code = "";
            var checkout = new Checkout();
            var price = checkout.GetPrice(code);
            Assert.AreEqual(0, price);
        }

        [TestMethod]
        public void TestNullItemPrice()
        {
            string code = null;
            var checkout = new Checkout();
            var price = checkout.GetPrice(code);
            Assert.AreEqual(0, price);
        }

        [TestMethod]
        public void TestWhitespaceItemPrice()
        {
            string code = "   ";
            var checkout = new Checkout();
            var price = checkout.GetPrice(code);
            Assert.AreEqual(0, price);
        }

        [TestMethod]
        public void TestItemsABPrice()
        {
            string code = "AB";
            var checkout = new Checkout();
            var price = checkout.GetPrice(code);
            Assert.AreEqual(10 + 20, price);
        }
    }
}
