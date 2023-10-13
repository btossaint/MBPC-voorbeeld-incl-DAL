using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBPC001.Models
{ 
    /// <summary>
    /// Auction wordt gestart, dan worden in Lot binnen deze Auction gesorteerd
    /// Het LotId wordt dan gegenereerd. Deze worden niet meer aangepast binnen deze Auction
    /// Als het Auctionnummer in Auction is kan deze dus NIET meer worden aangepast!
    /// </summary>
    public class Auction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Auction Auctioneer { get; set; } // organisator van de Auction?
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
