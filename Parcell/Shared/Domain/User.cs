using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcell.Shared.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }
        public string Fullname { get; set; }
        public string DateOfBirth { get; set; }
        public string Country { get; set; }
        public int Phone { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
        public int AmountOfCoins { get; set; }


    }
}
