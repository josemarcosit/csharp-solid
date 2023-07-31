
using System.Net.Mail;

namespace DependencyInversionSolution
{
    public class SmtpSender : IEmailSender
    {
        private SmtpClient _smtpClient;

        public SmtpSender()
        {
            _smtpClient = new SmtpClient();
        }

        public void Send(string emailAddress, string subject, string message)
        {
            Console.WriteLine($"EmailSender: E-mail sent: {emailAddress} - {subject} - {message}");
            //_smtpClient.Send(emailAddress, message, subject, message);
        }
    }
}
