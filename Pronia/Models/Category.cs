using System.ComponentModel.DataAnnotations;

namespace Pronia.Models
{
    public class Category : BaseEntity
    {
        [Required,MaxLength(10,ErrorMessage ="En cox 10 element dakil ede bilersiz")]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
