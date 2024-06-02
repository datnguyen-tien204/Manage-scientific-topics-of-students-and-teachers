using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_expToFile
    {
        DataSet ds;
        DAL.DAL_expToFile dal_expToFile = new DAL.DAL_expToFile();
        public DataSet PROC_getInforGV()
        {         
            return dal_expToFile.PROC_getInforGV();
        }
        public DataSet PROC_getInforSV()
        {
            return dal_expToFile.PROC_getInforSV();
        }
        public DataSet getInformationFromTopicsXport()
        {
            return dal_expToFile.getInformationFromTopicsXport();
        }
        public DataSet getInforTopicWithStatus(int idstatus)
        {
            return dal_expToFile.getInforTopicWithStatus(idstatus);
        }
    }
}
