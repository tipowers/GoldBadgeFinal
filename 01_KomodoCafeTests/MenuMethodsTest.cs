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

        // Add method
        /*[TestMethod]
        public void AddToMenu_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            Menu content = new Menu();
            content.MealName = "Philly Cheesesteak";
            MenuRepo repository = new MenuRepo();

            // Act --> Get/Run the we want to test
            repository.AddMealToMenu(content);
            Menu contentFromMenu = repository.AddMealToMenu("Philly Cheesesteak");

            // Assert --> Use the assert class to verify the expected outcome
        }*/
    }
}
