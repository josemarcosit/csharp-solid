
namespace OpenCloseSolution
{
    public class CardPayment : IPayment
    {
        private const decimal CARD_TAX = 1.5M;   
  
        public decimal CalculateTotal(decimal amount)
        {
            return amount * CARD_TAX;
        }
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment: Process {amount}");

            return true;
        }
    }
}
