using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_topic
    {
        public int topicID { get; set; }
        public string topicName { get; set; }
        public string leaderTopicID { get; set; }
        public string instructorID { get; set; }
        public float money { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string result { get; set; }
        public string linkSubmit { get; set; }
        public int statusID { get; set; }
        public int councilID { get; set; }
        public string noteTopic { get; set; }

        public DTO_topic() { }
        public DTO_topic(int topicID, string topicName, string leaderTopicID, string top_instructorID, float top_money, DateTime top_startDate, DateTime top_endDate, string top_result, string top_linkSubmit, int top_statusID, int top_councilID, string top_noteTopic)
        {
            this.topicID = topicID;
            this.topicName = topicName;
            this.leaderTopicID = leaderTopicID;
            this.instructorID = top_instructorID;
            this.money = top_money;
            this.startDate = top_startDate;
            this.endDate = top_endDate;
            this.result = top_result;
            this.linkSubmit = top_linkSubmit;
            this.statusID = top_statusID;
            this.councilID = top_councilID;
            this.noteTopic = top_noteTopic;
        }

    }
}
