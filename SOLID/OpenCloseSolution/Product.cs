using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCloseSolution
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public static IEnumerable<Product> GetProducts()
        {
            return new[]
            {
                new Product(1, "Mouse", 9.99M),
                new Product(2, "Keyboard",  19.99M),
                new Product(3, "Microphone ", 30.59M),
            };
        }
    }
}
