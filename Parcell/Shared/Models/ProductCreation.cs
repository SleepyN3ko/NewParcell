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
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name ="Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Stock")]
        [RegularExpression(@"[0-9]",ErrorMessage ="Enter numbers")]
        public int Stock { get; set; }

        [Required]
        [Display(Name = "Price")]
        [RegularExpression(@"[0-9]", ErrorMessage = "Enter numbers")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Select a category")]
        public string Category { get; set; }

        [Required]
        public string Username { get; set; }
    }
}
