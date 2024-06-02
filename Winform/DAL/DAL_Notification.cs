using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Notification
    {
        DataTable dt;
        DataSet ds;
        public DataTable PROC_getInfNotification(int status)
        {
            string query = "PROC_getInfNotification @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { status });
            return dt;
        }
        public bool PROC_NewNoti(string TenThongBao,string NoiDungThongBao,string NgayGui,string MaNguoiNhan,int status)
        {
            string query = "PROC_NewNoti @TenThongBao , @NoiDungThongBao , @NgayGui , @MaNguoiNhan , @status";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenThongBao, NoiDungThongBao, NgayGui, MaNguoiNhan, status });
            return result > 0;
        }
    }
}
