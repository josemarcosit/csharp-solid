namespace InterfaceSegregationProblem
{
    public class Product : ITransaction
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void Validate()
        {
            Console.WriteLine("Product: Validate");
        }

        public void Save()
        {
            Console.WriteLine("Product: Save");
        }

        public void SendEmail() => throw new NotSupportedException("Product does not send e-mail");
    }

}
