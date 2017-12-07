using System.Linq;

namespace LetterDWrong
{
    internal class MailingLogic
    {
        private readonly EmailAddressFileReader _emailAddressFileReader = new EmailAddressFileReader();
        private readonly EmailAddressValidator _emailAddressValidator = new EmailAddressValidator();
        private readonly EmailSender _emailSender = new EmailSender();

        public void ProcessMailing(string filepath)
        {
            var addresses = _emailAddressFileReader.ReadMailAddressesFromFile(filepath);

            foreach (var emailAddress in addresses.Where(a => _emailAddressValidator.IsValid(a)))
            {
                _emailSender.SendMail(emailAddress, "Default: Hello SOLID", "This is the default content body for hello SOLID");
            }
        }
    }
}