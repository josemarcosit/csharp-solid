using System.Net.Mail;

namespace DependencyInversionProblem
{
    public class EmailSender
    {
        private SmtpClient _smtpClient;

        public EmailSender()
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

