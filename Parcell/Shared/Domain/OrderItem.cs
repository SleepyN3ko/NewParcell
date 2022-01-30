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
        public int Product_id { get; set; }
        public int Product_Price { get; set; }
        public int Product_Quantity { get; set; }
        public virtual Product Product { get; set; }

        public int Order_id { get; set; }
        public virtual Order Order { get; set; }
    }
}
