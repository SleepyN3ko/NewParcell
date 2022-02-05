using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class Category
    {
        public int Id { get; set; }
        //what is the name of the category
        public string Name { get; set; }
        //description of the category
        public string Description { get; set; }
        //a sample of a product that belongs to this category look like stored as a link to the image
        public string Thumbnail { get; set; }

    }
}
