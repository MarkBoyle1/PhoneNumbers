using System.Collections.Generic;

namespace PhoneNumbers
{
    public interface IPhoneBookAnalyser
    {
        public bool RunPhoneBookAnalyser(List<string> phoneBook);
    }
}