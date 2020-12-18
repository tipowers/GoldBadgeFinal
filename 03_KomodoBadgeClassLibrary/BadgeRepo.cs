using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadgeClassLibrary
{
    public class BadgeRepo
    {
        private readonly Dictionary<int, Badge> _badgeDictionary = new Dictionary<int, Badge>();

        // Create
        public void AddBadgeToDictionary(int id, Badge stringList)
        {
           _badgeDictionary.Add(id, stringList);
        }

        // Read
        public Dictionary<int, Badge> DisplayDictionary()
        {
            return _badgeDictionary;
        }

        // Update
        public bool AddDoorToBadge(int id, string doorToAdd)
        {
            Badge content = GetBadgeByKeyValue(id);

            if (content == null)
            {
                return false;
            }

            foreach (var door in content.DoorNames)
            {
                if (door.Equals(doorToAdd))
                {
                    content.DoorNames.Add(door);
                }
            }
            return true;
        }

        // Delete
        public bool RemoveDoorFromBadge(int id, string doorToRemove)
        {
            Badge content = GetBadgeByKeyValue(id);

            if (content == null)
            {
                return false;
            }

            foreach (var door in content.DoorNames)
            {
                if (door.Equals(doorToRemove))
                {
                    content.DoorNames.Remove(door);
                }
            }
            return true;
        }

        // Delete method...if we want to delete all doors from an existing badge
        // This currently removes the entire user and not just the doornames...not required
        public bool RemoveAllDoorsFromBadge(int id)
        {
            Badge content = GetBadgeByKeyValue(id);

            if (content == null)
            {
                return false;
            }

            foreach (var door in content.DoorNames)
            {
                content.DoorNames.Remove(door);               
            }
            return true;
        }

        // Badge helper
        public Badge GetBadgeByKeyValue(int id)
        {
            foreach (var kvp in _badgeDictionary)
            {
                if (kvp.Value.BadgeID == id)
                {
                    return kvp.Value;
                }
            }
            return null;
        }
    }
}
