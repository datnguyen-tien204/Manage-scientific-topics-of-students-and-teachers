using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Manage_Account
    {
        public string ManagenmentID { get; set; }
        public string ManagementName { get; set; }
        public string ManagementPassword { get; set; }
        public int Sex { get; set; }
        public string CCCD { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public DTO_Manage_Account() { }
        public DTO_Manage_Account(string managenmentID, string managementName, string managementPassword, int mag_sex, string mag_cCCD, string mag_address, string mag_phoneNumber, string mag_email)
        {
            ManagenmentID = managenmentID;
            ManagementName = managementName;
            ManagementPassword = managementPassword;
            Sex = mag_sex;
            CCCD = mag_cCCD;
            Address = mag_address;
            PhoneNumber = mag_phoneNumber;
            Email = mag_email;
        }
    }
}
