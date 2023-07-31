
namespace OpenCloseSolution
{
    public class CashPayment : IPayment
    {
        public decimal CalculateTotal(decimal amount)
        {
            return amount;
        }
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment: Process {amount}");

            return true;
        }
    }
}
