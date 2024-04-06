using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Infrastructure.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;
        public IdentityUser User { get; set; } = null!;
    }
}
