using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Registration
    {
        DataTable dt;
        public DataTable getTT_TrinhDoHocVan(string id_teacher)
        {
            string query = "PROC_getTT_TrinhDoHocVan @maGV";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id_teacher });
            return dt;
        }
        public DataTable getTT_thanhVien_DeTai(string id,int status)
        {
            string query = "PROC_getTT_thanhVien_DeTai @id , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] {id,status });
            return dt;
        }
        public bool topicRegistration(string tenDeTai,string idGVHD,int maDotToChuc,string kinhPhi,int matrangthai)
        {
            string query = "PROC_updateNewTopics @TenDeTai , @MaNguoiHD , @MaDotToChuc , @KinhPhi , @MaTrangThai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDeTai, idGVHD, maDotToChuc, kinhPhi, matrangthai });
            return result > 0;
        }
        public bool groupRegistration(string tenNhom,int soluongTV,string tenDeTai)
        {
            string query = "PROC_insertnewGroup @TenNhom , @soluongTV , @TenDeTai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenNhom, soluongTV, tenDeTai });
            return result > 0;
            //PROC_insertnewGroup(@TenNhom nchar(50), @soluongTV int, @TenDeTai nvarchar(200))
        }
        public bool newMenberRegistration(string tenDeTai,string mathanhviennhom,int isTeacher)
        {
            //PROC_insertnewMembertoGroup(@TenDeTai nvarchar(200), @MaThanhVien nchar(10), @isTeacher int)
            string query = "PROC_insertnewMembertoGroup @tendetai , @mathanhviennhom , @isteacher ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDeTai, mathanhviennhom,isTeacher });
            return result > 0;
        }
        public DataTable getTopicInformationforSinhVienGiaoVien(string id, int status)
        {
            string query = "PROC_getTopicInformationforSinhVienGiaoVien @id , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id, status });
            return dt;
        }
        public bool deleteTopic(int id, int status)
        {
            string query = "PROC_deleteTopics_Group @id , @status";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,status });
            return result > 0;
        }
        public DataTable getInforTopicNeedEdit(int id, int status)
        {
            string query = "PROC_getInforTopicNeedEdit @id , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id, status });
            return dt;
        }
        public DataTable getInforMember(string id,int status)
        {
            string query = "PROC_getNameMember @id , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id, status });
            return dt;
        }
        public bool updateTopic(string tenDeTai, string idGVHD, string kinhPhi, string linknopbai ,int madetai)
        {
            string query = "PROC_UpdateTopicsInformation @TenDeTai , @MaNguoiHD ,  @KinhPhi , @linknopbai , @madetai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDeTai, idGVHD,kinhPhi, linknopbai,madetai });
            return result > 0;
        }
        public bool updateMembers(int maDeTai, string maThanhVien, int status, int soLuongThanhVien)
        {
            string query = "PROC_updateNewMember @MaDeTai , @MaThanhVien ,  @status , @SoLuongTV ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDeTai,maThanhVien,status,soLuongThanhVien});
            return result > 0;
        }
        public bool delforUpdate(int maDeTai,int status)
        {
            string query = "PROC_delforUpdateMembers @MaDeTai , @status) ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maDeTai,status });
            return result > 0;
        }
        public bool insertNewBatch(string tenDotToChuc, DateTime ngayBatDau, DateTime hanNopBai, DateTime ngayKetThuc, string ghiChu)
        {
            string query = "PROC_insertDotMoi @TenDotToChuc , @NgayBatDau ,  @HanNopBai , @NgayKetThuc , @Loai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenDotToChuc, ngayBatDau, hanNopBai,ngayKetThuc,ghiChu});
            return result > 0;
        }
        public bool updateNewBatch(int id,string tenDotToChuc, DateTime ngayBatDau, DateTime hanNopBai, DateTime ngayKetThuc, string ghiChu)
        {
            string query = "PROC_updateDot @id , @TenDotToChuc , @NgayBatDau ,  @HanNopBai , @NgayKetThuc , @Loai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, tenDotToChuc, ngayBatDau, hanNopBai, ngayKetThuc, ghiChu });
            return result > 0;
        }
        public DataTable getBatchInformation(int year)
        {
            string query = " PROC_getInformationBatch @year ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] {year});
            return dt;
        }

        public DataTable getBatchInformation_withID(int id)
        {
            string query = "PROC_getInformation_withID @id ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public bool deleteBatch(int id)
        {
            string query = "PROC_delBatchInformation_withID @id ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        public DataTable getSumExpense(int madot,int year,int status)
        {
            string query = "PROC_sumExpense @madot , @year , @status ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { madot,year,status });
            return dt;
        }
    }
}
