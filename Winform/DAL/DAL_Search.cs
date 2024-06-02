using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Search
    {
        DataTable dt;
        DataSet ds;
        public DataTable TimTaiLieu(string TenTaiLieu)
        {
            string query = "TimTaiLieu @TenTaiLieu ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { TenTaiLieu });
            return dt;
        }

        public DataTable PROC_getLinkTaiLieu(int matailieu)
        {
            string query = "PROC_getLinkTaiLieu @matailieu ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { matailieu });
            return dt;
        }
        public DataTable PROC_getAllInfDocument()
        {
            string query = "PROC_getAllInfDocument";
            dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public DataTable PROC_getAllInfDocumentbyID(int matailieu)
        {
            string query = "PROC_getAllInfDocumentbyID @matailieu ";
            dt = DataProvider.Instance.ExecuteQuery(query, new object[] { matailieu });
            return dt;
        }
        public bool UpdateTaiLieu(int MaTaiLieu,string TenTaiLieu, string LinkTaiLieu,string MaBoMon,string MLA,string APA , string BibText)
        {
            string query = "UpdateTaiLieu @MaTaiLieu , @TenTaiLieu , @LinkTaiLieu , @MaBoMon , @MLA , @APA , @BibText ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTaiLieu, TenTaiLieu, LinkTaiLieu, MaBoMon, MLA, APA, BibText });
            return result > 0;
        }    
        public bool PROC_deleteDocument(int MaTaiLieu)
        {
            string query = " PROC_deleteDocument @MaTaiLieu ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaTaiLieu });
            return result > 0;
        }
        public bool InsertTaiLieu(string TenTaiLieu, string LinkTaiLieu, string MaBoMon, string MLA, string APA, string BibText)
        {
            string query = "InsertTaiLieu @TenTaiLieu , @LinkTaiLieu , @MaBoMon , @MLA , @APA , @BibText ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenTaiLieu, LinkTaiLieu, MaBoMon, MLA, APA, BibText });
            return result > 0;
        }
    }
}
