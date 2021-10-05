using System;
using System.Collections.Generic;
using System.Globalization;

namespace PhoneNumbers
{
    public class BubbleSort
    {
        public bool CheckIfPhoneBookIsConsistent(int i, List<string> phoneBook)
        {
            if (i == phoneBook.Count - 1)
            {
                return true;
            }

            bool isConsistent = CheckIfPhoneBookIsConsistent(i + 1, phoneBook);
            
            return !phoneBook[i + 1].StartsWith(phoneBook[i]) && isConsistent;
        }
        public List<string> SortPhoneBook(int i, List<string> phoneBook, int iteration)
        {
            if (i == phoneBook.Count - 2)
            {
                return OrderTwoNumbers(phoneBook, i);
            }
        
            phoneBook = SortPhoneBook(i + 1, phoneBook, iteration);

            if (i == 0)
            {
                phoneBook = OrderTwoNumbers(phoneBook, i);

                if (iteration == phoneBook.Count)
                {
                    return OrderTwoNumbers(phoneBook, i);
                }
                else
                {
                    SortPhoneBook(i, phoneBook, iteration + 1);
                }
            }

            return OrderTwoNumbers(phoneBook, i);
        }

        public List<string> OrderTwoNumbers(List<string> phoneBook, int i)
        {
            int lengthFirstNumber = phoneBook[i].Length;
            int lengthSecondNumber = phoneBook[i + 1].Length;

            int lengthToCheck = lengthFirstNumber < lengthSecondNumber ? lengthFirstNumber : lengthSecondNumber;

            int string1 = int.Parse(phoneBook[i].Substring(0, lengthToCheck), NumberStyles.Any);
            int string2 = int.Parse(phoneBook[i + 1].Substring(0, lengthToCheck), NumberStyles.Any);

            if (string1 > string2)
            {
                (phoneBook[i], phoneBook[i + 1]) = (phoneBook[i + 1], phoneBook[i]);
            }

            if (string1 == string2)
            {
                if (lengthFirstNumber > lengthSecondNumber)
                {
                    (phoneBook[i], phoneBook[i + 1]) = (phoneBook[i + 1], phoneBook[i]);
                }
            }
            
            return phoneBook;
        }
    }
}


