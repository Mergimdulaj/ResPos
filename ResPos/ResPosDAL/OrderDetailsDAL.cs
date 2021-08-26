using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ResPosBO;

namespace ResPosDAL
{
    public class OrderDetailsDAL
    {
        public static OrderDetails Get_OrderDetailsById(int OrderDetails_id)
        {
            OrderDetails i = new OrderDetails();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spOrderDetailsSelectSingleItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@OrderDetails_id", OrderDetails_id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i.Order_id = dr["Order_id"] == DBNull.Value ? 0 : int.Parse(dr["Order_id"].ToString());
                i.OrderDetails_id = dr["OrderDetails_id"] == DBNull.Value ? 0 : int.Parse(dr["OrderDetails_id"].ToString());
                i.Item_id = dr["Item_id"] == DBNull.Value ? 0 : int.Parse(dr["Item_id"].ToString());
                i.Quantity = dr["Quantity"] == DBNull.Value ? 0 : int.Parse(dr["Quantity"].ToString());
                i.TotalTax = dr["TotalTax"] == DBNull.Value ? 0 : decimal.Parse(dr["TotalTax"].ToString());
                i.TotalTax = dr["TotalPrice"] == DBNull.Value ? 0 : decimal.Parse(dr["TotalPrice"].ToString());
            }

            return i;
        }

        public static DataTable Get_OrderDetailsByOrder_id(int Order_id)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spOrderDetailsSelectListByOrder_id", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Order_id", Order_id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

       
       public static DataTable GetOrderDetails()
       {
           DataTable dt = new DataTable();

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spOrderDetailsSelectList", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           conn.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           dt.Load(dr);
           return dt;
       }

       public static int Add(OrderDetails i)
       {
           int ic = 0;

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spOrderDetailsInsert", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@Order_id", i.Order_id);
           cmd.Parameters.AddWithValue("@Item_id", i.Item_id);
           cmd.Parameters.AddWithValue("@Quantity", i.Quantity);
           conn.Open();
           ic = cmd.ExecuteNonQuery();
           return ic;
       }
       
       public static bool Delete(OrderDetails i)
       {
           int ic = 0;

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spOrderDetailsDelete", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@OrderDetails_id", i.OrderDetails_id);
           conn.Open();

           ic = cmd.ExecuteNonQuery();

           return ic > 0;
       }

    }
}
