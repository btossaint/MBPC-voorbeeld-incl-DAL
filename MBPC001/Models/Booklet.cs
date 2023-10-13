using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPC001.Models
{
    public class Booklet
    {
        public int Id { get; set; } // in DB bookletID ??
        public string Name { get; set; }
        public string Description { get; set; }
        public string Pane { get; set; }
    }
}
