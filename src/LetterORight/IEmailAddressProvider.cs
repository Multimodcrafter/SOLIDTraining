using System.Collections.Generic;

namespace LetterORight
{
    public interface IEmailAddressProvider
    {
        IEnumerable<string> GetMailAddresses();
    }
}