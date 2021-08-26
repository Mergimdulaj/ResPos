using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResPosBO
{
    public class Orders
    {
        public int Order_id { get; set; }
        public int User_id { get; set; }
        public int Table_Id { get; set; }
        public int OStatus_id { get; set; }
        public DateTime OrderDate { get; set; }
        
    }
}
