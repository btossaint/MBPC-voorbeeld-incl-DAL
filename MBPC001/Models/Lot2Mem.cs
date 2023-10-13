using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPC001.Models
{
    public class Lot2Mem
    {
        public Member BuyerId { get; set; }
        public Lot LotId { get; set; }
        public DateTime TimeStamp { get; set; }
        public float Price { get; set; }

    }
}
