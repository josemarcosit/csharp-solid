namespace DependencyInversionSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emails = new List<Email>() {
                new Email() { From = "ed", To = "bia@solid.com"  }, //invalid
                new Email() { From = "ed@solid.com", To = "bia@solid.com"  },
                new Email() { From = "bia@solid.com", To = "ed@solid.com"  },
                new Email() { From = "ed@solid.com", To = "bia"  } //invalid
            };

            IEmailSender emailSender = new SmtpSender();
            var customer = new Customer("Andrea", emails, emailSender);
            customer.Save();
            customer.SendEmail();          
        }
    }
}