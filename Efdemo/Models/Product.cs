using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Efdemo.Models
{
    [Table("Product")]
    public class Product
    {

        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Company name is required")]
        [Display(Name = "Company name")]

        public string? CompanyName { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }
    }
}
