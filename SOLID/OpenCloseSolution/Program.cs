namespace OpenCloseSolution
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

            var payment = new CashPayment();
            var order = new Order(1, "Bia", "bia@solid.com", orderItens, payment);

            Console.WriteLine($"Customer: {order.CustomerName} - Order: {order.Id} - Status: {order.Status}");

            var total = order.CalculateTotal();

            if (payment.ProcessPayment(total))
            {
                order.Status = OrderStatus.PaymentReceived;

                Console.WriteLine($"Customer: {order.CustomerName} - Order: {order.Id} - Status: {order.Status} - Total: {total}");
            }

            var cardPayment = new CardPayment();
            var OrderEd = new Order(2, "Ed", "ed@solid.com", orderItens, cardPayment);

            Console.WriteLine($"Customer: {OrderEd.CustomerName} - Order: {OrderEd.Id} - Status: {OrderEd.Status}");

            var totalOrderEd = OrderEd.CalculateTotal();

            if (cardPayment.ProcessPayment(total))
            {
                order.Status = OrderStatus.PaymentReceived;

                Console.WriteLine($"Customer: {OrderEd.CustomerName} - Order: {OrderEd.Id} - Status: {OrderEd.Status} - Total: {totalOrderEd}");
            }
        }
    }
}