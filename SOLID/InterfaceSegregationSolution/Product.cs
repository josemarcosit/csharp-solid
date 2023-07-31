namespace InterfaceSegregationSolution
{
    public class Product : ITransaction
    {
        public void Save()
        {
            Console.WriteLine("Product: Save");
        }

        public void Validate()
        {
            Console.WriteLine("Product: Validate");
        }
    }
}
