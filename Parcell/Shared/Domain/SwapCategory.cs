using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class SwapCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
    }
}
