using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNETCapstoneFinal.Models
{
    public class PurchaseOrder
    {

        public Vendor Vendor { get; set; }
        public IEnumerable<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public decimal PoTotal { get; set; }

        public PurchaseOrder() { }
    }

}