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
        public Queue<Claim> GetClaimsQueue()
        {
            return _queueOfClaims;
        }

        /*public Queue<Claim> GetNextClaimInQueue()
        {
            return _queueOfClaims.Peek;
        }*/

        // Is Claim Valid Helper Method
        /*public bool isClaimValid(bool isValid)
        {
            foreach (ClaimPoco claim in _queueOfClaims)
            {
                DateTime currentDate = DateTime.Today;
                DateTime incidentDate = claim.DateOfIncident;
                DateTime claimDate = claim.DateOfClaim;

                if (currentDate - claimDate > 30 )
                {
                    return true;
                }
            }
            return false;
        }*/
    }
}
