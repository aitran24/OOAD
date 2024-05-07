using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.DTO
{
    internal class Meetings
    {
        public int MeetingID { get; set; }
        public int OrganizerUserID { get; set; }
        public string MeetingName { get; set; }
     //   public string Description { get; set; }
        public DateTime MeetingDateTime { get; set; }
    }
}
