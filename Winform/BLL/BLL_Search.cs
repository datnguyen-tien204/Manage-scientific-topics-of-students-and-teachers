using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Search
    {
        DAL.DAL_Search dal_search = new DAL.DAL_Search();
        public System.Data.DataTable TimTaiLieu(string TenTaiLieu)
        {
            return dal_search.TimTaiLieu(TenTaiLieu);
        }
        public System.Data.DataTable PROC_getLinkTaiLieu(int matailieu)
        {
            return dal_search.PROC_getLinkTaiLieu(matailieu);
        }

        public DataTable PROC_getAllInfDocument()
        {
            return dal_search.PROC_getAllInfDocument();
        }
        public DataTable PROC_getAllInfDocumentbyID(int matailieu)
        {
            return dal_search.PROC_getAllInfDocumentbyID(matailieu);
        }
        public bool UpdateTaiLieu(int MaTaiLieu, string TenTaiLieu, string LinkTaiLieu, string MaBoMon, string MLA, string APA, string BibText)
        {
            return dal_search.UpdateTaiLieu(MaTaiLieu, TenTaiLieu, LinkTaiLieu, MaBoMon, MLA, APA, BibText);
        }
        public bool PROC_deleteDocument(int MaTaiLieu)
        {
            return dal_search.PROC_deleteDocument(MaTaiLieu);
        }
        public bool InsertTaiLieu(string TenTaiLieu, string LinkTaiLieu, string MaBoMon, string MLA, string APA, string BibText)
        {
            return dal_search.InsertTaiLieu(TenTaiLieu, LinkTaiLieu, MaBoMon, MLA, APA, BibText);
        }
    }
}
