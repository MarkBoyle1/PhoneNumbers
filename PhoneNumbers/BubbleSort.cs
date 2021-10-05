using System;
using System.Collections.Generic;
using System.Globalization;

namespace PhoneNumbers
{
    public class BubbleSort : IPhoneBookAnalyser
    {
        private SortedPhoneBookAnalyser _sortedPhoneBookAnalyser;

        public BubbleSort()
        {
            _sortedPhoneBookAnalyser = new SortedPhoneBookAnalyser();
        }

        public bool RunPhoneBookAnalyser(List<string> phoneBook)
        {
            phoneBook = BubbleSortPhoneBook(0, phoneBook, 1);
            bool result = _sortedPhoneBookAnalyser.CheckIfSortedPhoneBookIsConsistent(0, phoneBook);
            return result;
        }
        private List<string> BubbleSortPhoneBook(int i, List<string> phoneBook, int iteration)
        {
            if (i == phoneBook.Count - 2)
            {
                return OrderCurrentTwoNumbers(phoneBook, i);
            }
        
            phoneBook = BubbleSortPhoneBook(i + 1, phoneBook, iteration);

            if (i == 0)
            {
                phoneBook = OrderCurrentTwoNumbers(phoneBook, i);

                if (iteration == phoneBook.Count)
                {
                    return OrderCurrentTwoNumbers(phoneBook, i);
                }
                else
                {
                    BubbleSortPhoneBook(i, phoneBook, iteration + 1);
                }
            }

            return OrderCurrentTwoNumbers(phoneBook, i);
        }

        private List<string> OrderCurrentTwoNumbers(List<string> phoneBook, int i)
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


