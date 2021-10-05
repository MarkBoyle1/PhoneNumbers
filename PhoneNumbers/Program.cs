using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PhoneNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPhoneBookAnalyser bubbleSort = new BubbleSort();
            IPhoneBookAnalyser mergeSort = new MergeSort();
            IPhoneBookAnalyser prefixList = new PrefixList();

            List<string> phoneBook = new List<string>() {"91125426", "97625992", "911"};

            bool bubbleSortResult = bubbleSort.RunPhoneBookAnalyser(phoneBook);
            bool mergeSortResult = mergeSort.RunPhoneBookAnalyser(phoneBook);
            bool prefixListResult = prefixList.RunPhoneBookAnalyser(phoneBook);

            Console.WriteLine("BubbleSort Result: " + bubbleSortResult);
            Console.WriteLine("MergeSort Result: " + mergeSortResult);
            Console.WriteLine("PrefixList Result: " + prefixListResult);
        }
    }
}
