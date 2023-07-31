namespace InterfaceSegregationSolution
{
    public class Supplier : ITransaction, ISendEmail
    {
        public void Save()
        {
            Console.WriteLine("Supplier: Save");
        }

        public void SendEmail()
        {
            Console.WriteLine("Supplier: SendEmail");
        }

        public void Validate()
        {
            Console.WriteLine("Supplier: Validate");
        }
    }
}