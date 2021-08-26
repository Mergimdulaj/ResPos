using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResPosBO;

namespace ResPosDAL
{
    public class UsersDAL
    {
        public static Users Get_UsersById(int User_id)
        {
            Users i = new Users();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spUsersSelectSingleUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_id", User_id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i.User_id = dr["User_id"] == DBNull.Value ? 0 : int.Parse(dr["User_id"].ToString());
                i.Username = dr["Username"] == DBNull.Value ? "" : dr["Username"].ToString();
                i.Role_id = dr["Role_id"] == DBNull.Value ? 0 : int.Parse(dr["Role_id"].ToString());
            }

            return i;
        }

        public static Users UserValidate(string Username, string Password)
        {
            Users i = new Users();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spUserValidate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i.User_id = dr["User_id"] == DBNull.Value ? 0 : int.Parse(dr["User_id"].ToString());
                i.Username = dr["Username"] == DBNull.Value ? "" : dr["Username"].ToString();
            }

            return i;
        }

        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spUserSelectList", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        public static DataTable GetUserRole(int User_id)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spUserRoleSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_id", User_id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        public static DataTable GetRoles()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spRolesSelect", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        public static int Add(Users i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spUserInsert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", i.Username);

            if (!string.IsNullOrEmpty(i.Password))
            {
                cmd.Parameters.AddWithValue("@Password", i.Password);
            }

            cmd.Parameters.AddWithValue("@Role_id", i.Role_id);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic;
        }
        public static int Update(Users i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spUserUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_id", i.User_id);
            cmd.Parameters.AddWithValue("@Role_id", i.Role_id);
            cmd.Parameters.AddWithValue("@Password", i.Password);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic;
        }
        public static bool Delete(Users i)
        {
            int ic = 0;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);

            SqlCommand cmd = new SqlCommand("spUserDelete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_id", i.User_id);
            conn.Open();

            ic = cmd.ExecuteNonQuery();

            return ic > 0;
        }



    }
}
