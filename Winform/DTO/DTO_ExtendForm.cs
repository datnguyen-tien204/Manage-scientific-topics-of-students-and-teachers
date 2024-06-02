using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_ExtendForm
    {
        public int extendFormID { get; set; }
        public string teacherInstructID { get; set; }
        public int topicID { get; set; }
        public string groupID { get; set; }
        public DateTime dateExtend { get; set; }
        public DateTime dateComplete { get; set; }
        public string linkExtendForm { get; set; }
        public string reason { get; set; }
        public int IsAccepted { get; set; }

        public DTO_ExtendForm() { }
        public DTO_ExtendForm(int extendFormID, string exf_teacherInstructID, int exf_topicID, string exf_groupID, DateTime exf_dateExtend, DateTime exf_dateComplete, string exf_linkExtendForm, string exf_reason, int exf_IsAccepted)
        {
            this.extendFormID = extendFormID;
            this.teacherInstructID = exf_teacherInstructID;
            this.topicID = exf_topicID;
            this.groupID = exf_groupID;
            this.dateExtend = exf_dateExtend;
            this.dateComplete = exf_dateComplete;
            this.linkExtendForm = exf_linkExtendForm;
            this.reason = exf_reason;
            this.IsAccepted = exf_IsAccepted;
        }
    }
}
