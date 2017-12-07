using System.Collections.Generic;

namespace LetterDRight
{
    public interface IEmailAddressProvider
    {
        IEnumerable<string> GetMailAddresses();
    }
}