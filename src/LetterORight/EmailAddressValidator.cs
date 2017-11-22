using System.Text.RegularExpressions;

namespace LetterORight
{
    public class EmailAddressValidator : IEmailAddressValidator
    {
        private readonly Regex _regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]+$");

        public bool IsValid(string emailAddress)
        {
            return _regex.IsMatch(emailAddress);
        }
    }
}