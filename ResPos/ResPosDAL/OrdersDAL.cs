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
    public class OrdersDAL
    {
        public static Orders Get_OrdersById(int Order_id)
        {
            Orders i = new Orders();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("[spOrdersSelectSingleOrders]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Order_id", Order_id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i.Order_id = dr["Order_id"] == DBNull.Value ? 0 : int.Parse(dr["Order_id"].ToString());
                i.User_id = dr["User_id"] == DBNull.Value ? 0 : int.Parse(dr["User_id"].ToString());
                i.OStatus_id = dr["OStatus_id"] == DBNull.Value ? 0 : int.Parse(dr["OStatus_id"].ToString());
                i.Table_Id = dr["Table_Id"] == DBNull.Value ? 0 : int.Parse(dr["Table_Id"].ToString());
                i.OrderDate = dr["OrderDate"] == DBNull.Value ? DateTime.MinValue : DateTime.Parse(dr["OrderDate"].ToString());
            }

            return i;
        }
        public static DataTable GetOrderOpenByTableId(int Table_Id)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spOrdersSelectListOpenByTableId", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Table_Id", Table_Id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public static DataTable GetOrders()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spOrdersSelectList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        public static DataTable GetOrdersReport(int? User_id,DateTime? OrderDateFrom, DateTime? OrderDateTo)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spOrderDaylyReportByUser_id", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (User_id.HasValue)
            {
                cmd.Parameters.AddWithValue("@User_id", User_id);
            }
            if (OrderDateFrom.HasValue)
            {
                cmd.Parameters.AddWithValue("@OrderDateFrom", OrderDateFrom);
            }

            if (OrderDateTo.HasValue)
            {
                cmd.Parameters.AddWithValue("@OrderDateTo", OrderDateTo);
            }

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }


        public static int Add(Orders i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spOrdersInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_id", i.User_id);
            cmd.Parameters.AddWithValue("@Table_Id", i.Table_Id);

            SqlParameter p = new SqlParameter();
            p.ParameterName = "@Order_id";
            p.Direction = ParameterDirection.Output;
            p.Value = 0;
            cmd.Parameters.Add(p);
            conn.Open();

            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@Order_id"].Value != DBNull.Value)
            {
                ic = Convert.ToInt32(cmd.Parameters["@Order_id"].Value);
                i.Order_id = ic;
            }

            return ic;
        }

        public static int Close(Orders i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spOrderClose", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter();
            p.ParameterName = "@Order_id";
            p.Direction = ParameterDirection.InputOutput;
            p.Value = i.Order_id;
            cmd.Parameters.Add(p);
            conn.Open();

            cmd.ExecuteNonQuery();
            if (cmd.Parameters["@Order_id"].Value != DBNull.Value)
            {
                ic = Convert.ToInt32(cmd.Parameters["@Order_id"].Value);
                i.Order_id = ic;
            }

            return ic;
        }

        public static bool Delete(Orders i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spOrdersDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Order_id", i.Order_id);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic > 0;
        }

    }
}