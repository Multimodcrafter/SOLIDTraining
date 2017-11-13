using System;
using System.Net.Mail;

namespace LetterSRight
{
    internal class EmailSender
    {
        public void SendMail(string to, string subject, string body)
        {
            var mailMessage = BuildMailMessage(to, subject, body);
            SendMessage(mailMessage);
        }

        private static void SendMessage(MailMessage mailMessage)
        {
            Console.WriteLine();
            Console.WriteLine($"Sending message from:{mailMessage.From}, to:{mailMessage.To}, subject:{mailMessage.Subject}, body:{mailMessage.Body}");

            //var client = new SmtpClient("localhost")
            //{
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential("username", "password")
            //};
            //client.Send(mailMessage);
        }

        private static MailMessage BuildMailMessage(string to, string subject, string body)
        {
            return new MailMessage("solid@isolutions.ch", to)
            {
                Body = body,
                Subject = subject
            };
        }
    }
}