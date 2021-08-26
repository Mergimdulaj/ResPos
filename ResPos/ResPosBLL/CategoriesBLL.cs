using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResPosBO;
using ResPosDAL;
namespace ResPosBLL
{
    public class CategoriesBLL
    {

          public static Categories GetCategoryById(int Category_id)
        {
            return CategoriesDAL.GetCategoryById(Category_id);
        }

        public static DataTable GetCategories()
        {
            return CategoriesDAL.GetCategories();
        }

        public static int Add(Categories c)
        {
            return CategoriesDAL.Add(c);
        }

        public static int Update(Categories c)
        {
            return CategoriesDAL.Update(c);
        }

        public static bool Delete(Categories c)
        {
            return CategoriesDAL.Delete(c);
        }

    }
}
