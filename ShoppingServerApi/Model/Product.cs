using System.ComponentModel.DataAnnotations;

namespace ShoppingServerApi.Model
{
    public class Product : DateClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? Category { get; set; }
    }

}
