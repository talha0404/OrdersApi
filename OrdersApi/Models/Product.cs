﻿namespace OrdersApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }


        public int CategoryId { get; set; } // Category FK
        public Category Category { get; set; } // Product can be included in one category
        public ICollection<OrderDetail> OrderDetails { get; set; } // Product can be included more than one OrderDetails
    }
}
