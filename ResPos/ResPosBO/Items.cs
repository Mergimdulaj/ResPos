using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ResPosBO
{
    public class Items
    {
        public int Item_id { get; set;}
        public int Tax_id { get; set; }
        public string ItemName { get; set; }
        public int Category_id { get; set; }
        public decimal Price { get; set; }

    }
}
