using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumbersTests
    {
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_911_when_FindMaxNumberOfDigits_then_return_8()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};
            Stack<string> myStack = new Stack<string>(phoneNumbers);

            int maxDigits =  PhoneBookAnalyser.FindMaxNumberOfDigitsTailRecursion(myStack);
            
            Assert.Equal(8, maxDigits);
        }
        
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_911_when_AddingNumbersToPrefixList_then_return_911()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};
            Stack<string> myStack = new Stack<string>(phoneNumbers);
            List<string> prefixs = new List<string>();

            List<string> expected = new List<string>() {"911"};

            List<string> actual =  PhoneBookAnalyser.AddingNumbersToPrefixList(prefixs, myStack, 8);
            
            Assert.Equal(expected, actual);
        }
    }
}