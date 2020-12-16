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
        public bool UpdateDictionaryBadges(int originalKey, Badge newContent)
        {
            Badge oldContent = GetBadgeByKeyValue(originalKey);

            if (oldContent != null)
            {
                oldContent.BadgeID = newContent.BadgeID;
                oldContent.DoorNames = newContent.DoorNames;

                return true;
            }
            else
            {
                return false;
            }
        }

        // Delete method...we want to delete all doors from an existing badge
        // This currently removes the entire user and not just the doornames...broken
        public bool RemoveDoorFromBadge(int id)
        {
            Badge content = GetBadgeByKeyValue(id);

            if (content == null)
            {
                return false;
            }

            int initialCount = _badgeDictionary.Count;
            _badgeDictionary.Remove(id);

            if (initialCount > _badgeDictionary.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Badge helper
        // This is obvs broken as well...fix to come
        public Badge GetBadgeByKeyValue(int id)
        {
            foreach (Badge content in _badgeDictionary)
            {
                if (content.BadgeID == id)
                {
                    return content;
                }
            }
            return null;
        }
    }
}
