using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumbersTests
    {
        PrefixList prefixListstrategy = new PrefixList();
        
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_911_when_FindMaxNumberOfDigits_then_return_8()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};
            Stack<string> myStack = new Stack<string>(phoneNumbers);

            int maxDigits =  prefixListstrategy.FindMaxNumberOfDigitsTailRecursion(myStack);
            
            Assert.Equal(8, maxDigits);
        }
        
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_911_when_AddingNumbersToPrefixList_then_return_911()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};

            List<string> expected = new List<string>() {"911"};

            List<string> prefixs =  prefixListstrategy.AddingNumbersToPrefixList(phoneNumbers, 8);
            
            Assert.Equal(expected, prefixs);
        }
        
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_911_when_CheckIfPhoneBookIsConsistent_then_return_false()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};
            
            List<string> prefixList = new List<string>() {"911"};
            
            Assert.False(prefixListstrategy.CheckIfPhoneBookIsConsistent(phoneNumbers, prefixList));
        }
        
        [Fact]
        public void given_phoneNumbersContains_91125426_97625992_912_when_CheckIfPhoneBookIsConsistent_then_return_true()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "912"};
            
            List<string> prefixList = new List<string>() {"912"};

            
            Assert.True(prefixListstrategy.CheckIfPhoneBookIsConsistent(phoneNumbers, prefixList));
        }
        
    }
}