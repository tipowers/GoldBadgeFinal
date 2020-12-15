using _01_KomodoCafeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_KomodoCafeTests
{
    [TestClass]
    public class MenuPropertiesTest
    {
        [TestMethod]
        public void SetMealNumber_ShouldSetToInt()
        {
            Menu content = new Menu();
            content.MealNumber = 5;

            int expected = 5;
            int actual = content.MealNumber;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetMealName_ShouldSetToString()
        {
            Menu content = new Menu();
            content.MealName = "Salad";

            string expected = "Salad";
            string actual = content.MealName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetDescription_ShouldSetToString()
        {
            Menu content = new Menu();
            content.Description = "Lorem ipsum";

            string expected = "Lorem ipsum";
            string actual = content.Description;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListOfIngredients_ShouldSetToString()
        {
            Menu content = new Menu();
            content.ListOfIngredients = "Salad leaves, crutons, and Ranch salad dressing";

            string expected = "Salad leaves, crutons, and Ranch salad dressing";
            string actual = content.ListOfIngredients;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Price_ShouldSetToDouble()
        {
            Menu content = new Menu();
            content.Price = 5.99;

            double expected = 5.99;
            double actual = content.Price;

            Assert.AreEqual(expected, actual);
        }
    }
}
