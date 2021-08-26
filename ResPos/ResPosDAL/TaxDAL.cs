using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ResPosBO;

namespace ResPosDAL
{
    public class TaxDAL
    {
        public static Tax GetTaxById(int Tax_id)
        {
            Tax t = new Tax();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spTaxSelectSingleItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tax_id", Tax_id);
            conn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                t.Tax_id = dr["Tax_id"] == DBNull.Value ? 0 : int.Parse(dr["Tax_id"].ToString());
                t.TaxName = dr["TaxName"] == DBNull.Value ? "" : dr["TaxName"].ToString();
                t.TaxValue = dr["TaxValue"] == DBNull.Value ? 0 : decimal.Parse(dr["TaxValue"].ToString());
            }

            return t;
        }
        public static DataTable GetTax()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spTaxSelectList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public static int Add(Tax t )
        {
            int it = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spTaxInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TaxName", t.TaxName);
            cmd.Parameters.AddWithValue("@TaxValue", t.TaxValue);
            conn.Open();

            it = cmd.ExecuteNonQuery();

            return it;
        }
        public static int Update(Tax t)
        {
            int it = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spTaxUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tax_id", t.Tax_id);
            cmd.Parameters.AddWithValue("@TaxName", t.TaxName);
            cmd.Parameters.AddWithValue("@TaxValue", t.TaxValue);
            conn.Open();

            it = cmd.ExecuteNonQuery();

            return it;
        }
        public static bool Delete(Tax t)
        {
            int it = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spTaxDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Tax_id", t.Tax_id);
            conn.Open();

            it = cmd.ExecuteNonQuery();

            return it > 0;
        }

    }
}
