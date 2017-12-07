using System;

namespace LetterDRight
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            try
            {
                var filePath = "MailListFile.txt";

                // orchestration on the top level of the application
                // dependencies are explicitly visible
                // This may be solved by a DI-Container but it works as well when done in code.
                var emailSender = new EmailSender();
                var emailAddressValidator = new EmailAddressValidator();
                var emailAddressFileReader = new EmailAddressFileReader(filePath);

                var logic = new MailingLogic(emailSender, emailAddressValidator, emailAddressFileReader);
                logic.ProcessMailing();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}