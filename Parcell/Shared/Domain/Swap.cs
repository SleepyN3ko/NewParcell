using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string S_username { get; set; }
        [Required]
        public int SProduct_id { get; set; }
        public virtual Product SProduct { get; set; }
        public string P_username { get; set; }
        public int PProduct_id { get; set; }
        public virtual Product PProduct { get; set; }
    }
}
