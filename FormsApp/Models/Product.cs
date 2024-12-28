using System.ComponentModel.DataAnnotations;
namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name="Ürün Id")]
        public int ProductId { get; set; } 

        [Display(Name = "Ürün Adı")]
        [Required(ErrorMessage ="Gerekli bir alan")]
        [StringLength(100)]
        public string Name { get; set; }= null!;

        [Required] 
        [Range(0,100000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

    
        [Display(Name = "Resim")]
        public string? Image { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int? CategoryId { get; set; }

    }


}