using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Topics
    {
        DAL.DAL_GetInfo_from_Topics da_topics= new DAL.DAL_GetInfo_from_Topics();
        public int GetNumberOfTopics(int status)
        {
            return da_topics.GetNumberOfTopics(status);
        }
        public DataTable getInforTopics(int status)
        {
            return da_topics.getInforTopics(status);
        }
        public DataTable getTopic_NameTopic_andSubject(int status)
        {
            return da_topics.getTopic_NameTopic_andSubject(status);
        }
        public DataTable getTopic_Details(int id)
        {
            return da_topics.getTopic_Details(id);
        }
        public DataTable getInstructor_Details(string id)
        {
            return da_topics.getInstructor_Details(id);
        }
        public DataTable getBatchInfo(int id)
        {
            return da_topics.getBatchInfo(id);
        }
        public DataTable getStatusInfor(int id)
        {
            return da_topics.getStatusInfor(id);
        }
        public bool UPDATE_STaTus_2(int MaDeTai)
        {
            return da_topics.UPDATE_STaTus_2(MaDeTai);
        }
        public bool updateNewStatus(int madetai, int status)
        {
            return da_topics.updateNewStatus(madetai, status);
        }
        public DataTable getIDTopics(string mathanhvien,int status)
        {
            return da_topics.getIDTopics(mathanhvien, status);
        }
        public DataTable getInformationAboutDeTai(int madetai, int status)
        {
            return da_topics.getInformationAboutDeTai(madetai, status);
        }
        public DataTable searchTopicsByName(string tendetai,int status)
        {
            return da_topics.searchTopicsByName(tendetai,status);
        }    

    }
}
