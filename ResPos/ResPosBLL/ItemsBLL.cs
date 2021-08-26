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
    public class ItemsBLL
    {
        public static Items Get_ItemsById(int Item_id)
        {
            return ItemsDAL.Get_ItemsById(Item_id);
        }

        public static DataTable Get_ItemsCategory_id(int Category_id)
        {
            return ItemsDAL.Get_ItemsCategory_id(Category_id);
        }

        public static DataTable GetItems()
        {
            return ItemsDAL.GetItems();
        }
        public static int Add (Items i)
        {
           return ItemsDAL.Add(i);
        }
        public static int Update(Items i)
        {
            return ItemsDAL.Update(i);
        }
        public static bool Delete(Items i)
        {
            return ItemsDAL.Delete(i);
        }
    }
}
