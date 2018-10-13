using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFTS.Models
{
    public class EventSchduleViewModel
    {
        public int scheduleId;
        public string eventName;
        public string coach;

        public List <Event> Events;
        public List<Schedule> MemberSchedule;
        public List<Member> Members;
        public List<Schedule> Schedules;

    }
}
