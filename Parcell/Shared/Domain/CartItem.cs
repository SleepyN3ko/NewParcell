using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class CartItem
    {
        public int Id { get; set; }
        //stores when the items were created
        public DateTime Date { get; set; }
        //stores the quantity
        public int Quantity { get; set; }
        //stores the id of which product it refers to
        public int Product_id { get; set; }
        //enables the product to be stored as part of the cartitem after retrieving product and cartitem seperately
        public virtual Product Product { get; set; }
        //stores the id of which cart it belongs to
        public int Cart_id { get; set; }
        //enables the cart to be stored as part of the cartitem after retrieving cart and cartitem seperately
        public virtual Cart Cart { get; set; }

    }
}
