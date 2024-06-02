using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KinhPhi
    {
        DataTable dt;
        public DataTable PROC_getTongKinhPhiSV_GV(int status)
        {
            string query = "PROC_getTongKinhPhiSV_GV @status ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] {status });
            return dt;
        }
        public DataTable getDeTaiSinhVien(int status)
        {
            string query = "getDeTaiSinhVien @status ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { status });
            return dt;
        }
        public DataTable PROC_getStatusDeTai(int madetai)
        {
            string query = "PROC_getStatusDeTai @madetai ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] {madetai });
            return dt;
        }
        public bool PROC_updateExpense(int madetai, string sotien)
        {
            string query = "PROC_updateExpense @madetai , @sotien ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madetai, sotien });
            return result > 0;
        }
    }
}
