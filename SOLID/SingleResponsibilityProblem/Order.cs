using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityProblem
{
    internal class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        private readonly IList<OrderItem> _orderItens;

        public Order(int Id, string customerName, string customerEmail, IList<OrderItem> orderItens)
        {
            this.Id = Id;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            _orderItens = orderItens;
        }

        //business logic
        public decimal CalculateTotal()
        {
            return _orderItens.Sum(item => item.Price * item.Quantity);
        }
        public void ProcessPayment(decimal amount)
        {
            Status = OrderStatus.PaymentReceived;

            Console.WriteLine($"Order: {Id} - ProcessPayment: {amount}");
        }
        public void SendEmail(string email)
        {
            Console.WriteLine($"Order: {Id} - SendEmail: {email}");
        }

        //data logic
        public static void Save(Order order) => Console.WriteLine($"Order: Save {order.Id}");
        public static void Update(Order order) => Console.WriteLine($"Order: Update {order.Id}");
    }
}
