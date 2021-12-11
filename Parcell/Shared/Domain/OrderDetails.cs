using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }

    }
}
