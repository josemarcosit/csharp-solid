using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseProblem
{
    internal class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        private readonly IList<OrderItem> _orderItens;
        private readonly PaymentType _paymentType;

        public Order(int Id, string customerName, string customerEmail, IList<OrderItem> orderItens, PaymentType paymentType)
        {
            this.Id = Id;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            _orderItens = orderItens;
            _paymentType = paymentType;
        }

        //business logic
        public decimal CalculateTotal()
        {
            decimal subtotal = _orderItens.Sum(item => item.Price * item.Quantity);

            if (_paymentType == PaymentType.Cash)
            {
                Console.WriteLine($"Payment: {_paymentType} - CalculateTotal()");
            }
            else if (_paymentType == PaymentType.Card)
            {
                Console.WriteLine($"Payment: {_paymentType} - CalculateTotal()");

                return subtotal *= 1.05M;
            }

            return subtotal;

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
