using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_ArticleReport
    {
        public int articleID { get; set; }
        public int topicID { get; set; }
        public int councilID { get; set; }
        public float score { get; set; }
        public string Evidence { get; set; }
        public string evaluation { get; set; }

        public DTO_ArticleReport() { }
        public DTO_ArticleReport(int articleID, int ar_topicID, int ar_councilID, float ar_score, string ar_Evidence, string ar_evaluation)
        {
            this.articleID = articleID;
            this.topicID = ar_topicID;
            this.councilID = ar_councilID;
            this.score = ar_score;
            this.Evidence = ar_Evidence;
            this.evaluation = ar_evaluation;
        }

    }
}
