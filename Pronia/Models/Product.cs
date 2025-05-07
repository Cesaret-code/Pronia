using System.ComponentModel.DataAnnotations;

namespace Pronia.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        [Required,MaxLength(25,ErrorMessage="Maximum uzunluq 25 ola biler")]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public List<ProductImage>? Images { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<TagProducts>? TagProducts { get; set; }

    }
}
