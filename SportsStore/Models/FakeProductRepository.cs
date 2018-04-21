﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository:IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {
                Name = "Kayak", Description = "A boat for one person",
                Category = "Watersports", Price = 275 },
            new Product {
                Name = "Lifejacket",
                Description = "Protective and fashionable",
                Category = "Watersports", Price = 48.95m },
            new Product {
                Name = "Soccer Ball",
                Description = "FIFA-approved size and weight",
                Category = "Soccer", Price = 19.50m },
            new Product {
                Name = "Corner Flags",
                Description = "Give your playing field a professional touch",
                Category = "Soccer", Price = 34.95m },
            new Product {
                Name = "Stadium",
                Description = "Flat-packed 35,000-seat stadium",
                Category = "Soccer", Price = 79500 },
            new Product {
                Name = "Thinking Cap",
                Description = "Improve brain efficiency by 75%",
                Category = "Chess", Price = 16 },
            new Product {
                Name = "Unsteady Chair",
                Description = "Secretly give your opponent a disadvantage",
                Category = "Chess", Price = 29.95m }
        }.AsQueryable<Product>();
    }
}
