using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.DTO
{
    internal class Reminder
    {
        public int ReminderID { get; set; }
        public int ReminderOffsetMinutes { get; set; }
        public string NameReminder { get; set; }
        public string Description { get; set; }
        public DateTime ReminderDateTime { get; set; }
    }
}
