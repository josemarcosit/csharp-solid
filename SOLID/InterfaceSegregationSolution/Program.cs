namespace InterfaceSegregationSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var supplier = new Supplier();
            supplier.Validate();
            supplier.Save();
            supplier.SendEmail();

            var product = new Product();
            product.Validate();
            product.Save();
            // product.SendEmail(); product does not send e-mail
        }
    }
}