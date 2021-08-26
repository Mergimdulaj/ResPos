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
    public class PosTablesDAL
    {
        public static PosTables Get_PosTableById(int Table_Id)
        {
            PosTables i = new PosTables();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spPosTablesSelectSingleItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Table_Id", Table_Id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i.Table_Id = dr["Table_Id"] == DBNull.Value ? 0 : int.Parse(dr["Table_Id"].ToString());
                i.TableNo = dr["TableNo"] == DBNull.Value ? "" : dr["TableNo"].ToString();
                i.TableDesc = dr["TableDesc"] == DBNull.Value ? "" : dr["TableDesc"].ToString();
               
                
            }

            return i;
        }
        public static DataTable GetPosTables()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spPosTablesSelectList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }
        public static int Add(PosTables i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spPosTablesInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableNo", i.TableNo);
            cmd.Parameters.AddWithValue("@TableDesc", i.TableDesc);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic;
        }
        public static int Update(PosTables i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spPosTablesUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Table_Id", i.Table_Id);
            cmd.Parameters.AddWithValue("@TableNo", i.TableNo);
            cmd.Parameters.AddWithValue("@TableDesc", i.TableDesc);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic;
        }
        public static bool Delete(PosTables i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spPosTablesDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Table_Id", i.Table_Id);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic > 0;
        }
    }
}
