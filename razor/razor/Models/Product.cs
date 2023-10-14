using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace razor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "please enter your product name ")]
        [DisplayName("Product Name")]
        public string? ProductName { get; set; }
        [Required(ErrorMessage = "please enter your product Price ")]
        public double Price { get; set; }
        [Required(ErrorMessage = "please enter your product quantity ")]
        public int Qty { get; set; }

        public string successMessage = "";
    }
}
