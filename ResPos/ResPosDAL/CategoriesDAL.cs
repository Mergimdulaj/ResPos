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
    public class CategoriesDAL
    {

        public static Categories GetCategoryById(int Category_id)
        {
            Categories c = new Categories();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spCategorySelectSingleItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Category_id", Category_id);
            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c.Category_id = dr["Category_id"] == DBNull.Value ? 0 : int.Parse(dr["Category_id"].ToString());
                c.CategoryName = dr["CategoryName"] == DBNull.Value ? "" : dr["CategoryName"].ToString();
                c.Description = dr["Description"] == DBNull.Value ? "" : dr["Description"].ToString();
            }

            return c;
        }

        public static DataTable GetCategories()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spCategorySelectList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        public static int Add(Categories c)
        {
            int ic=0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            
            SqlCommand cmd = new SqlCommand("spCategoryInsert",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryName", c.CategoryName);
            cmd.Parameters.AddWithValue("@Description", c.Description);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic;
        }

        public static int Update(Categories c)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spCategoryUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Category_id", c.Category_id);
            cmd.Parameters.AddWithValue("@CategoryName", c.CategoryName);
            cmd.Parameters.AddWithValue("@Description", c.Description);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic;
        }

        public static bool Delete(Categories c)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spCategoryDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Category_id", c.Category_id);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic> 0;
        }


    }
}
