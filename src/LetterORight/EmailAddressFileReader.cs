using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LetterORight
{
    internal class EmailAddressFileReader
    {
        public IEnumerable<string> ReadMailAddressesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadLines(filePath).Select(OnReadline).Where(line => !string.IsNullOrWhiteSpace(line));
            }
            return Enumerable.Empty<string>();
        }

        protected virtual string OnReadline(string line)
        {
            return line;
        }
    }
}