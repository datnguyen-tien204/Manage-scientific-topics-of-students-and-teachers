using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Prize
    {
        public int prizeID { get; set; }
        public string namePrize { get; set; }
        public string topicID { get; set; }
        public DateTime datePrize { get; set; }

        public DTO_Prize() { }
        public DTO_Prize(int prizeID, string pr_namePrize, string pr_topicID, DateTime pr_datePrize)
        {
            this.prizeID = prizeID;
            this.namePrize = pr_namePrize;
            this.topicID = pr_topicID;
            this.datePrize = pr_datePrize;
        }
    }
    internal class DTO_Recommend
    {
        public int recommendID { get; set; }
        public int prizeID { get; set; }

        public DTO_Recommend() { }
        public DTO_Recommend(int recommendID, int rec_prizeID)
        {
            this.recommendID = recommendID;
            this.prizeID = rec_prizeID;
        }
    }
    
}
