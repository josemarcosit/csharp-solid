namespace SingleResponsibilitySolution
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

            var order = new Order(2, "Ed", "ed@solid.com", orderItens);

            Console.WriteLine($"Order: {order.Id} - Status: {order.Status}");

            decimal payment = order.CalculateTotal();

            if (Payment.ProcessPayment(payment))
            {
                order.Status = OrderStatus.PaymentReceived;
                Console.WriteLine($"Order: {order.Id} - Status: {order.Status}");
                Email.SendEmail(order.Id, order.CustomerEmail);
            }
        }
    }
}