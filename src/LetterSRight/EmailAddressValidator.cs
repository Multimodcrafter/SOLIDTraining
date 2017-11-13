using System.Text.RegularExpressions;

namespace LetterSRight
{
    internal class EmailAddressValidator
    {
        private readonly  Regex regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]+$");

        public bool IsValid(string emailAddress)
        {
            return regex.IsMatch(emailAddress);
        }
    }
}