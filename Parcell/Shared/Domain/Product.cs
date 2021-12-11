using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Thumbnail { get; set; }
        public int Price { get; set; }
        public string P_category { get; set; }
        public string Swap_description { get; set; }

        public virtual User User { get; set; }

    }
}
