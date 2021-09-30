using System;
using System.Collections.Generic;

namespace PhoneNumbers
{
    public class PhoneBookAnalyser
    {
        static void Main(string[] args)
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};
            Stack<string> myStack = new Stack<string>(phoneNumbers);
            

            List<string> prefixs = new List<string>();

            FindMaxNumberOfDigits(0, phoneNumbers, 0);
        }

        public static int FindMaxNumberOfDigits(int i, List<string> phoneNumbers, int maxNumberOfDigits)
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
        
        public static List<string> AddingNumbersToPrefixList(List<string> prefixs, Stack<string> myStack, int maxNumberOfDigits)
        {
            string phoneNumber = myStack.Pop();
            
            if (myStack.Count == 0)
            {
                if (maxNumberOfDigits != phoneNumber.Length)
                {
                    prefixs.Add(phoneNumber);
                }

                return prefixs;
            }

            prefixs = AddingNumbersToPrefixList(prefixs, myStack, maxNumberOfDigits);

            if (maxNumberOfDigits != phoneNumber.Length)
            {
                prefixs.Add(phoneNumber);
            }

            return prefixs;
        }
        
        
        
        
        
        
        public static int FindMaxNumberOfDigitsTailRecursion(Stack<string> myStack)
        {
            int numberOfDigits = myStack.Pop().Length;

            if (myStack.Count == 1)
            {
                return numberOfDigits;
            }

            int recursionFunction = FindMaxNumberOfDigitsTailRecursion(myStack);
        
            if (numberOfDigits >= recursionFunction)
            {
                return numberOfDigits;
            }
        
            return recursionFunction;
        }

    }
}
