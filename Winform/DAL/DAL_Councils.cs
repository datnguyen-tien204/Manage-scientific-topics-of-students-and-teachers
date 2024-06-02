using OfficeOpenXml.FormulaParsing.Excel.Functions.Database;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Councils
    {
        DataTable dt;
        List<int> list = new List<int>();
        public DataTable getInforCouncil(int id,int status)
        {
            string query = "PROC_informationCouncil @id , @status ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id,status });
            return dt;
        }
        public bool PROC_insertCouncil(string name, string ngaythanglap, int mabomon, int soluongTV)
        {
            string query = "PROC_insertNewCouncil @TenHoiDong , @NgayThanhLap , @MaBoMon , @SoLuongTV ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name,ngaythanglap,mabomon,soluongTV});
            return result > 0;
        }
        public bool PROC_insertNewMemberToCouncil(string TenHoiDong,string MaGiaoVien)
        {
            string query = "PROC_insertNewMemberToCouncil @MaHoiDong , @MaGiaoVien ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenHoiDong, MaGiaoVien });
            return result > 0;
        }
        public bool PROC_editCouncil(int MaHoiDong,string TenHoiDong,string ngayThanhLap, int MaBoMon, int SoLuongTV)
        {
            string query = "PROC_editCouncil @MaHoiDong , @TenHoiDong , @NgayThanhLap , @MaBoMon , @SoLuongTV ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaHoiDong, TenHoiDong, ngayThanhLap, MaBoMon, SoLuongTV });
            return result > 0;
        }
        public bool PROC_updateMemCouncils(int MaHoiDong, string MaThanhVien, int status)
        {
            string query = "PROC_updateMemCouncils @MaHoiDong , @MaThanhVien , @status ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaHoiDong, MaThanhVien, status });
            return result > 0;
        }
        public DataTable PROC_getMemCouncils(int MaHoiDong)
        {
            string query = "PROC_getMemCouncils @MaHoiDong ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaHoiDong });
            return dt;
        }
        public bool delCouncils(int MaHoiDong,int status)
        {
            string query = "delCouncils @MaHoiDong , @status ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaHoiDong, status });
            return result > 0;
        }
        // Phân công
        public DataTable getInforAssign(int MaPhanCong,int status)
        {
            string query = "getInforAssign @MaPhanCong , @status ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaPhanCong, status });
            return dt;
        }
        public DataTable getCouncilName(int mahoidong)
        {
            string query = "getCouncilName @mahoidong";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { mahoidong});
            return dt;
        }
        public DataTable getTopicsName(int madetai)
        {
            string query = "getTopicsName @madetai";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { madetai});
            return dt;
        }
        public int getCountTopicsDefend(int mahoidong)
        {

            string query = "getCountTopicsDefend @mahoidong";
            object topics = DataProvider.Instance.ExecuteScalar(query, new object[] { mahoidong });

            return (int)topics;
        }
        public List<int> GetAllMaHoiDong()
        {
            string query = "SELECT MaHoiDong FROM HoiDongBaoVe";
            list = DataProvider.Instance.GetAllMaHoiDong(query);
            return list;
        }
        public bool PROC_assignFORCouncils(int mahoidong, int madetai ,string ngayphancong ,int trangthai)
        {
            string query = "PROC_assignFORCouncils @mahoidong , @madetai , @ngayphancong , @trangthai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahoidong, madetai, ngayphancong, trangthai });
            return result > 0;
        }

        // Teacher Assignment
        public DataTable getMaPhanCongtuMaGiaoVien( string magiaovien)
        {
            string query = "getMaPhanCongtuMaGiaoVien @magiaovien ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { magiaovien });
            return dt;
        }
        public DataTable getInf_of_LeaderAssign(int MaPhanCong)
        {
            string query = "getInf_of_LeaderAssign @MaPhanCong ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaPhanCong});
            return dt;
        }
        public DataTable getDetailPhanCong(int MaPhanCong)
        {
            string query = "getDetailPhanCong @MaPhanCong ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { MaPhanCong });
            return dt;
        }
        public bool updateHDBVWhenAccept(int MaPhanCong, int status)
        {
            string query = "updateHDBVWhenAccept @MaPhanCong , @status ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaPhanCong, status });
            return result > 0;
        }

        //Bảo vệ đề tài(dành cho giáo viên)
        public DataTable getFullInfTopics(int maPhanCong, string magiaovien)
        {
            string query = "getFullInfTopics @maPhanCong , @magiaovien ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maPhanCong, magiaovien});
            return dt;
        }
        public bool InsertNewYKien(string MaThanhVien ,int MaPhanCong ,string yKien,float ChamDiem ,string GhiChu,int status )
        {
            string query = "InsertNewYKien @MaThanhVien , @MaPhanCong , @yKien , @ChamDiem , @GhiChu , @status ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaThanhVien, MaPhanCong, yKien, ChamDiem, GhiChu, status });
            return result > 0;
        }
        public DataTable getInfOfTopics(int maphancong)
        {
            string query = "getInfOfTopics @maphancong ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maphancong });
            return dt;
        }
        public bool updateYKien(string MaThanhVien,string yKien,float ChamDiem ,string GhiChu)
        {
            string query = "updateYKien @MaThanhVien , @yKien , @ChamDiem , @GhiChu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaThanhVien, yKien, ChamDiem, GhiChu });
            return result > 0;
        }

        public DataTable PROC_getIDCouncilFromTeacher(string magiaovien)
        {
            string query = "PROC_getIDCouncilFromTeacher @magiaovien ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { magiaovien });
            return dt;
        }    
        public DataTable PROC_getLeaderFromCouncils(int mahoidong)
        {
            string query = "PROC_getLeaderFromCouncils @mahoidong ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { mahoidong });
            return dt;
        }

        public DataTable getAllOpinion(int maphancong)
        {
            string query = "getAllOpinion @maphancong ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { maphancong });
            return dt;
        }

        public DataTable PROC_getMaDeTaiFromIDGiaoVien(string magiaovien)
        {
            string query = "PROC_getMaDeTaiFromIDGiaoVien @magiaovien ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { magiaovien });
            return dt;
        }    

        public DataTable PROC_getIDCouncil_getIDTopics(string magiaovien, int mahoidong, int status)
        {
            string query = "PROC_getIDCouncil_getIDTopics @magiaovien , @mahoidong , @status ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { magiaovien, mahoidong,status });
            return dt;
        }

        public DataTable PROC_getInformationForGradeTotal(int madetai,int mahoidong)
        {
            string query = "PROC_getInformationForGradeTotal @madetai , @mahoidong ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { madetai, mahoidong });
            return dt;
        }
        public bool PROC_updateInformation(int madetai,int mahoidong,float diem,string minhchung,string DanhGia)
        {
            string query = "PROC_updateInformation @madetai , @mahoidong , @diem , @minhchung , @DanhGia ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madetai, mahoidong, diem, minhchung, DanhGia });
            return result > 0;
        }

        //Lấy thông tin sửa phân công hội đồng
        public DataTable getInforForEditAssignment(int madetai)
        {
            string query = "getInforForEditAssignment @madetai ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { madetai });
            return dt;
        }
        public bool updateNewInforPhanCong(int madetai,int mahoidong,string ngayphancong)
        {
            string query = "updateNewInforPhanCong @madetai , @mahoidong , @ngayphancong ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madetai, mahoidong, ngayphancong });
            return result > 0;
        }
    }
}
