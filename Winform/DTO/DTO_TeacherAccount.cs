using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_TeacherAccount
    {
        public string TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherPassword { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public string CCCD { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int academicRankID { get; set; }
        public string SubjectID { get; set; }

        public DTO_TeacherAccount() { }
        public DTO_TeacherAccount(string teacherID, string teacherName, string teacherPassword, int tc_sex, int tc_age, string tc_cCCD, string tc_address, string tc_phoneNumber, string tc_email, int tc_academicRank, string tc_subjectID)
        {
            TeacherID = teacherID;
            TeacherName = teacherName;
            TeacherPassword = teacherPassword;
            Sex = tc_sex;
            Age = tc_age;
            CCCD = tc_cCCD;
            Address = tc_address;
            PhoneNumber = tc_phoneNumber;
            Email = tc_email;
            academicRankID = tc_academicRank;
            SubjectID = tc_subjectID;
        }
    }
    internal class DTO_AcademicRank
    {
        public int academicRankID { get; set; }
        public string academicRankName { get; set; }

        public DTO_AcademicRank() { }
        public DTO_AcademicRank(int academicRankID, string academicRankName)
        {
            this.academicRankID = academicRankID;
            this.academicRankName = academicRankName;
        }
    }
}
