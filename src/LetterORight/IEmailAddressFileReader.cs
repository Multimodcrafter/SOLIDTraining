using System.Collections.Generic;

namespace LetterORight
{
    public interface IEmailAddressFileReader
    {
        IEnumerable<string> ReadMailAddressesFromFile(string filePath);
    }
}