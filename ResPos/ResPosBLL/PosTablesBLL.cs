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
    public class PosTablesBLL
    {
        public static PosTables Get_PosTableById(int Table_Id)
        {
            return PosTablesDAL.Get_PosTableById (Table_Id);
        }
        public static DataTable GetPosTables()
        {
            return PosTablesDAL.GetPosTables();
        }
        public static int Add(PosTables i)
        {
            return PosTablesDAL.Add(i);

        }
        public static int Update(PosTables i)
        {
            return PosTablesDAL.Update(i);

        }
        public static bool Delete(PosTables i)
        {
            return PosTablesDAL.Delete(i);
        }
    }
}
