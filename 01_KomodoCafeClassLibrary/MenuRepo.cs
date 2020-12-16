using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafeClassLibrary
{
    public class MenuRepo
    {
        private readonly List<Menu> _cafeMenu = new List<Menu>();

        // Create - Add meal to menu
        public void AddMealToMenu(Menu content)
        {
            _cafeMenu.Add(content);
        }

        // Read menu items
        public List<Menu> GetMenu()
        {
            return _cafeMenu;
        }

        // Per assignment prompt...no update method is required
        // If user needs to update a menu item they must delete it and create a new meal

        // Delete meal by meal id
        public bool RemoveMealFromMenu(int menuId)
        {
            Menu content = GetMealById(menuId);

            if (content == null)
            {
                return false;
            }

            int initialCount = _cafeMenu.Count;
            _cafeMenu.Remove(content);

            if (initialCount > _cafeMenu.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Get meal by meal number
        public Menu GetMealById(int menuId)
        {
            foreach (Menu menu in _cafeMenu)
            {
                if(menu.MealNumber == menuId)
                {
                    return menu;
                }
            }
            return null;
        }
    }
}
