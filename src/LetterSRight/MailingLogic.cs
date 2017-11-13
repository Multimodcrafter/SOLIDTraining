using System.Linq;

namespace LetterSRight
{
    internal class MailingLogic
    {
        private readonly EmailAddressFileReader emailAddressFileReader = new EmailAddressFileReader();
        private readonly EmailAddressValidator emailAddressValidator = new EmailAddressValidator();
        private readonly EmailSender emailSender = new EmailSender();

        public void ProcessMailing(string filepath)
        {
            var addresses = emailAddressFileReader.ReadMailAddressesFromFile(filepath);

            foreach (var emailAddress in addresses.Where(a => emailAddressValidator.IsValid(a)))
            {
                var mailContent = GetMailContentFor(emailAddress);
                emailSender.SendMail(emailAddress, mailContent.Subject, mailContent.Body);
            }
        }

        private MailContent GetMailContentFor(string recipient)
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

        private struct MailContent
        {
            public string Subject { get; set; }
            public string Body { get; set; }
        }
    }
}