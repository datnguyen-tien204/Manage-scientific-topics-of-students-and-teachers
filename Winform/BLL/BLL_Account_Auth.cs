using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Account_Auth
    {
        DAL_Account_Auth dalManageAccount = new DAL_Account_Auth();
        public bool LoginAuthentication(string username, string password,int permision)
        {
            return dalManageAccount.LoginAuthentication(username, password,permision);
        }
        public DataTable getInforAboutImages(string manguoidung, int status)
        {
            return dalManageAccount.getInforAboutImages(manguoidung, status);
        }
    }
}
