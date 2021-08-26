using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResPosBO;
using ResPosDAL;
namespace ResPosBLL
{
    public class UsersBLL
    {
        public static Users Get_UsersById(int User_id)
        {
            return UsersDAL.Get_UsersById(User_id);
        }

        public static DataTable GetUsers()
        {
            return UsersDAL.GetUsers();
        }

        public static DataTable GetUserRole(int User_id)
        {
            return UsersDAL.GetUserRole(User_id);
        }

        public static DataTable GetRoles()
        {
            return UsersDAL.GetRoles();
        }
        public static int Add(Users c)
        {
            return UsersDAL.Add(c);
        }

        public static int Update(Users c)
        {
            return UsersDAL.Update(c);
        }

        public static bool Delete(Users c)
        {
            return UsersDAL.Delete(c);
        }

        public static Users UserValidate(string Username, string Password)
        {
            return UsersDAL.UserValidate(Username, Password);
        }


    }
}
