using _01_KomodoCafeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_KomodoCafeTests
{
    [TestClass]
    public class MenuMethodsTest
    {
        private MenuRepo _repo;
        private Menu _content;

        [TestInitialize]

        public void Arrange()
        {
            _repo = new MenuRepo();
            _content = new Menu(4, "Philly Cheesesteak", "Delicious, but not so nutritious!", "Meat, Cheese, Lettuce, Tomato, and Mayonnaise", 7.99);

            _repo.AddMealToMenu(_content);
        }

        // Still need Read test method...more research needed

        // Add method
        [TestMethod]
        public void AddToMenu_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            Menu content = new Menu();
            content.MealNumber = 5;
            MenuRepo repository = new MenuRepo();

            // Act --> Get/Run the we want to test
            repository.AddMealToMenu(content);
            Menu contentFromMenu = repository.GetMealById(5);

            // Assert --> Use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromMenu);
        }

        // Delete method
        [TestMethod]
        public void DeleteMeal_ShouldReturnTreu()
        {
            // Arrange which is in the...
            // ...Test initialize method ^

            // Act
            bool deleteResult = _repo.RemoveMealFromMenu(_content.MealNumber);

            // Assert
            Assert.IsTrue(deleteResult);

        }
    }
}
