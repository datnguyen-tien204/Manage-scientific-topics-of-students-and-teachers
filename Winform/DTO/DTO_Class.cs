using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Class
    {
        public string classID { get; set; }
        public string subjectID { get; set; }
        public string className { get; set; }
        public int numberStudent { get; set; }
        public string teacherID { get; set; }
        public string schoolYear { get; set; }

        public DTO_Class() { }
        public DTO_Class(string classID, string cls_subjectID, string cls_className, int cls_numberStudent, string cls_teacherID, string cls_schoolYear)
        {
            this.classID = classID;
            this.subjectID = cls_subjectID;
            this.className = cls_className;
            this.numberStudent = cls_numberStudent;
            this.teacherID = cls_teacherID;
            this.schoolYear = cls_schoolYear;
        }

    }
}
