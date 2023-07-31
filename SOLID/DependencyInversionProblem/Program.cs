namespace DependencyInversionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var emails = new List<Email>() {
                new Email() { },
                new Email() { From = "ed@solid.com", To = "bia@solid.com" }
            };
            var emailSender = new EmailSender();
            var customer = new Customer("Andrea", emails, emailSender);
            customer.Save();
            customer.SendEmail();
        }
    }
}