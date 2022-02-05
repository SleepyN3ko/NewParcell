using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class Product
    {

        public int Id { get; set; }
        //stores the name of the product
        [Required]
        [StringLength(100,MinimumLength = 5,ErrorMessage ="Product Name does not meet length requirements")]
        public string Name { get; set; }
        //stores a link to the product image
        public string Image { get; set; }
        //stores a description of the product
        [Required]
        public string Description { get; set; }
        //stores how many products does the product owner have
        [Required]
        [Range(1, 1000000)]
        public int Stock { get; set; }
        //stores how much each one of the product costs
        [Required]
        [Range(1,1000000000)]
        public int Price { get; set; }
        //stores the category the product belongs to as a string for faster access
        [Required]
        public string P_category { get; set; }
        //stores the swap category the product belongs to as a string for faster access
        [Required]
        public string S_Category { get; set; }
        //stores the description of what the owner would like to swap with
        public string Swap_description { get; set; }
        //stores who the product belongs to
        public string Username { get; set; }

    }
}
