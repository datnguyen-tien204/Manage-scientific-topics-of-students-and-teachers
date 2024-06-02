using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account_Auth: DataProvider
    {
        DataTable dt;
        public bool LoginAuthentication(string username, string password, int permision )
        {
                string query = "PROC_GetLoginInformation @username , @password , @permision";
                dt = DataProvider.Instance.ExecuteQuery(query, new object[] {username, password, permision});
                return dt.Rows.Count > 0;

        }
        public DataTable getInforAboutImages(string manguoidung,int status)
        {
            string query = "getInforAboutImages @manguoidung , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { manguoidung, status });
            return dt;

        }
    }

}
