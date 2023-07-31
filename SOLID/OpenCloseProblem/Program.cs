namespace OpenCloseProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Product.GetProducts().ToList();

            var orderItens = new List<OrderItem>()
            {
                new OrderItem() { Id = products[0].Id, Price = products[0].Price, Quantity = 2  },
                new OrderItem() { Id = products[1].Id, Price = products[1].Price, Quantity = 2  },
                new OrderItem() { Id = products[2].Id, Price = products[2].Price, Quantity = 2  }
            };

            var order = new Order(2, "Ed", "ed@solid.com", orderItens, PaymentType.Cash);

            Console.WriteLine($"Customer: {order.CustomerName} - Order: {order.Id} - Status: {order.Status}");

            var total = order.CalculateTotal();

            var cardPayment = new Payment();

            if (cardPayment.ProcessPayment(total))
            {
                order.Status = OrderStatus.PaymentReceived;

                Console.WriteLine($"Customer: {order.CustomerName} - Order: {order.Id} - Status: {order.Status} - Total: {total}");
            }
        }
    }
}