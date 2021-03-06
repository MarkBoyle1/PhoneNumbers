using System.Collections.Generic;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class MergeSortTests
    {
        private IPhoneBookAnalyser _mergeSort = new MergeSort();

        [Fact]
        public void given_phoneBookContains_91125426_97625992_911_when_RunPhoneBookAnalyser_then_return_false()
        {
            List<string> phoneBook = new List<string>() {"91125426", "97625992", "976"};

            Assert.False(_mergeSort.RunPhoneBookAnalyser(phoneBook));
        }
        
        [Fact]
        public void given_phoneBookContains_91125426_97625992_912_when_RunPhoneBookAnalyser_then_return_true()
        {
            List<string> phoneBook = new List<string>() {"91125426", "97625992", "912"};
            
            Assert.True(_mergeSort.RunPhoneBookAnalyser(phoneBook));
        }
    }
}