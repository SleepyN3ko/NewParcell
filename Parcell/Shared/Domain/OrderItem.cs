using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class OrderItem
    {
        public int Id { get; set; }
        //stores the id of the product the orderitem refers to
        public int Product_id { get; set; }
        //stores a snapshot of the product_price so that even if the product price changes it will record down the price u ordered the product at
        public int Product_Price { get; set; }
        //stores the quantity of the product you ordered
        public int Product_Quantity { get; set; }
        //enables the product to be stored as part of the orderitem after retrieving product and orderitem seperately
        public virtual Product Product { get; set; }
        //stores the id of the order the orderitem belongs to
        public int Order_id { get; set; }
        //enables the product to be stored as part of the orderitem after retrieving order and orderitem seperately
        public virtual Order Order { get; set; }
    }
}
