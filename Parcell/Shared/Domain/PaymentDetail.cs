using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class PaymentDetail
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public virtual User User { get; set; }

    }
}
