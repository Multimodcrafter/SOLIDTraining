using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace LetterSWrong
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            try
            {
                if (!File.Exists("MailListFile.txt"))
                {
                    return;
                }

                var emailAddresses = new List<string>();
                using (var reader = File.OpenText("MailListFile.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        emailAddresses.Add(line);
                    }
                }

                foreach (var emailAddress in emailAddresses)
                {
                    var regex = new Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]+$");
                    if (!regex.IsMatch(emailAddress))
                    {
                        continue;
                    }

                    string body;
                    string subject;
                    if (emailAddress.Contains("@example.com"))
                    {
                        subject = "example: Hello SOLID";
                        body = "Our guests from example are the most contacted people in the world!";
                    }
                    else if (emailAddress.Contains("@example1.com"))
                    {
                        subject = "example1: Hello SOLID";
                        body = "Our guests from example1 have some special text!";
                    }
                    else
                    {
                        subject = "Default: Hello SOLID";
                        body = "This is the default content body for hello SOLID";
                    }

                    var mailMessage = new MailMessage("solid@isolutions.ch", emailAddress)
                    {
                        Body = body,
                        Subject = subject
                    };

                    Console.WriteLine();
                    Console.WriteLine($"Sending message from:{mailMessage.From}, to:{mailMessage.To}, subject:{mailMessage.Subject}, body:{mailMessage.Body}");

                    //var client = new SmtpClient("localhost")
                    //{
                    //    UseDefaultCredentials = false,
                    //    Credentials = new NetworkCredential("username", "password")
                    //};
                    //client.Send(mailMessage);
                }
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