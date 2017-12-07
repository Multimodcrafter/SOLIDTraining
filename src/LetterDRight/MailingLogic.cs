using System.Linq;

namespace LetterDRight
{
    public class MailingLogic
    {
        private readonly IEmailAddressProvider _emailAddressProvider;
        private readonly IEmailAddressValidator _emailAddressValidator;
        private readonly IEmailSender _emailSender;

        public MailingLogic(IEmailSender emailSender, IEmailAddressValidator emailAddressValidator, IEmailAddressProvider emailAddressProvider)
        {
            _emailSender = emailSender;
            _emailAddressValidator = emailAddressValidator;
            _emailAddressProvider = emailAddressProvider;
        }

        public void ProcessMailing()
        {
            var addresses = _emailAddressProvider.GetMailAddresses();

            foreach (var emailAddress in addresses.Where(a => _emailAddressValidator.IsValid(a)))
            {
                _emailSender.SendMail(emailAddress, "Default: Hello SOLID", "This is the default content body for hello SOLID");
            }
        }

    }
}