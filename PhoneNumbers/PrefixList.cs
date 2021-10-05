using System.Collections.Generic;
using System.Linq;

namespace PhoneNumbers
{
    public class PrefixList
    {
        public int FindMaxNumberOfDigits(int i, List<string> phoneNumbers, int maxNumberOfDigits)
        {
            int numberOfDigits = phoneNumbers[i].Length;
            
            if (numberOfDigits > maxNumberOfDigits)
            {
                maxNumberOfDigits = numberOfDigits;
            }
            
            if (i < phoneNumbers.Count - 1)
            {
                FindMaxNumberOfDigits(i + 1, phoneNumbers, maxNumberOfDigits);
            }
            
            return maxNumberOfDigits;
        }
        
        public  List<string> AddingNumbersToPrefixList(List<string> phoneNumbers, int maxNumberOfDigits)
        {
            if (phoneNumbers.Count == 0)
            {
                return new List<string>();
            }

            string firstNumber = phoneNumbers.First();
            List<string> phoneNumbersWithoutFirst = new List<string>(phoneNumbers);
            phoneNumbersWithoutFirst.RemoveAt(0);
            
            List<string> prefixList = AddingNumbersToPrefixList(phoneNumbersWithoutFirst, maxNumberOfDigits);

            if (firstNumber.Length < maxNumberOfDigits)
            {
                prefixList.Add(firstNumber);
            }
            
            return prefixList;
        }

        public bool CheckIfPhoneBookIsConsistent(List<string> phoneNumbers, List<string> prefixList)
        {
            if (phoneNumbers.Count == 0)
            {
                return true;
            }

            string firstNumber = phoneNumbers.First();
            List<string> phoneNumbersWithoutFirst = new List<string>(phoneNumbers);
            phoneNumbersWithoutFirst.RemoveAt(0);

            bool isConsistent = CheckIfPhoneBookIsConsistent(phoneNumbersWithoutFirst, prefixList);

            return !CheckIfPhoneNumberContainsPrefix(firstNumber, prefixList) && isConsistent;
        }

        public bool CheckIfPhoneNumberContainsPrefix(string firstNumber, List<string> prefixList)
        {
            if (prefixList.Count == 0)
            {
                return false;
            }

            string firstPrefix = prefixList.First();
            List<string> prefixListWithoutFirst = new List<string>(prefixList);
            prefixListWithoutFirst.RemoveAt(0);

            bool containsPrefix = CheckIfPhoneNumberContainsPrefix(firstNumber, prefixListWithoutFirst);

            return (firstNumber.StartsWith(firstPrefix) && firstNumber != firstPrefix) || containsPrefix;
        }

        public int FindMaxNumberOfDigitsTailRecursion(Stack<string> phoneNumberStack)
        {
            int numberOfDigits = phoneNumberStack.Pop().Length;

            if (phoneNumberStack.Count == 1)
            {
                return numberOfDigits;
            }

            int recursionFunction = FindMaxNumberOfDigitsTailRecursion(phoneNumberStack);
        
            if (numberOfDigits >= recursionFunction)
            {
                return numberOfDigits;
            }
        
            return recursionFunction;
        }

    }
}