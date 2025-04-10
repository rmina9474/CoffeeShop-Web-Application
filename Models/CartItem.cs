﻿using System.ComponentModel.DataAnnotations;

namespace Reina.MacCredy.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string SelectedOptions { get; set; } = "";
    }
}