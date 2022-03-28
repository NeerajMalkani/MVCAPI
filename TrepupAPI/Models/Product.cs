using System.ComponentModel.DataAnnotations;

namespace TrepupAPI.Models
{
    public class Product
    {
        [Required] 
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Price is Must")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Must be Nemeric")]
        public decimal Price { get; set; }
    }

    public class ProductRequest {
        public int Id { get; set; }
    }
}