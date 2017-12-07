namespace LetterDRight
{
    public interface IEmailSender
    {
        void SendMail(string to, string subject, string body);
    }
}