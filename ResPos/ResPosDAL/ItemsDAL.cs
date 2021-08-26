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
   public  class ItemsDAL
    {
       public static Items Get_ItemsById(int Item_id)
       {
           Items i = new Items();
           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
           SqlCommand cmd = new SqlCommand("[spItemsSelectSingleItems]", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@Item_id", Item_id);
           conn.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           while (dr.Read())
           {
               i.Item_id = dr["Item_id"] == DBNull.Value ? 0 : int.Parse(dr["Item_id"].ToString());
               i.Tax_id = dr["Tax_id"] == DBNull.Value ? 0 : int.Parse(dr["Tax_id"].ToString());
               i.ItemName = dr["ItemName"] == DBNull.Value ? "" : dr["ItemName"].ToString();
               i.Category_id = dr["Category_id"] == DBNull.Value ? 0 : int.Parse(dr["Category_id"].ToString());
               i.Price = dr["Price"] == DBNull.Value ? 0 : decimal.Parse(dr["Price"].ToString());
           }

           return i;
       }
       public static DataTable GetItems()
       {
           DataTable dt = new DataTable();

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spItemsSelectList", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           conn.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           dt.Load(dr);
           return dt;
       }

       public static DataTable Get_ItemsCategory_id(int Category_id)
       {
           DataTable dt = new DataTable();

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spItemsSelectItemsByCategory_id", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@Category_id", Category_id);
           conn.Open();
           SqlDataReader dr = cmd.ExecuteReader();
           dt.Load(dr);
           return dt;
       }


       public static int Add(Items i)
       {
           int ic = 0;

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spItemsInsert", conn);
           cmd.CommandType = CommandType.StoredProcedure;  
           cmd.Parameters.AddWithValue("@ItemName", i.ItemName);
           cmd.Parameters.AddWithValue("@Tax_id", i.Tax_id);
           cmd.Parameters.AddWithValue("@Category_Id", i.Category_id);
           cmd.Parameters.AddWithValue("@Price", i.Price);
           conn.Open();

           ic = cmd.ExecuteNonQuery();

           return ic;
       }
       public static int Update(Items i)
       {    
           int ic = 0;

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spItemsUpdate", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@Item_id", i.Item_id);
           cmd.Parameters.AddWithValue("@Tax_id", i.Tax_id);
           cmd.Parameters.AddWithValue("@ItemName", i.ItemName);
           cmd.Parameters.AddWithValue("@Category_id", i.Category_id);
           cmd.Parameters.AddWithValue("@Price", i.Price);
           conn.Open();

           ic = cmd.ExecuteNonQuery();

           return ic;
       }
       public static bool Delete(Items i)
       {
           int ic = 0;

           SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

           SqlCommand cmd = new SqlCommand("spItemsDelete", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@Item_id", i.Item_id);
           conn.Open();

           ic = cmd.ExecuteNonQuery();

           return ic > 0;
       }

    }
}
