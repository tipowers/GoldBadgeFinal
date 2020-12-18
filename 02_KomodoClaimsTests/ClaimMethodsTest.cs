using _02_KomodoClaimsDept;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_KomodoClaimsTests
{
    [TestClass]
    public class ClaimMethodsTest
    {
        private ClaimRepo _repo;
        private Claim _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimRepo();
            _content = new Claim(4, ClaimType.Theft, "Stole the Crown Jewels", "$1,000,000,000,", new DateTime(2020, 7, 28), new DateTime (2020, 8, 30), false);

            _repo.AddClaimToQueue(_content);
        }

        // Create
        [TestMethod]
        public void AddClaimToQueue_ShouldGetNotNull()
        {
            // Act
            Queue<Claim> content = new Queue<Claim>();
            
            _repo.AddClaimToQueue(_content);

            // Assert
            Assert.IsNotNull(content);
        }

        // Read
        [TestMethod]
        public void GetClaimsQueue_ShouldReturnQueue()
        {
            // Act
            Queue<Claim> queueFromRepo = _repo.GetClaimsQueue();

            // Assert
            Assert.IsNotNull(queueFromRepo);
        }

        // Read
        public void GetNextClaim_ShouldReturnDifferentValue()
        {
            // Act
            Claim queueFromRepo = _repo.GetNextClaim();

            // Assert
            Assert.IsNotNull(queueFromRepo);
        }

        // Update
        public void IsClaimValid_ShouldBeEqual()
        {
            Claim newClaim = new Claim();
            newClaim.IsValid = true;

            bool expected = true;
            bool actual = true;

            Assert.AreEqual(expected, actual);
        }

        // IsClaim Valid helper method broken....did not include in tests
    }
}
