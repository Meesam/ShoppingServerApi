using System.ComponentModel.DataAnnotations;

namespace ShoppingServerApi.Model
{
    public class DateClass
    {
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? ModifiedDate { get; set; }
    }
}
