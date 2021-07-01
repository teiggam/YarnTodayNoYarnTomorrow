using System;
using System.Collections.Generic;

#nullable disable

namespace YarnTodayStorefront.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
