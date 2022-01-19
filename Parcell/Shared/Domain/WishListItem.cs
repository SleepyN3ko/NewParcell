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
        public DateTime Date { get; set; }
        public Boolean Status { get; set; }

        public int Product_id { get; set; }
        public virtual Product Product { get; set; }

        public int Wishlist_id { get; set; }
        public virtual WishList Wistlist { get; set; }

    }
}
