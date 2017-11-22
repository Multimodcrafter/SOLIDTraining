namespace LetterORight
{
    public interface IEmailSender
    {
        void SendMail(string to, string subject, string body);
    }
}