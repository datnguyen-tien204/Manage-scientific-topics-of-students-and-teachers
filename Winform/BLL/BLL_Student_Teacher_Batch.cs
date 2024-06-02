using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Student_Teacher_Batch
    {
        DAL.DAL_GetInfor_From_Batch da_batch = new DAL.DAL_GetInfor_From_Batch();
        public DataTable getBatchInfor(int status)
        {
            return da_batch.getStatusInfor(status);
        }

    }
}
