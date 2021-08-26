using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResPosBO
{
    public class OrderDetails
    {
        public int OrderDetails_id { get; set; }
        public int Order_id { get; set; }
        public int Item_id { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalPrice { get; set; }

        public int Quantity { get; set; }
        
    }
}
