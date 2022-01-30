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
        public Boolean Status { get; set; }
        public DateTime Date { get; set; }
        public int Total_Price { get; set; }
        public string Username { get; set; }

    }
}
