using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    //Basically an equivalent of a balance as the name suggests, it stores our own form of currency PCoins
    public class Balance
    {
        public int Id { get; set; }
        //Money is stored as a integer as every our currency Pcoins can only be added as an integer
        public int Amount { get; set; }
        //Foreign key to refer to which user it belongs to
        public string Username { get; set; }
    }
}
