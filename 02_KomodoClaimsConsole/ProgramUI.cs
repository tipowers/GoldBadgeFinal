using _02_KomodoClaimsDept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaimsConsole
{
    class ProgramUI
    {
        private readonly ClaimRepo _claims = new ClaimRepo();

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
                Console.WriteLine("Select a menu option:\n\n" +
                    "1. See All Claims\n" +
                    "2. Handle Next Claim\n" +
                    "3. Enter a New Claim\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DisplayAllClaims();
                        break;
                    case "2":
                        //DisplayNextClaim();
                        break;
                    case "3":
                        CreateNewClaim();
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

        private void DisplayAllClaims()
        {
            Console.Clear();
            Queue<Claim> queueOfClaims = _claims.GetClaimsQueue();

            foreach (Claim claim in queueOfClaims)
            {
                Console.WriteLine($"Claim ID: {claim.ClaimId}\n" +
                    $"Type: {claim.TypeOfClaim}\n" +
                    $"Description: {claim.Description}\n" +
                    $"Amount: {claim.ClaimAmount}\n" +
                    $"DateOfAccident: {claim.DateOfIncident}\n" +
                    $"DateOfClaim: {claim.DateOfClaim}\n" +
                    $"IsValid: {claim.IsValid}\n");
            }
        }

        /*private void DisplayNextClaim()
        {
            Console.Clear();

            Claim nextClaimInQueue = _claims.
        }*/

        private void CreateNewClaim()
        {
            Console.Clear();
            Claim newClaim = new Claim();

            Console.WriteLine("Enter the new Claim Id:");
            string claimIdAsString = Console.ReadLine();
            int claimIdAsInt = int.Parse(claimIdAsString);
            newClaim.ClaimId = claimIdAsInt;

            Console.WriteLine("Enter the Claim Type Number:\n" +
                "1. Car" +
                "2. Home" +
                "3. Theft");
            string claimTypeAsString = Console.ReadLine();
            int claimTypeAsInt = int.Parse(claimTypeAsString);
            newClaim.TypeOfClaim = (ClaimType)claimTypeAsInt;

            Console.WriteLine("Enter the Claim Description:");
            newClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the Amount of Damage:");
            newClaim.ClaimAmount = Console.ReadLine();

            Console.WriteLine("Enter the Date of Accident:");

            Console.WriteLine("Enter the Date of Claim:");

            // Call isValid helper method here when fixed

            _claims.AddClaimToQueue(newClaim);

        }

        public void SeedContentList()
        {
            Claim claimOne = new Claim(1, ClaimType.Car, "Car accident on 465.", "$400.00", new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true);
            Claim claimTwo = new Claim(2, ClaimType.Home, "House fire in kitchen.", "$4000.00", new DateTime(2018, 04, 11), new DateTime(2018, 04, 12), true);
            Claim claimThree = new Claim(3, ClaimType.Theft, "Stolen pancakes.", "$4.00", new DateTime(2018, 04, 27), new DateTime(2018, 06, 01), false);

            _claims.AddClaimToQueue(claimOne);
            _claims.AddClaimToQueue(claimTwo);
            _claims.AddClaimToQueue(claimThree);
        }
    }
}
