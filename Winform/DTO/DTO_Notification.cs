using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DTO_Notification
    {
        public int notificationID { get; set; }
        public string nameNotification { get; set; }

        public string contentNotification { get; set; }
        public DateTime dateSend { get; set; }
        public int typeNotification { get; set; }

        public DTO_Notification() { }
        public DTO_Notification(int notificationID, string not_nameNotification, string not_content, DateTime not_date, int not_typeNotification)
        {
            this.notificationID = notificationID;
            this.nameNotification = not_nameNotification;
            this.contentNotification = not_content;
            this.dateSend = not_date;
            this.typeNotification = not_typeNotification;
        }
    }
    
}
