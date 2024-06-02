using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Assign
    {
        public int assignID { get; set; }
        public int councilID { get; set; }
        public int topicID { get; set; }
        public DateTime dateAssign { get; set; }
        public string noteAssign { get; set; }

        public DTO_Assign() { }
        public DTO_Assign(int assignID, int asg_councilID, int asg_topicID, DateTime asg_dateAssign, string asg_noteAssign)
        {
            this.assignID = assignID;
            this.councilID = asg_councilID;
            this.topicID = asg_topicID;
            this.dateAssign = asg_dateAssign;
            this.noteAssign = asg_noteAssign;
        }
    }
    public class DTO_AssignDetails
    {
        public int assignID { get; set; }
        public string typeAssign { get; set; }

        public DTO_AssignDetails(){}
        public DTO_AssignDetails(int assignID, string asg_typeAssign)
        {
            this.assignID = assignID;
            this.typeAssign = asg_typeAssign;
        }
    }
    public class TypeAssign
    {
        public int typeAssignID { get; set; }
        public string nameTypeAssign { get; set; }
    }
}
