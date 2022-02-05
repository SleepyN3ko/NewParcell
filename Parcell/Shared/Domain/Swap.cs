using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class Swap
    {
        public int Id { get; set; }
        //stores whether the swapper has accepted the swap
        public Boolean SStatus { get; set; }
        //stores whether the product owner has accepted the swap
        public Boolean PStatus { get; set; }
        //stores the date of creation of the swap
        public DateTime Date { get; set; }
        //stores the id of the product which the swapper has chosen to swap with
        [Required]
        public int SProduct_id { get; set; }
        //stores how many of his product the swapper wants to swap
        [Required]
        [Range(1,1000000)]
        public int SProduct_quantity { get; set; } = 1;
        //enables the product to be stored as part of the swap after retrieving product and swap seperately
        public virtual Product SProduct { get; set; }
        //stores the id of the product which the swapper has chosen to swap to
        public int PProduct_id { get; set; }
        //stores how many of the product the product owner needs to swap with
        [Required]
        [Range(1, 1000000)]
        public int PProduct_quantity { get; set; } = 1;
        //enables the product to be stored as part of the orderitem after retrieving product and orderitem seperately
        public virtual Product PProduct { get; set; }
    }
}
