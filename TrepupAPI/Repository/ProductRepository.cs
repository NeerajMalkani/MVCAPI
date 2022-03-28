using System;
using System.Collections.Generic;
using System.Data;
using TrepupAPI.Models;

namespace TrepupAPI.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducDetails(ProductRequest objparam);
    }
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducDetails(ProductRequest objparam)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Tomato soup", Category = "Groceries", Price = 1.39M });
            products.Add(new Product { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            products.Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
            return products;
        }
    }
}