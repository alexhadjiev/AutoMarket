using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoMarket.Infrastructure.Data.Constants.DataConstants;

namespace AutoMarket.Infrastructure.Data.Models

{
    public class Seller
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(AgentNameMaxLength)]
        public string FullName { get; set; } = string.Empty;
        [Required]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
