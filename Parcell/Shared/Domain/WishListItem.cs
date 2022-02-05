using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class WishListItem
    {
        public int Id { get; set; }
        //date where the wishlistitem was created
        public DateTime Date { get; set; }
        //stores the id of which product the wishlistitem refers to
        public int Product_id { get; set; }
        //enables the product to be stored as part of the wishlistitem after retrieving product and wishlistitem seperately
        public virtual Product Product { get; set; }
        //stores the id of which wishlist the wishlistitem belongs to
        public int Wishlist_id { get; set; }
        //enables the wishlist to be stored as part of the wishlistitem after retrieving wishlist and wishlistitem seperately
        public virtual WishList Wistlist { get; set; }

    }
}
