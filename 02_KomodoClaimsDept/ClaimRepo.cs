using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaimsDept
{
    public class ClaimRepo
    {
        private Queue<Claim> _queueOfClaims = new Queue<Claim>();

        // Create
        public void AddClaimToQueue(Claim claimContent)
        {
            _queueOfClaims.Enqueue(claimContent);
        }

        // Read
        // The return type is a Queue because we need to return a queue of items
        public Queue<Claim> GetClaimsQueue()
        {
            return _queueOfClaims;
        }

        // Read
        // The return type is a Claim because we only need to return one claim
        public Claim GetNextClaim()
        {
            return _queueOfClaims.Peek();
        }

        // Update
        // Issue here somewhere.. ask in Learning Gym or class
        public Claim HandleClaim(string userInput)
        {
            if (userInput == "y")
            {
                return _queueOfClaims.Dequeue();
            }
            else
            {
                return _queueOfClaims.Peek();
            }
        }

        // Is Claim Valid Helper Method
        // Issue with this somewhere...ask about this in Learning Gym or class
        public bool IsClaimValid()
        {
            foreach (Claim claim in _queueOfClaims)
            { 
                DateTime incidentDate = claim.DateOfIncident;
                DateTime claimDate = claim.DateOfClaim;

                TimeSpan difference = claimDate.Subtract(incidentDate);

                if (difference.TotalDays < 31)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
