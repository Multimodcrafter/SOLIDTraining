using System;

namespace LetterORight
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            try
            {
                var filePath = "MailListFile.txt";
                var logic = new MailingLogic(new EmailSender(), new EmailAddressValidator(), new EmailAddressFileReader(filePath));
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