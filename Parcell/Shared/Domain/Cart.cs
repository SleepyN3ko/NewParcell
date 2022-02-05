using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    //Cart is the intermediate model made to interface the many to many relationship between user and cartitems
    public class Cart
    {
        public int Id { get; set; }
        //Stores data of creation
        public DateTime Date { get; set; }
        //Stores who the cart belongs to
        public string Username { get; set; }


    }
}
