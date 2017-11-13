using System.Collections.Generic;
using System.IO;

namespace LetterSRight
{
    internal class EmailAddressFileReader
    {
        public IEnumerable<string> ReadMailAddressesFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                yield break;
            }

            // yes: this may be written as a oneliner :-)
            using (var reader = File.OpenText(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}