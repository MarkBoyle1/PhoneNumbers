using System.Collections.Generic;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class BubbleSortTests
    {
        private IPhoneBookAnalyser _bubbleSort = new BubbleSort();

        [Fact]
        public void given_phoneBookContains_91125426_97625992_911_when_RunPhoneBookAnalyser_then_return_false()
        {
            List<string> phoneBook = new List<string>() {"91125426", "97625992", "911"};

            Assert.False(_bubbleSort.RunPhoneBookAnalyser(phoneBook));
        }
        
        [Fact]
        public void given_phoneBookContains_91125426_97625992_912_when_RunPhoneBookAnalyser_then_return_true()
        {
            List<string> phoneBook = new List<string>() {"91125426", "97625992", "912"};
            
            Assert.True(_bubbleSort.RunPhoneBookAnalyser(phoneBook));

        }
    }
}