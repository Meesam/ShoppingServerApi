using System.ComponentModel.DataAnnotations;

namespace ShoppingServerApi.Model
{
    public class Category : DateClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
    }
}
