using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PhoneNumbers
{
    public class PhoneBookAnalyser
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            MergeSort mergeSort = new MergeSort();
            PrefixList prefixList = new PrefixList();

            List<string> phoneNumbers = new List<string>() {"91125426", "8245", "97625992", "912"};
            
            int maxNumberOfDigits = prefixList.FindMaxNumberOfDigits(0, phoneNumbers, 0);
            List<string> prefixs = prefixList.AddingNumbersToPrefixList(phoneNumbers, maxNumberOfDigits);
            bool result1 = prefixList.CheckIfPhoneBookIsConsistent(phoneNumbers, prefixs);
            Console.WriteLine(result1);

            var result = bubbleSort.SortPhoneBook(0, phoneNumbers, 1);
            // var result = mergeSort.MergeSortPhoneBook(phoneNumbers);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(bubbleSort.CheckIfPhoneBookIsConsistent(0, result));
        }
    }
}
