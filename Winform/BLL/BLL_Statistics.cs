using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Statistics
    {
        DAL.DAL_Statistics dalStatistics = new DAL.DAL_Statistics();
        public System.Data.DataTable AnalysisByRoLe()
        {
            return dalStatistics.AnalysisByRoLe();
        }
        public System.Data.DataTable AnalysisBySex()
        {
            return dalStatistics.AnalysisBySex();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn7Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn7Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn13Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn13Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn21Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn21Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn28Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn28Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn30Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn30Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn90Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn90Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn180Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn180Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongIn365Days()
        {
            return dalStatistics.PROC_TotalNewPhanCongIn365Days();
        }
        public System.Data.DataTable PROC_TotalNewPhanCongInPeriod(string startdate,string endate)
        {
            return dalStatistics.PROC_TotalNewPhanCongInPeriod(startdate,endate);
        }
        public System.Data.DataTable PROC_getGeographical()
        {
            return dalStatistics.PROC_getGeographical();
        }
        public System.Data.DataTable AnalysisByTopics()
        {
            return dalStatistics.AnalysisByTopics();
        }

        public DataSet AnalysisByDataSetTopics()
        {
            return dalStatistics.AnalysisByDataSetTopics();
        }
        public DataSet PROC_getInforTestGV()
        {
            return dalStatistics.PROC_getInforTestGV();
        }
        public DataTable PROC_countTopicsbyBatch(string mathanhvien, int status)
        {
            return dalStatistics.PROC_countTopicsbyBatch(mathanhvien, status);
        }
    }
}
