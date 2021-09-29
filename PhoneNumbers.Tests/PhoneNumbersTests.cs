using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace PhoneNumbers.Tests
{
    public class PhoneNumbersTests
    {
        [Fact]
        public void Test1()
        {
            List<string> phoneNumbers = new List<string>() {"91125426", "97625992", "911"};

            int maxDigits =  PhoneBookAnalyser.FindMaxNumberOfDigits(0, phoneNumbers, 0);
            
            Assert.Equal(8, maxDigits);
        }
    }
}