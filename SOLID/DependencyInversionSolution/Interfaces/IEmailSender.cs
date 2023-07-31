namespace DependencyInversionSolution
{
    public interface IEmailSender
    {
        void Send(string emailAddress, string subject, string message);
    }
}
