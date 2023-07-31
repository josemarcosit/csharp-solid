namespace InterfaceSegregationProblem
{
    public class Supplier : ITransaction
    {
        public void Save()
        {
            Console.WriteLine("Supplier: Save");
        }

        public void Validate()
        {
            Console.WriteLine("Supplier: Validate");
        }

        public void SendEmail()
        {
            Console.WriteLine("Supplier: SendEmail");
        }
    }
}
