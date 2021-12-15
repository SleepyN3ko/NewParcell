using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string username { get; set; }
        public virtual Product Product { get; set; }
        public virtual PaymentDetail PaymentDetails { get; set; }

    }
}
