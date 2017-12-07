using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LetterDWrong
{
    internal class EmailAddressFileReader
    {
        public IEnumerable<string> ReadMailAddressesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadLines(filePath).Where(line => !string.IsNullOrWhiteSpace(line));
            }
            return Enumerable.Empty<string>();
        }
    }
}