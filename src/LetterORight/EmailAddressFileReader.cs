using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LetterORight
{
    public class EmailAddressFileReader : IEmailAddressProvider
    {
        private readonly string filePath;

        public EmailAddressFileReader(string filePath)
        {
            this.filePath = filePath;
        }


        public IEnumerable<string> GetMailAddresses()
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