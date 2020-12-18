using _03_KomodoBadgeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_KomodoBadgeTests
{
    [TestClass]
    public class BadgeMethodsTest
    {
        private BadgeRepo _repo;
        private Badge _content;

        [TestInitialize]

        public void Arrange()
        {
            _repo = new BadgeRepo();
            _content = new Badge(27384, new List<string> { "A2,", "B5,", "c4" });

            _repo.AddBadgeToDictionary(_content.BadgeID, _content);
        }

        //Create
        [TestMethod]
        public void AddBadgeToDictionary_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            Badge content = new Badge();
            content.BadgeID = 27384;
            BadgeRepo repository = new BadgeRepo();

            // Act --> Get/Run the we want to test
            repository.AddBadgeToDictionary(_content.BadgeID, _content);
            Badge contentFromDictionary = repository.GetBadgeByKeyValue(27384);

            // Assert --> Use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDictionary);
        }

        // Read
        [TestMethod]
        public void DisplayDictionary_ShouldReturnNotNull()
        {
            // Act
            Dictionary<int, Badge> dictionaryfromRepo = _repo.DisplayDictionary();

            // Assert
            Assert.IsNotNull(dictionaryfromRepo);
        }

        // Update
        [TestMethod]
        public void AddDoorToBadge_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            Badge content = new Badge();
            content.DoorNames.Add("A7");
            BadgeRepo repository = new BadgeRepo();

            // Act --> Get/Run the we want to test
            repository.AddDoorToBadge(_content.BadgeID, "A7");
            Badge doorFromBadge = repository.GetBadgeByKeyValue(12345);

            // Assert --> Use the assert class to verify the expected outcome
            Assert.IsNotNull(doorFromBadge);
        }

        // Delete
        [TestMethod]
        public void RemoveDoorFromBadge_ShouldReturnTrue()
        {
            // Act
            bool deleteResult = _repo.RemoveDoorFromBadge(_content.BadgeID, "A7");

            // Assert
            Assert.IsTrue(deleteResult);
        }
    }
}
