using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoMarket.Infrastructure.Data.Constants.DataConstants;

namespace AutoMarket.Infrastructure.Data.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(YearMinValue,YearMaxValue)]
        public int Year { get; set; }

        [Required]
        [MaxLength(ColorMaxLength)]
        public string Color { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        [MaxLength(ManufacturerMaxLength)]
        public string Manufacturer { get; set; } = string.Empty;

        [Required]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = string.Empty;

        [Required]
        public int SellerId { get; set; }
        public Seller Seller { get; set; } = null!;

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
