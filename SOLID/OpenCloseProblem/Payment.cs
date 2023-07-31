namespace OpenCloseProblem
{
    public class Payment
    {
        //business logic
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment: Process {amount}");

            return true;
        }

        //data logic
    }
}
