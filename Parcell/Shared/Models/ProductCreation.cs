using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Parcell.Shared.Models
{
    public class ProductCreation
    {


        [Required]
        [Display(Name="username")]
        public string username { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name ="Description")]
        public string Description { get; set; }

        [Display(Name="Image")]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Stock")]
        [RegularExpression(@"^\d+$", ErrorMessage ="Enter numbers")]
        public int Stock { get; set; }

        [Required]
        [Display(Name = "Price")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Enter numbers")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Select a category")]
        public string P_Category { get; set; }
    }
}
