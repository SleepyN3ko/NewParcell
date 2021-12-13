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
        public DateTime Date { get; set; }
        public virtual User User { get; set; }  


    }
}
