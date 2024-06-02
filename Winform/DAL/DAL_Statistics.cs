using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Statistics
    {
        DataTable dt;
        DataSet ds;
        public DataTable AnalysisByRoLe()
        {
            string query = "AnalysisByRoLe";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable AnalysisBySex()
        {
            string query = "AnalysisBySex";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn7Days()
        {
            string query = "PROC_TotalNewPhanCongIn7Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn13Days()
        {
            string query = "PROC_TotalNewPhanCongIn13Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn21Days()
        {
            string query = "PROC_TotalNewPhanCongIn21Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn28Days()
        {
            string query = "PROC_TotalNewPhanCongIn28Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn30Days()
        {
            string query = "PROC_TotalNewPhanCongIn30Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn90Days()
        {
            string query = "PROC_TotalNewPhanCongIn90Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn180Days()
        {
            string query = "PROC_TotalNewPhanCongIn180Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongIn365Days()
        {
            string query = "PROC_TotalNewPhanCongIn365Days";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_TotalNewPhanCongInPeriod(string startdate,string enddate)
        {
            string query = "PROC_TotalNewPhanCongInPeriod @startdate , @enddate";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { startdate,enddate });
            return dt;
        }    
        public DataTable PROC_getGeographical()
        {
            string query = "PROC_getGeographical";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable AnalysisByTopics()
        {
            string query = "AnalysisByTopics";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;

        }
        public DataSet AnalysisByDataSetTopics()
        {
            string query = "AnalysisByTopics";
            ds = DataProvider.Instance.ExecuteQueryDataSet(query);
            return ds;
        }
        public DataSet PROC_getInforTestGV()
        {
            string query = "PROC_getInforTestGV";
            ds = DataProvider.Instance.ExecuteQueryDataSet(query);
            return ds;
        }

        public DataTable PROC_countTopicsbyBatch(string mathanhvien, int status)
        {
            string query = "PROC_countTopicsbyBatch @mathanhvien , @status";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { mathanhvien, status });
            return dt;
        }


    }
}
