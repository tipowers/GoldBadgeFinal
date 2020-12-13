using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KomodoClaimsDept
{
    public enum ClaimType { Car = 1, Home, Theft }
    public class Claim
    {
        public int ClaimId { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string Description { get; set; }
        public string ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public Claim() { }

        public Claim(int claimId, ClaimType typeOfClaim, string description, string claimAmount, DateTime dateOfInicident, DateTime dateOfClaim, bool isValid)
        {
            ClaimId = claimId;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfInicident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
