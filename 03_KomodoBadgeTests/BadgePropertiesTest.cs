using _03_KomodoBadgeClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_KomodoBadgeTests
{
    [TestClass]
    public class BadgePropertiesTest
    {
        [TestMethod]
        public void SetBadgeId_BadgeUnitTest()
        {         
            Badge content = new Badge();
            content.BadgeID = 5;

            int expected = 5;
            int actual = content.BadgeID;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetDoorNamesList_ShouldSetListOfStrings()
        {
            Badge content = new Badge();
            content.DoorNames = new List<string> { "A7" };

            List<string> expected = new List<string> { "A7" };
            List<string> actual = content.DoorNames;

            Assert.AreEqual(expected, actual);
        }
    }
}
