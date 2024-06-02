using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_expToFile
    {
        DataSet ds;
        public DataSet PROC_getInforGV()
        {
            string query = "PROC_getInforGV";
            ds = DataProvider.Instance.ExecuteQueryDataSet(query);
            return ds;
        }
        public DataSet PROC_getInforSV()
        {
            string query = "PROC_getInforSV";
            ds = DataProvider.Instance.ExecuteQueryDataSet(query);
            return ds;
        }
        public DataSet getInformationFromTopicsXport()
        {
            string query = "getInformationFromTopicsXport";
            ds = DataProvider.Instance.ExecuteQueryDataSet(query);
            return ds;
        }
        public DataSet getInforTopicWithStatus(int idstatus)
        {
            string query = "getInforTopicWithStatus @idstatus ";
            ds = DataProvider.Instance.ExecuteQueryDataSet(query, new object[] { idstatus });
            return ds;
        }
    }
}
