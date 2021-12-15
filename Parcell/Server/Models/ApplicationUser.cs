using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcell.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
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
