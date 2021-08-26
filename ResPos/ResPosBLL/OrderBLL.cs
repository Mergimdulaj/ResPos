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
    public class OrderBLL
    {
        public static Orders Get_OrdersById(int Order_id)
        {
            return OrdersDAL.Get_OrdersById(Order_id);
        }
        public static DataTable GetOrderOpenByTableId(int Table_Id)
        {
            return OrdersDAL.GetOrderOpenByTableId(Table_Id);
        }
        public static DataTable GetOrders()
        {
            return OrdersDAL.GetOrders();
        }
        public static DataTable GetOrdersReport(int? User_id, DateTime? OrderDate)
        {
            return OrdersDAL.GetOrdersReport(User_id, OrderDate, OrderDate);
        }


        public static DataTable GetOrdersReport(int? User_id, DateTime? OrderDateFrom, DateTime? OrderDateTo)
        {
            return OrdersDAL.GetOrdersReport(User_id, OrderDateFrom, OrderDateTo);
        }

        public static int Add(Orders i)
        {
            return OrdersDAL.Add(i);
        }

        public static int Close(Orders i)
        {
            return OrdersDAL.Close(i);
        }

        public static bool Delete(Orders i)
        {
            return OrdersDAL.Delete(i);
        }
    }
}
