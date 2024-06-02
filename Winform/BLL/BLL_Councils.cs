using DAL;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL
{
    public class BLL_Councils
    {
        DataTable dt;
        DAL.DAL_Councils councils = new DAL.DAL_Councils();
        public DataTable PROC_getCouncilList(int id, int status)
        {
            return councils.getInforCouncil(id, status);
        }
        public bool PROC_insertCouncil(string name, string ngaythanglap, int mabomon, int soluongTV)
        {
            return councils.PROC_insertCouncil(name, ngaythanglap, mabomon, soluongTV);
        }
        public bool PROC_insertNewMemberToCouncil(string TenHoiDong, string MaGiaoVien)
        {
            return councils.PROC_insertNewMemberToCouncil(TenHoiDong, MaGiaoVien);
        }
        public bool PROC_updateMemCouncils(int MaHoiDong, string MaThanhVien, int status)
        {
            return councils.PROC_updateMemCouncils(MaHoiDong, MaThanhVien, status);
        }
        public bool PROC_editCouncil(int MaHoiDong, string TenHoiDong, string ngayThanhLap, int MaBoMon, int SoLuongTV)
        {
            return councils.PROC_editCouncil(MaHoiDong, TenHoiDong, ngayThanhLap, MaBoMon, SoLuongTV);
        }
        public DataTable PROC_getMemCouncils(int MaHoiDong)
        {
            return councils.PROC_getMemCouncils(MaHoiDong);
        }
        public bool delCouncils(int MaHoiDong, int status)
        {
            return councils.delCouncils(MaHoiDong, status);
        }
        // Phân công
        public DataTable getInforAssign(int MaPhanCong, int status)
        {
            return councils.getInforAssign(MaPhanCong, status);
        }
        public DataTable getCouncilName(int mahoidong)
        {
            return councils.getCouncilName(mahoidong);
        }
        public DataTable getTopicsName(int madetai)
        {
            return councils.getTopicsName(madetai);
        }
        public int getCountTopicsDefend(int mahoidong)
        {
            return councils.getCountTopicsDefend(mahoidong);
        }
        public List<int> GetAllMaHoiDong()
        {
            return councils.GetAllMaHoiDong();
        }
        public bool PROC_assignFORCouncils(int mahoidong, int madetai, string ngayphancong, int trangthai)
        {
            return councils.PROC_assignFORCouncils(mahoidong, madetai, ngayphancong, trangthai);
        }

        // Laays thoong tin veef trưởng nhóm bảo vệ
        public DataTable getMaPhanCongtuMaGiaoVien(string magiaovien)
        {
            return councils.getMaPhanCongtuMaGiaoVien(magiaovien);
        }
        public DataTable getInf_of_LeaderAssign(int MaPhanCong)
        {
            return councils.getInf_of_LeaderAssign(MaPhanCong);
        }
        public DataTable getDetailPhanCong(int MaPhanCong)
        {
            return councils.getDetailPhanCong(MaPhanCong);
        }
        public bool updateHDBVWhenAccept(int maphancong, int status)
        {
            return councils.updateHDBVWhenAccept(maphancong, status);
        }
        public DataTable getFullInfTopics(int maphancong, string magiaovien)
        {
            return councils.getFullInfTopics(maphancong,magiaovien);
        }    
        public bool InsertNewYKien(string MaThanhVien, int MaPhanCong, string yKien, float ChamDiem, string GhiChu, int status)
        {
            return councils.InsertNewYKien(MaThanhVien, MaPhanCong, yKien, ChamDiem, GhiChu, status);
        }
        public DataTable getInfOfTopics(int maphancong)
        {
            return councils.getInfOfTopics(maphancong);
        }
        public bool updateYKien(string MaThanhVien, string yKien, float ChamDiem, string GhiChu)
        {
            return councils.updateYKien(MaThanhVien, yKien, ChamDiem, GhiChu);
        }
        public DataTable PROC_getIDCouncilFromTeacher(string magiaovien)
        {
            return councils.PROC_getIDCouncilFromTeacher(magiaovien);
        }
        public DataTable PROC_getLeaderFromCouncils(int mahoidong)
        {
            return councils.PROC_getLeaderFromCouncils(mahoidong);
        }

        public DataTable getAllOpinion(int maphancong)
        {
            return councils.getAllOpinion(maphancong);
        }    

        public DataTable PROC_getMaDeTaiFromIDGiaoVien(string magiaovien)
        {
            return councils.PROC_getMaDeTaiFromIDGiaoVien(magiaovien);
        }
        public DataTable PROC_getIDCouncil_getIDTopics(string magiaovien,int mahoidong, int status)
        {
            return councils.PROC_getIDCouncil_getIDTopics(magiaovien, mahoidong, status);
        }
        public DataTable PROC_getInformationForGradeTotal(int madetai, int mahoidong)
        {
            return councils.PROC_getInformationForGradeTotal(madetai, mahoidong);
        }
        public bool PROC_updateInformation(int madetai, int mahoidong, float diem, string minhchung, string DanhGia)
        {
            return councils.PROC_updateInformation(madetai, mahoidong, diem, minhchung, DanhGia);
        }
        public DataTable getInforForEditAssignment(int MaDeTai)
        {
            return councils.getInforForEditAssignment(MaDeTai);
        }
        public bool updateNewInforPhanCong(int madetai, int mahoidong, string ngayphancong)
        {
            return councils.updateNewInforPhanCong(madetai, mahoidong, ngayphancong);
        }
    }
}
