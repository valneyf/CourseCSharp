using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price, string name)
        {
            Quantity = quantity;
            Price = price;
            Product = new Product(name, price);
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
