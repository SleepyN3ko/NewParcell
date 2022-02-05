using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class WishList
    {
        public int Id { get; set; }
        //date where the wishlist was created
        public DateTime Date { get; set; }
        //who the wishlist belongs to
        public string Username { get; set; }


    }
}
