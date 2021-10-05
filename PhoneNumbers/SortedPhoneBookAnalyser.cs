using System.Collections.Generic;

namespace PhoneNumbers
{
    public class SortedPhoneBookAnalyser
    {
        public bool CheckIfSortedPhoneBookIsConsistent(int i, List<string> phoneBook)
        {
            if (i == phoneBook.Count - 1)
            {
                return true;
            }

            bool isConsistent = CheckIfSortedPhoneBookIsConsistent(i + 1, phoneBook);
            
            return !phoneBook[i + 1].StartsWith(phoneBook[i]) && isConsistent;
        }
    }
}