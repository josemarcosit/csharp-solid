using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilitySolution
{
    internal class Payment
    {
        //business logic
        public static bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment: Process {amount}");

            return true;
        }
    }
}
