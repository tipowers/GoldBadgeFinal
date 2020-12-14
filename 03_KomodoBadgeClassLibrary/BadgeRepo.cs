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
        public void AddBadgeToDictionary(int id, List<String> stringList)
        {
           // _badgeDictionary.Add(id, Badge stringList);
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
