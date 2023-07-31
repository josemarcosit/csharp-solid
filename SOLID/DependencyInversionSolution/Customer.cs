namespace DependencyInversionSolution
{
    public class Customer 
    {
        private readonly IEnumerable<Email> _emails;
        private readonly IEmailSender _emailSender;
        public string Name { get; }

        public Customer(string name, IEnumerable<Email> emails, IEmailSender  emailSender)
        {
            Name = name;
            _emails = emails;
            _emailSender = emailSender;            
        }
        public void Save()
        {
            Console.WriteLine("Customer saved");
        }

        public void SendEmail()
        {

            foreach (var email in _emails)
            {
                if (email.IsValid())
                    _emailSender.Send(email.To, "Customer", "Test");
            }
        }
    }

}

