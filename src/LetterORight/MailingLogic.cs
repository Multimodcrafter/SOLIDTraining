using System.Linq;

namespace LetterORight
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
                var mailContent = GetMailContentFor(emailAddress);
                _emailSender.SendMail(emailAddress, mailContent.Subject, mailContent.Body);
            }
        }

        protected virtual MailContent GetMailContentFor(string recipient)
        {
            if (recipient.Contains("@example.com"))
            {
                return new MailContent
                {
                    Subject = "example: Hello SOLID",
                    Body = "Our guests from example are the most contacted people in the world!"
                };
            }
            if (recipient.Contains("@example1.com"))
            {
                return new MailContent
                {
                    Subject = "example1: Hello SOLID",
                    Body = "Our guests from example1 have some special text!"
                };
            }
            return new MailContent
            {
                Subject = "Default: Hello SOLID",
                Body = "This is the default content body for hello SOLID"
            };
        }

        protected struct MailContent
        {
            public string Subject { get; set; }
            public string Body { get; set; }
        }
    }
}