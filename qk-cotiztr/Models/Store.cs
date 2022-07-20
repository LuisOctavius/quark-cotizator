using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qk_cotiztr.Models
{
    public class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IEnumerable<Garment> GarmentsOnSale { get; set; }
        public Vendor Vendor { get; set; }
    }
}
