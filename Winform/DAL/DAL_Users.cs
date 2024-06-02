using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Users
    {
        DataTable dt;
        public DataTable PROC_getUserList(int status)
        {
            string query = "PROC_getUserList @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { status });
            return dt;
        }
        public bool PROC_insertTeacher(string MaGV, string tenGV,int GioiTinh,string SDT, string Email, string DiaChi, int trinhDoHV,int MaQuyen,int MaBoMon)
        {
            string query = "PROC_insertNewTeacher @MaGV , @TenGV , @GioiTinh , @SDT , @Email , @DiaChi , @TrinhDoHV , @MaQuyen , @MaBM ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaGV, tenGV, GioiTinh, SDT, Email, DiaChi, trinhDoHV, MaQuyen, MaBoMon });
            return result > 0;
        }
        public bool PROC_updateTeacher(string MaGV, string tenGV, int GioiTinh, string SDT, string Email, string DiaChi, int trinhDoHV, int MaQuyen, int MaBoMon)
        {
            string query = "PROC_updateTeacher @MaGV , @TenGV , @GioiTinh , @SDT , @Email , @DiaChi , @TrinhDoHV , @MaQuyen , @MaBM ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaGV, tenGV, GioiTinh, SDT, Email, DiaChi, trinhDoHV, MaQuyen, MaBoMon});
            return result > 0;
        }
        public bool PROC_deleteUser(string id,int status)
        {
            string query = "PROC_delUser @id , @status ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,status});
            return result > 0;
        }
        public DataTable PROC_getUserInformationwithID(string id, int status)
        {
            string query = "PROC_getUserInformationwithID @id , @status ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id,status });
            return dt;
        }
        public bool PROC_resetPassword(string id, int status)
        {
            string query = "PROC_resetPassword @id , @status";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, status });
            return result > 0;
        }
        public bool PROC_insertNewStudent(string MaSV, string tenSV, int GioiTinh, string CMND, string SDT, string Email, string DiaChi, string MaLop, int MaQuyen)
        {
            string query = "PROC_insertNewStudent @MaSV , @TenGV , @GioiTinh , @CCCD , @SDT , @Email , @DiaChi , @MaLop , @MaQuyen";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSV, tenSV, GioiTinh, CMND, SDT, Email, DiaChi, MaLop,MaQuyen });
            return result > 0;
        }
        public bool PROC_updateStudent(string MaSV, string tenSV, int GioiTinh, string CMND, string SDT, string Email, string DiaChi, string MaLop, int MaQuyen)
        {
            string query = "PROC_updateStudent @MaSV , @TenGV , @GioiTinh , @CCCD , @SDT , @Email , @DiaChi , @MaLop , @MaQuyen";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaSV, tenSV, GioiTinh, CMND, SDT, Email, DiaChi, MaLop,MaQuyen });
            return result > 0;
        }

        public DataTable PROC_getInfoUser(string id, int status)
        {
            string query = "PROC_getInfoUser @id , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id, status });
            return dt;
        }
        public bool UPDATE_InformationUser(string manguoidung,int status,string Email,string SDT,int gioitinh,string diachi,string lopORMaBoMon,string matkhau,string CCCD)
        {
            string query = "UPDATE_InformationUser @manguoidung , @status , @Email , @SDT , @gioitinh , @diachi , @lopORMaBoMon , @matkhau , @CCCD";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { manguoidung, status, Email, SDT, gioitinh, diachi, lopORMaBoMon, matkhau, CCCD });
            return result > 0;
        }
    }
}
