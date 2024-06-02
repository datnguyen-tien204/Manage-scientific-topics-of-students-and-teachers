using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Students_Account
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentPassword { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public string CCCD { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ClassID { get; set; }
        public string GroupID { get; set; }

        public DTO_Students_Account() { }
        public DTO_Students_Account(string studentID, string studentName, string studentPassword, int stu_sex,int stu_age, string stu_cCCD, string stu_address, string stu_phoneNumber, string stu_email, string stu_classID, string stu_groupID)
        {
            StudentID = studentID;
            StudentName = studentName;
            StudentPassword = studentPassword;
            Sex = stu_sex;
            Age = stu_age;
            CCCD = stu_cCCD;
            Address = stu_address;
            PhoneNumber = stu_phoneNumber;
            Email = stu_email;
            ClassID = stu_classID;
            GroupID = stu_groupID;
        }
    }
}
