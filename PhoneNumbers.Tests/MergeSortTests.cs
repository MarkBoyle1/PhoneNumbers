using System.Collections.Generic;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class MergeSortTests
    {
        private MergeSort _mergeSort = new MergeSort();
        private BubbleSort _bubbleSort = new BubbleSort();
        
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_911_when_CheckIfPhoneBookIsConsistent_then_return_false()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};

            phoneNumbers = _mergeSort.MergeSortPhoneBook(phoneNumbers);

            Assert.False(_bubbleSort.CheckIfPhoneBookIsConsistent(0, phoneNumbers));
        }
        
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_912_when_CheckIfPhoneBookIsConsistent_then_return_true()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "912"};
            
            phoneNumbers = _mergeSort.MergeSortPhoneBook(phoneNumbers);
            
            Assert.True(_bubbleSort.CheckIfPhoneBookIsConsistent(0, phoneNumbers));
        }
    }
}