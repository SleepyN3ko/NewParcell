using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class SwapProduct
    {
        public int Id { get; set; }
        public Boolean Request { get; set; }
        public string Description { get; set; }
        public virtual Product Product { get; set; }

    }
}
