using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ResPosDAL;
using ResPosBO;

namespace ResPosBLL
{
    public class TaxBLL
    {
        public static Tax GetTaxById(int Tax_id)
        {
            return TaxDAL.GetTaxById(Tax_id);
        }
        public static DataTable GetTax()
        {
            return TaxDAL.GetTax();
        }
        public static int Add(Tax t)
        {
            return TaxDAL.Add(t);
        }
        public static int Update(Tax t)
        {
            return TaxDAL.Update(t);
        }
        public static bool Delete(Tax t)
        {
            return TaxDAL.Delete(t);
 
        }
    }
}
