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

        [Required]
        [StringLength(100,MinimumLength = 5,ErrorMessage ="Product Name does not meet length requirements")]
        public string Name { get; set; }
        public string Image { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public int Stock { get; set; }
        public string Thumbnail { get; set; }

        [Required]
        public int Price { get; set; }
        [Required]
        public string P_category { get; set; }
        [Required]
        public string S_Category { get; set; }
        public string Swap_description { get; set; }

        
        public string Username { get; set; }

    }
}
