using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class Order
    {
        public int Id { get; set; }
        //stores if the order has been paid
        public Boolean Status { get; set; }
        //stores the date of the order
        public DateTime Date { get; set; }
        //stores the total price of the order which is the sum of all the orderitems belonging to the order
        public int Total_Price { get; set; }
        //stores who created the order
        public string Username { get; set; }

    }
}
