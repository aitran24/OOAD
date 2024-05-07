using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD.DTO
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int IDuser {  get; set; }
        public string NameAppoint { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan Starttime { get; set; }
        public TimeSpan Endtime { get; set; }

    }
}
