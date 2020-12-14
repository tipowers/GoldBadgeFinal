using _03_KomodoBadgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadgeConsole
{
    class ProgramUI
    {
        private readonly BadgeRepo _badges = new BadgeRepo();

        public void Run()
        {
            SeedContentList();
            Menu();
        }

        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Hello Administrator Extraordinaire. What Can I Assist You With?\n\n" +
                    "1. List All Badges\n" +
                    "2. Add A Badge\n" +
                    "3. Edit A Badge\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
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
            Dictionary<int, Badge> badgeDictionary = _badges.DisplayDictionary();

            Console.WriteLine($"Badge #\t\t Door Access\n");
            foreach (KeyValuePair<int, Badge> badge in badgeDictionary)
            {
                int key = badge.Key;
                Badge value = badge.Value;
                Console.WriteLine($"{key}\t\t\t{value}\n");
            }
        }

        public void SeedContentList()
        {
            // Badge badgeOne = new Badge(1, doorNames: { "A7", });
        }
    }
}
