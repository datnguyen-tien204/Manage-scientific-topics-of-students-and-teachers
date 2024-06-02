using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Subjects
    {
        public string subjectID { get; set; }
        public string subjectName { get; set; }
        public string teacherLeaderID { get; set; }
        public int numberMember { get; set; }

        public DTO_Subjects() { }

        public DTO_Subjects(string sub_subjectID, string sub_subjectName, string sub_teacherLeaderID, int sub_numberMember)
        {
            this.subjectID = sub_subjectID;
            this.subjectName = sub_subjectName;
            this.teacherLeaderID = sub_teacherLeaderID;
            this.numberMember = sub_numberMember;
        }
    }
}
