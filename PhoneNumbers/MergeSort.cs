using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PhoneNumbers
{
    public class MergeSort : IPhoneBookAnalyser
    {
        private SortedPhoneBookAnalyser _sortedPhoneBookAnalyser;

        public MergeSort()
        {
            _sortedPhoneBookAnalyser = new SortedPhoneBookAnalyser();
        }

        public bool RunPhoneBookAnalyser(List<string> phoneBook)
        {
            phoneBook = MergeSortPhoneBook(phoneBook);
            bool result = _sortedPhoneBookAnalyser.CheckIfSortedPhoneBookIsConsistent(0, phoneBook);
            return result;
        }
        private List<string> MergeSortPhoneBook(List<string> phoneBook)
        {
            if (phoneBook.Count == 1)
            {
                return phoneBook;
            }
            
            int half = phoneBook.Count / 2;

            List<string> firstHalf = phoneBook.Take(half).ToList();
            List<string> secondHalf = phoneBook.Skip(half).ToList();

            firstHalf = MergeSortPhoneBook(firstHalf);
            secondHalf = MergeSortPhoneBook(secondHalf);

            return MergeTwoHalves(firstHalf, secondHalf, new List<string>());
        }

        private List<string> MergeTwoHalves(List<string> firstHalf, List<string> secondHalf, List<string> mergedList)
        {
            if (firstHalf.Count == 0)
            {
                mergedList.AddRange(secondHalf);
            }
            else if (secondHalf.Count == 0)
            {
                mergedList.AddRange(firstHalf);
            }
            else
            {
                string lowestNumber = SelectLowerNumber(firstHalf[0], secondHalf[0]);
                mergedList.Add(lowestNumber);
                
                if (lowestNumber == firstHalf[0])
                {
                    firstHalf.RemoveAt(0);
                }
                else
                {
                    secondHalf.RemoveAt(0);
                }

                MergeTwoHalves(firstHalf, secondHalf, mergedList);
            }

            return mergedList;
        }

        private string SelectLowerNumber(string firstNumber, string secondNumber)
        {
            int lengthFirstNumber = firstNumber.Length;
            int lengthSecondNumber = secondNumber.Length;

            int lengthToCheck = lengthFirstNumber < lengthSecondNumber ? lengthFirstNumber : lengthSecondNumber;

            int number1 = int.Parse(firstNumber.Substring(0, lengthToCheck), NumberStyles.Any);
            int number2 = int.Parse(secondNumber.Substring(0, lengthToCheck), NumberStyles.Any);

            if (number1 == number2)
            {
                return lengthFirstNumber < lengthSecondNumber ? firstNumber : secondNumber;
            }

            return number1 < number2 ? firstNumber : secondNumber;
        }
    }
}