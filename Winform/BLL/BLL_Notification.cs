using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Notification
    {
        DAL_Notification dalNotification = new DAL_Notification();
        public DataTable PROC_getInfNotification(int status)
        {
            return dalNotification.PROC_getInfNotification(status);
        }
        public bool PROC_NewNoti(string TenThongBao, string NoiDungThongBao, string NgayGui, string MaNguoiNhan, int status)
        {
            return dalNotification.PROC_NewNoti(TenThongBao, NoiDungThongBao, NgayGui, MaNguoiNhan, status);
        }
    }
}
