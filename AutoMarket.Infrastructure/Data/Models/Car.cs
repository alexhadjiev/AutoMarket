using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Infrastructure.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        public string Manufacturer { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        [Required]
        public int SellerId { get; set; }
        public Seller Seller { get; set; } = null!;

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
