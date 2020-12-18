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
                        DisplayAllBadges();
                        break;
                    case "2":
                        AddBadge();
                        break;
                    case "3":
                        UpdateExistingBadge();
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

        public void DisplayAllBadges()
        {
            Console.Clear();
            Dictionary<int, Badge> badgeDictionary = _badges.DisplayDictionary();

            Console.WriteLine($"Badge #\t\t Door Access\n");
            foreach (var badge in badgeDictionary)
            {
                int key = badge.Key;
                Badge value = badge.Value;
                Console.WriteLine($"{key}\t\t{value}");
            }
        }

        public void AddBadge()
        {
            Console.Clear();
            Badge newBadge = new Badge();

            Console.WriteLine("Enter the new 5-digit badge number:");
            string badgeIdAsString = Console.ReadLine();
            int badgeIdAsInt = int.Parse(badgeIdAsString);
            newBadge.BadgeID = badgeIdAsInt;

            Console.WriteLine("\nList a door this badge will have access to:\n");
            string accessAsString = Console.ReadLine();
            newBadge.DoorNames.Add(accessAsString);

            Console.WriteLine("Any other doors: (y/n)\n");
            string moreDoors = Console.ReadLine().ToLower();
            while (moreDoors == "y")
            {
                Console.WriteLine("List a door this badge will have access to:\n");
                string anotherAccessAsString = Console.ReadLine();
                newBadge.DoorNames.Add(anotherAccessAsString);

                Console.WriteLine("Any other doors: (y/n)\n");
                string evenMoreDoors = Console.ReadLine().ToLower();

                if (evenMoreDoors != "y")
                {
                    break;
                }
            }

            _badges.AddBadgeToDictionary(newBadge.BadgeID, newBadge);
        }

        public void UpdateExistingBadge()
        {
            DisplayAllBadges();

            Console.WriteLine("\nEnter the Badge Id you would like to update:\n");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);

            Badge user = _badges.GetBadgeByKeyValue(idAsInt);
            Console.WriteLine($"\n{user.BadgeID} has access to doors {user.DoorNames}.");

            Console.WriteLine("What would you like to do?\n\n" +
               "1. Remove a door\n" +
               "2. Add a door\n");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Enter the door you would like to remove:\n");
                string doorAsString = Console.ReadLine();
                _badges.RemoveDoorFromBadge(idAsInt, doorAsString);

                // Tried executing verification below, but it crashed the program
                /*bool wasDeleted = _badges.RemoveDoorFromBadge(idAsInt, doorAsString);
                if (wasDeleted)
                {
                    Console.WriteLine("\nDoor removed.\n");
                }
                else
                {
                    Console.WriteLine("\nDoor could not be removed.");
                }*/
            }
            else if (input == "2")
            {
                Console.WriteLine("List a door this badge will have access to:\n");
                string doorAsString = Console.ReadLine();
                _badges.AddDoorToBadge(idAsInt, doorAsString);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.\n");
            }
            //Console.WriteLine($"\n{user.BadgeID} has access to doors {user.DoorNames}.");
        }

        public void SeedContentList()
        {
            Badge badgeOne = new Badge(12345, new List<string> { "A7" });
            Badge badgeTwo = new Badge(22345, new List<string> { "A1,", "A4,", "B1,", "B2" });
            Badge badgeThree = new Badge(32345, new List<string> { "A4,", "A5" });

            _badges.AddBadgeToDictionary(badgeOne.BadgeID, badgeOne);
            _badges.AddBadgeToDictionary(badgeTwo.BadgeID, badgeTwo); 
            _badges.AddBadgeToDictionary(badgeThree.BadgeID, badgeThree);
        }
    }
}
