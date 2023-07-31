namespace DependencyInversionProblem
{
    public class Customer
    {
        private readonly IEnumerable<Email> _emails;
        private readonly EmailSender _emailSender;
        public Customer(string name, IEnumerable<Email> emails, EmailSender emailSender)
        {
            _emails = emails;
            _emailSender = emailSender;
        }
        public void SendEmail()
        {

            foreach (var email in _emails)
            {
                if (email.IsValid())
                {
                    _emailSender.Send(email.To, "Customer", "Test");
                    
                }
            }
        }

        public void Save()
        {
            Console.WriteLine("Customer: Save");
        }
    }

}

