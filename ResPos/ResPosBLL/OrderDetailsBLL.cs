using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ResPosBO;
using ResPosDAL;

namespace ResPosBLL
{
    public class OrderDetailsBLL
    {
        public static OrderDetails Get_OrderDetailsById(int OrderDetails_id)
        {
            return OrderDetailsDAL.Get_OrderDetailsById(OrderDetails_id);
        }

        public static DataTable Get_OrderDetailsByOrder_id(int Order_id)
        {
            return OrderDetailsDAL.Get_OrderDetailsByOrder_id(Order_id);
        }
        
        public static DataTable GetOrderDetails()
        {
            return OrderDetailsDAL.GetOrderDetails();
        }
        public static int Add(OrderDetails i)
        {
            return OrderDetailsDAL.Add(i);
        }
        public static bool Delete(OrderDetails i)
        {
            return OrderDetailsDAL.Delete(i);
        }
    }
}
