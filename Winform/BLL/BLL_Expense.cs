using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Expense
    {
        DataTable dt;
        DAL.DAL_KinhPhi dal_kinhphi = new DAL.DAL_KinhPhi();
        public DataTable PROC_getTongKinhPhiSV_GV(int status)
        {
            return dal_kinhphi.PROC_getTongKinhPhiSV_GV(status);
        }
        public DataTable getDeTaiSinhVien(int status)
        {
            return dal_kinhphi.getDeTaiSinhVien(status);
        }
        public DataTable PROC_getStatusDeTai(int madetai)
        {
            return dal_kinhphi.PROC_getStatusDeTai(madetai);
        }
        public bool PROC_updateExpense(int madetai, string sotien)
        {
            return dal_kinhphi.PROC_updateExpense(madetai, sotien);
        }
    }
}
