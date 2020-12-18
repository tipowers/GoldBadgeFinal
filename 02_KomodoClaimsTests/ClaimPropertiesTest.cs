using _02_KomodoClaimsDept;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_KomodoClaimsTests
{
    [TestClass]
    public class ClaimPropertiesTest
    {
        [TestMethod]
        public void SetClaimId_ShouldSetToInt()
        {
            Claim newClaim = new Claim();
            newClaim.ClaimId = 1;

            int expected = 1;
            int actual = newClaim.ClaimId;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetClaimType_ShouldSetEnumThroughCasting()
        {
            Claim newClaim = new Claim();
            newClaim.TypeOfClaim = (ClaimType)2;

            ClaimType expected = (ClaimType)2;
            ClaimType actual = newClaim.TypeOfClaim;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetDescription_ShouldSetToString()
        {
            Claim newClaim = new Claim();
            newClaim.Description = "Lorem";

            string expected = "Lorem";
            string actual = newClaim.Description;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetClaimAmount_ShouldSetToString()
        {
            Claim newClaim = new Claim();
            newClaim.ClaimAmount = "$1,000,000";

            string expected = "$1,000,000";
            string actual = newClaim.ClaimAmount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetIncidentDate_ShouldSetDateTime()
        {
            Claim newClaim = new Claim();
            newClaim.DateOfIncident = new DateTime(2020, 12, 10);

            DateTime expected = new DateTime(2020, 12, 10);
            DateTime actual = newClaim.DateOfIncident;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetClaimDate_ShouldSetDateTime()
        {
            Claim newClaim = new Claim();
            newClaim.DateOfClaim = new DateTime(2020, 12, 15);

            DateTime expected = new DateTime(2020, 12, 15);
            DateTime actual = newClaim.DateOfClaim;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsClaimValid_ShouldReturnBool()
        {
            Claim newClaim = new Claim();
            newClaim.IsValid = true;

            bool expected = true;
            bool actual = newClaim.IsValid;

            Assert.AreEqual(expected, actual);
        }
    }
}
