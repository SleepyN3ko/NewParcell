using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class Swap
    {
        public int Id { get; set; }

        public Boolean SStatus { get; set; }

        public Boolean PStatus { get; set; }
        public DateTime Date { get; set; }
        public int Deadline { get; set; }

        
        public virtual Product SProduct { get; set; }
        public virtual Product PProduct { get; set; }
    }
}
