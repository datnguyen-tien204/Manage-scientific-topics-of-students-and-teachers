using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Users
    {   
        DAL_Users dalUsers = new DAL_Users();
        public DataTable PROC_getUserList(int status)
        {
            return dalUsers.PROC_getUserList(status);
        }     
        public bool PROC_insertTeacher(string MaGV, string tenGV, int GioiTinh, string SDT, string Email, string DiaChi, int trinhDoHV, int MaQuyen, int MaBoMon)
        {
            return dalUsers.PROC_insertTeacher(MaGV, tenGV, GioiTinh, SDT, Email, DiaChi, trinhDoHV, MaQuyen, MaBoMon);
        }
        public bool PROC_updateTeacher(string MaGV, string tenGV, int GioiTinh, string SDT, string Email, string DiaChi, int trinhDoHV, int MaQuyen, int MaBoMon)
        {
            return dalUsers.PROC_updateTeacher(MaGV, tenGV, GioiTinh, SDT, Email, DiaChi, trinhDoHV, MaQuyen, MaBoMon);
        }
        public bool PROC_deleteUser(string id, int status)
        {
            return dalUsers.PROC_deleteUser(id,status);
        }
        public DataTable PROC_getUserInformationwithID(string id, int status)
        {
            return dalUsers.PROC_getUserInformationwithID(id, status);
        }
        public bool PROC_resetPassword(string id, int status)
        {
            return dalUsers.PROC_resetPassword(id, status);
        }
        public bool PROC_insertNewStudent(string MaSV, string tenSV, int GioiTinh, string CMND, string SDT, string Email, string DiaChi, string MaLop,int MaQuyen)
        {
            return dalUsers.PROC_insertNewStudent(MaSV, tenSV, GioiTinh, CMND, SDT, Email, DiaChi, MaLop,MaQuyen);
        }
        public bool PROC_updateStudent(string MaSV, string tenSV, int GioiTinh, string CMND, string SDT, string Email, string DiaChi, string MaLop,int MaQuyen)
        {
            return dalUsers.PROC_updateStudent(MaSV, tenSV, GioiTinh, CMND, SDT, Email, DiaChi, MaLop, MaQuyen);
        }

        public DataTable PROC_getInfoUser(string id, int status)
        {
            return dalUsers.PROC_getInfoUser(id, status);
        }

        public bool UPDATE_InformationUser(string manguoidung, int status, string Email, string SDT, int gioitinh, string diachi, string lopORMaBoMon, string matkhau, string CCCD)
        {
            return dalUsers.UPDATE_InformationUser(manguoidung, status, Email, SDT, gioitinh, diachi, lopORMaBoMon, matkhau, CCCD);
        }
    }
}
