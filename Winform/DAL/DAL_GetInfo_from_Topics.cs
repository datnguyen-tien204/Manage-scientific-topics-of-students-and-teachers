using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GetInfo_from_Topics:DataProvider
    {
        DataTable dt;
        public int GetNumberOfTopics(int status)
        {

            string query = "PROC_GetNumberOfTopic @status";
            object topics = DataProvider.Instance.ExecuteScalar(query, new object[] { status });

            return (int)topics;
        }
        public DataTable getInforTopics(int status)
        {
            string query = "PROC_GetTopic @Status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { status });
            return dt;
        }
        public DataTable getTopic_NameTopic_andSubject(int status)
        {
            string query = "PROC_Topic_NameTopic_andSubject @Status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { status });
            return dt;
        }    
        public DataTable getTopic_Details(int id)
        {
            string query = "PROC_Topic_All @TopicID";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public DataTable getInstructor_Details(string id)
        {
            string query = "PROC_getInforInstructor @InstructorID";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public DataTable getBatchInfo(int id)
        {
            string query = "PROC_getInforBatch @MaDot";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public DataTable getStatusInfor(int id)
        {
            string query = "PROC_getInforStatus @MaTT";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return dt;
        }
        public bool UPDATE_STaTus_2( int MaDeTai)
        {
            string query = "UPDATE_STaTus_2 @MaDeTai ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaDeTai });
            return result > 0;
        }

        public bool updateNewStatus(int madetai, int status)
        {
            string query = "updateNewStatus @madetai , @status ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { madetai, status });
            return result > 0;
        }

        public DataTable getIDTopics(string mathanhvien,int status)
        {
            string query = "getIDTopics @mathanhvien , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { mathanhvien,status });
            return dt;
        }

        public DataTable getInformationAboutDeTai(int madetai, int status)
        {
            string query = "getInformationAboutDeTai @madetai , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { madetai, status });
            return dt;
        }
        public DataTable searchTopicsByName(string tendetai,int status)
        {
            string query = "searchTopicsByName @tendetai , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { tendetai,status });
            return dt;
        }
    }
    
}

