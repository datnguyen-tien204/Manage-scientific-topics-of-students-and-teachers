using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GetInfor_From_Batch:DataProvider
    {
        DataTable dt;
        public DataTable getStatusInfor(int year)
        {
            string query = "PROC_DotDangKi @Nam";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { year });
            return dt;
        }
    }
}
