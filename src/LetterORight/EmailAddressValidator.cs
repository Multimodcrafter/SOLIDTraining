using System.Text.RegularExpressions;

namespace LetterORight
{
    internal class EmailAddressValidator
    {
        private readonly Regex _regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]+$");

        public bool IsValid(string emailAddress)
        {
            var additionalChecks = OnIsValid(emailAddress);
            return _regex.IsMatch(emailAddress) && additionalChecks;
        }

        protected virtual bool OnIsValid(string emailAddress)
        {
            return true;
        }
    }
}