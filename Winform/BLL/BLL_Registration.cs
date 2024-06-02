using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Registration
    {
        DAL.DAL_Registration dalRegistration= new DAL_Registration();
        public DataTable getTT_TrinhDoHocVan(string username)
        {
            return dalRegistration.getTT_TrinhDoHocVan(username);
        }
        public DataTable getTT_thanhVien_DeTai(string id,int status)
        {
            return dalRegistration.getTT_thanhVien_DeTai(id,status);
        }
        public bool topicRegistration(string tenDeTai,string idGVHD,int maDotToChuc,string kinhPhi,int matrangthai)
        {
            return dalRegistration.topicRegistration(tenDeTai, idGVHD, maDotToChuc, kinhPhi, matrangthai);
        }
        public bool groupRegistration(string tenNhom,int soluongTV,string tenDeTai)
        {
            return dalRegistration.groupRegistration(tenNhom, soluongTV, tenDeTai);
        }
        public bool newMenberRegistration(string tenDeTai,string mathanhviennhom,int isTeacher)
        {
            return dalRegistration.newMenberRegistration(tenDeTai, mathanhviennhom,isTeacher);
        }
        public DataTable getTopicInformationforSinhVienGiaoVien(string id, int status)
        {
            return dalRegistration.getTopicInformationforSinhVienGiaoVien(id, status);
        }
        public bool deleteTopic(int id, int status)
        {
            return dalRegistration.deleteTopic(id, status);
        }
        public DataTable getInforTopicNeedEdit(int id, int status)
        {
            return dalRegistration.getInforTopicNeedEdit(id, status);
        }
        public DataTable getInformationMember(string id, int status)
        {
            return dalRegistration.getInforMember(id, status);
        }
        public bool updateTopic(string tenDeTai, string idGVHD, string kinhPhi, string linknopbai, int madetai)
        {
            return dalRegistration.updateTopic(tenDeTai, idGVHD, kinhPhi, linknopbai, madetai);
        }
        public bool updateMember(int maDeTai, string maThanhVien, int status,int numMems)
        {
            return dalRegistration.updateMembers(maDeTai,maThanhVien,status,numMems);
        }
        public bool deleteforUpdate(int maDeTai, int status)
        {
            return dalRegistration.delforUpdate(maDeTai,status);
        }
        public bool insertnewBatch(string tenDotToChuc, DateTime ngayBatDau, DateTime hanNopBai, DateTime ngayKetThuc, string ghiChu)
        {
            return dalRegistration.insertNewBatch(tenDotToChuc, ngayBatDau, hanNopBai, ngayKetThuc, ghiChu);
        }
        public bool updateBatch(int maDotToChuc, string tenDotToChuc, DateTime ngayBatDau, DateTime hanNopBai, DateTime ngayKetThuc, string ghiChu)
        {
            return dalRegistration.updateNewBatch(maDotToChuc, tenDotToChuc, ngayBatDau, hanNopBai, ngayKetThuc, ghiChu);
        }
        public DataTable getBatchInfo(int year)
        {
            return dalRegistration.getBatchInformation(year);
        }
        public DataTable getBtchInformation_withID(int id)
        {
            return dalRegistration.getBatchInformation_withID(id);
        }
        public bool deleteBatch(int id)
        {
            return dalRegistration.deleteBatch(id);
        
        }
        public DataTable getSumExpense(int id,int year,int status)
        {
            return dalRegistration.getSumExpense(id,year,status);
        }

    }
}
