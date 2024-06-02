using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Group
    {
        public string groupID { get; set; }
        public string groupName { get; set; }
        public int numberMember { get; set; }
        public string topicID { get; set; }

        public DTO_Group() { } 
        public DTO_Group(string grp_groupID, string grp_groupName, int grp_numberMember, string grp_topicID)
        {
            this.groupID = grp_groupID;
            this.groupName = grp_groupName;
            this.numberMember = grp_numberMember;
            this.topicID = grp_topicID;
        }
    }
    internal class DTO_GroupDetail
    {
        public string groupID { get; set; }
        public string studentID { get; set; }
        public string status { get; set; }

        public DTO_GroupDetail() { }
        public DTO_GroupDetail(string dgrp_groupID, string dgrp_studentID, string dgrp_status)
        {
            this.groupID = dgrp_groupID;
            this.studentID = dgrp_studentID;
            this.status = dgrp_status;
        }
    }    
}
