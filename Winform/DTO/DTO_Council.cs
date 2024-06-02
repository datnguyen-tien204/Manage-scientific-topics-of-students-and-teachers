using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Council
    {
        public int councilID { get; set; }
        public string councilName { get; set; }
        public string leaderID { get; set; }
        public DateTime dateHeld { get; set; }
        public string subjectID { get; set; }
        public int numberMember { get; set; }

        public DTO_Council() { }
        public DTO_Council(int councilID, string cnc_councilName,string cnc_leaderID, DateTime cnc_dateHeld, string cnc_subjectID, int cnc_numberMember)
        {
            this.councilID = councilID;
            this.councilName = cnc_councilName;
            this.leaderID = cnc_leaderID;
            this.dateHeld = cnc_dateHeld;
            this.subjectID = cnc_subjectID;
            this.numberMember = cnc_numberMember;
        }
    }
    internal class DTO_DeatailsCouncil
    {
        public int councilID { get; set; }
        public string teacherID { get; set; }
    }
}
