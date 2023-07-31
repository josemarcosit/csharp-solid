using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilitySolution
{
    internal class Email
    {
        public static void SendEmail(int orderId, string email)
        {
            Console.WriteLine($"Email: SendEmail {orderId} - {email}");
        }
    }
}
