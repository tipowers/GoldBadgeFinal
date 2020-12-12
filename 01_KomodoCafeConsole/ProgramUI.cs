using _01_KomodoCafeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafeConsole
{
    class ProgramUI
    {
        private readonly MenuRepo _menu = new MenuRepo();

        public void Run()
        {
            SeedContentList();
            Menu();
        }

        public void Menu()
        {
            bool keepRunning = true;
            while(keepRunning)
            {
                Console.WriteLine("Welcome to the Komodo Cafe Grease Shack!\n" +
                    "Take a gander at the menu or make minor changes:\n\n" +
                    "1. View Menu\n" +
                    "2. Add New Meal To Menu\n" +
                    "3. Delete Meal From Menu\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayMenu();
                        break;
                    case "2":
                        AddMealToMenu();
                        break;
                    case "3":
                        DeleteMealFromMenu();
                        break;
                    case "4":
                        Console.WriteLine("\nSee you soon!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Continue();
            }
        }

        public void Continue()
        {
            Console.WriteLine("\nPlease press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void DisplayMenu()
        {
            Console.Clear();
            List<Menu> cafeMenu = _menu.GetMenu();

            foreach (Menu meal in cafeMenu)
            {
                Console.WriteLine($"Meal Number: {meal.MealNumber}\n" +
                    $"Meal Name: {meal.MealName}\n" +
                    $"Description: {meal.Description}\n" +
                    $"Ingredients: {meal.ListOfIngredients}\n" +
                    $"Price: {meal.Price}\n");
            }

        }

        public void AddMealToMenu()
        {
            Console.Clear();
            Menu newMenuMeal = new Menu();

            Console.WriteLine("Enter the new Meal Number:");
            string mealNumAsString = Console.ReadLine();
            int mealNumAsInt = int.Parse(mealNumAsString);
            newMenuMeal.MealNumber = mealNumAsInt;

            Console.WriteLine("\nEnter the new Meal Name:");
            newMenuMeal.MealName = Console.ReadLine();

            Console.WriteLine("\nEnter the new meal Description:");
            newMenuMeal.Description = Console.ReadLine();

            Console.WriteLine("\nEnter the new Meal Ingredients:");
            newMenuMeal.ListOfIngredients = Console.ReadLine();

            Console.WriteLine("\nEnter the new Meal Price:");
            string priceAsString = Console.ReadLine();
            double priceAsDouble = double.Parse(priceAsString);
            newMenuMeal.Price = priceAsDouble;

            _menu.AddMealToMenu(newMenuMeal);
        }

        public void DeleteMealFromMenu()
        {
            DisplayMenu();

            Console.WriteLine("Enter the Meal Number to delete that meal.");
            string mealNumAsString = Console.ReadLine();
            int mealNumAsInt = int.Parse(mealNumAsString);

            bool wasDeleted = _menu.RemoveMealFromMenu(mealNumAsInt);

            if (wasDeleted)
            {
                Console.WriteLine("\nThe meal was successfully deleted!");
            }
            else
            {
                Console.WriteLine("\nThe meal could not be deleted.");
            }
        }

        private void SeedContentList()
        {
            Menu mealOne = new Menu(1, "Big Mac Meal", "Big Mac, Fries, and a Strawberry Shake", "Hamburger, cheese, lettuce, tomato, onion, and pickles. " +
                "Golden brown fries. And freshly sourced strawberries and dairy for a deliciously tasting shake!", 5.99);
            Menu mealTwo = new Menu(2, "Double Whopper Meal", "Double Whopper, Fries, and a Coke", "Double hamburger, cheese, lettuce, tomato, onion, and pickles. " +
                "Golden brown fries. And a nice, always cold Coke", 6.99);
            Menu mealThree = new Menu(3, "Triple Bacon Burger Meal", "For the meat lover in us all!", "Triple hamburger, 4 bacon slices, cheese, lettuce, tomato, onion, and pickles. " +
                "Golden brown tater tots. And a delicious Root Beer Float to wash it all down!", 9.99);

            _menu.AddMealToMenu(mealOne);
            _menu.AddMealToMenu(mealTwo);
            _menu.AddMealToMenu(mealThree);
        }
    }
}
