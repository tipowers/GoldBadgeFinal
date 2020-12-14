using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KomodoBadgeClassLibrary
{
    public class BadgeRepo
    {
        private Dictionary<int, Badge> _badgeDictionary = new Dictionary<int, Badge>();

        // Create
        public void AddBadgeToDictionary(int id, Badge badgeContent)
        {
            _badgeDictionary.Add(id, badgeContent);
        }

        // Read
        public Dictionary<int, Badge> DisplayDictionary()
        {
            return _badgeDictionary;
        }

        // Update

        // For the Delete method we want to delete all doors from an existing badge
    }
}
