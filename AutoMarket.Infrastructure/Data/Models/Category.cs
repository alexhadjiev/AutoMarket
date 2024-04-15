using System.ComponentModel.DataAnnotations;
using static AutoMarket.Infrastructure.Data.Constants.DataConstants;

namespace AutoMarket.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = string.Empty;


        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
