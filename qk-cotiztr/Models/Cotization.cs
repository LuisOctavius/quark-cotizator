using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qk_cotiztr.Models
{
    public class Cotization
    {
        public Cotization(Guid id, DateTime created, int vendorId, Garment garment, decimal total)
        {
            Id = id;
            Created = created;
            VendorId = vendorId;
            Garment = garment;
            Total = total;
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public int VendorId { get; set; }
        public Garment Garment { get; set; }
        public decimal Total { get; set; }
    }
}
