
namespace OpenCloseSolution
{
    internal class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        private readonly IList<OrderItem> _orderItens;
        private readonly IPayment _payment;

        public Order(int Id, string customerName, string customerEmail, IList<OrderItem> orderItens, IPayment payment)
        {
            this.Id = Id;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            _orderItens = orderItens;
            _payment = payment;
        }

        //business logic
        public decimal CalculateTotal()
        {
            decimal subtotal = _orderItens.Sum(item => item.Price * item.Quantity);

            return _payment.CalculateTotal(subtotal);

        }

        //data logic
        public Order Save(Order order)
        {
            Console.WriteLine($"Order: Save {order.Id}");

            return order;
        }

        public Order Update(Order order)
        {
            Console.WriteLine($"Order: Update {order.Id}");

            return order;
        }
    }
}
